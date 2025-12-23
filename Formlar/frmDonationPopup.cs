using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmDonationPopup : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        public int DonorId { get; set; }

        public frmDonationPopup()
        {
            InitializeComponent();
        }

        private void frmDonationPopup_Load(object sender, EventArgs e)
        {
            var donor = db.donors.Find(DonorId);
            if (donor != null)
            {
                lblDonorName.Text = "Bağışçı: " + donor.name_surname + " (" + donor.blood_type + donor.rh_factor + ")";

                // Son bağış kontrolü
                if (donor.last_donation_date != null)
                {
                    TimeSpan diff = DateTime.Now - donor.last_donation_date.Value;
                    if (diff.TotalDays < 90) // 3 ay kuralı
                    {
                        MessageBox.Show("DİKKAT! Bu bağışçı " + Convert.ToInt32(diff.TotalDays) + " gün önce bağış yapmış. Henüz süresi dolmamış!", "Risk Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            cmbHospital.DataSource = db.hospitals.ToList();
            cmbHospital.DisplayMember = "hospital_name";
            cmbHospital.ValueMember = "hospital_id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbHospital.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen hastane seçiniz.");
                return;
            }

            try
            {
                // Barkod Üretimi: YYYYMMDD + Random(4 hane)
                string datePart = DateTime.Now.ToString("yyyyMMdd");
                Random rnd = new Random();
                string randomPart = rnd.Next(1000, 9999).ToString();
                string barcode = "BAR-" + datePart + "-" + randomPart;

                blood_donations donation = new blood_donations();
                donation.donor_id = DonorId;
                donation.hospital_id = (int)cmbHospital.SelectedValue;
                donation.donation_date = DateTime.Now;
                donation.bag_barcode = barcode;
                donation.amount_ml = 450; // Standart ünite
                donation.status = "Karantina"; // Test edilmeden stoğa girmez

                db.blood_donations.Add(donation);

                // Bağışçının son bağış tarihini güncelle
                var donor = db.donors.Find(DonorId);
                donor.last_donation_date = DateTime.Now;

                db.SaveChanges();

                MessageBox.Show("Bağış başarıyla alındı.\nBarkod: " + barcode + "\nDurum: Laboratuvar Testi Bekliyor", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}