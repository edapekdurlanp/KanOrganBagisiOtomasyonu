using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmBloodStock : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        int selectedDonationId = 0;

        public frmBloodStock()
        {
            InitializeComponent();
        }

        private void frmBloodStock_Load(object sender, EventArgs e)
        {
            LoadStock();
            LoadPendingDonations();
            dtpExpiration.Value = DateTime.Now.AddDays(42); // Tam kan genelde 35-42 gün saklanır
            cmbProductType.SelectedIndex = 0;
        }

        private void LoadStock()
        {
            // Sadece testten geçmiş ve kullanılmamış stokları göster
            var list = (from s in db.blood_stocks
                        join d in db.blood_donations on s.donation_id equals d.donation_id
                        join donor in db.donors on d.donor_id equals donor.donor_id
                        where s.is_used == false
                        select new
                        {
                            StokID = s.stock_id,
                            Barkod = d.bag_barcode,
                            KanGrubu = s.blood_type + " " + s.rh_factor,
                            UrunTipi = s.product_type,
                            SonKullanma = s.expiration_date,
                            RafYeri = s.location_shelf
                        }).ToList();

            dgvStock.DataSource = list;
            dgvStock.Columns[0].Visible = false;
        }

        private void LoadPendingDonations()
        {
            // Henüz test edilmemiş (Status: Karantina) bağışlar
            var list = (from d in db.blood_donations
                        join donor in db.donors on d.donor_id equals donor.donor_id
                        where d.status == "Karantina"
                        select new
                        {
                            Id = d.donation_id,
                            Barkod = d.bag_barcode,
                            Bagisci = donor.name_surname,
                            Tarih = d.donation_date
                        }).ToList();

            dgvPendingDonations.DataSource = list;
            dgvPendingDonations.Columns[0].Visible = false;
        }

        private void dgvPendingDonations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedDonationId = Convert.ToInt32(dgvPendingDonations.Rows[e.RowIndex].Cells[0].Value);
                txtSelectedBarcode.Text = dgvPendingDonations.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            if (selectedDonationId == 0)
            {
                MessageBox.Show("Lütfen soldaki listeden bir bağış seçiniz.");
                return;
            }

            try
            {
                var donation = db.blood_donations.Find(selectedDonationId);
                if (donation == null) return;

                // 1. Test Kaydını Oluştur
                lab_tests test = new lab_tests();
                test.donation_id = selectedDonationId;
                test.test_date = DateTime.Now;
                test.hepatitis_b = chkHepatitisB.Checked;
                test.hepatitis_c = chkHepatitisC.Checked;
                test.hiv = chkHIV.Checked;
                test.syphilis = chkSyphilis.Checked;

                // Eğer herhangi bir kutucuk işaretliyse test pozitiftir (Kötü)
                bool isInfected = chkHepatitisB.Checked || chkHepatitisC.Checked || chkHIV.Checked || chkSyphilis.Checked;

                test.test_result = isInfected ? "ENFEKTE" : "TEMİZ";
                db.lab_tests.Add(test);

                // 2. Bağışın Durumunu Güncelle ve Stoğa Al
                if (isInfected)
                {
                    donation.status = "İmhaEdildi";
                    donation.rejection_reason = "Laboratuvar test sonucu pozitif.";
                    MessageBox.Show("DİKKAT! Test sonucu POZİTİF. Kan imha edilmek üzere işaretlendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    donation.status = "Onaylandı";

                    // Bağışçının bilgilerini alalım (Kan grubu için)
                    var donor = db.donors.Find(donation.donor_id);

                    // Stok Tablosuna Ekle
                    blood_stocks stock = new blood_stocks();
                    stock.donation_id = donation.donation_id;
                    stock.product_type = cmbProductType.Text;
                    stock.blood_type = donor.blood_type;
                    stock.rh_factor = donor.rh_factor;
                    stock.expiration_date = dtpExpiration.Value;
                    stock.is_used = false;
                    stock.location_shelf = "RAF-A1"; // İleride dinamik yapılabilir
                    stock.entry_date = DateTime.Now;

                    db.blood_stocks.Add(stock);
                    MessageBox.Show("Test sonucu TEMİZ. Kan stoğa eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                db.SaveChanges();

                // Temizlik
                selectedDonationId = 0;
                txtSelectedBarcode.Clear();
                chkHepatitisB.Checked = false;
                chkHepatitisC.Checked = false;
                chkHIV.Checked = false;
                chkSyphilis.Checked = false;

                // Listeleri Yenile
                LoadPendingDonations();
                LoadStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}