using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmOrgan : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        int selectedOrganId = 0;

        public frmOrgan()
        {
            InitializeComponent();
        }

        private void frmOrgan_Load(object sender, EventArgs e)
        {
            LoadDonors();
            LoadOrganDonations();
            LoadRequests();
            LoadMatchSource();
        }

        private void LoadDonors()
        {
            // Sadece Organ Bağışçısı Olanları Getir
            var list = db.donors.Where(x => x.is_organ_donor == true)
                                .Select(x => new { x.donor_id, FullName = x.name_surname + " (" + x.blood_type + x.rh_factor + ")" })
                                .ToList();

            cmbDonor.DataSource = list;
            cmbDonor.DisplayMember = "FullName";
            cmbDonor.ValueMember = "donor_id";
        }

        private void LoadOrganDonations()
        {
            var list = (from od in db.organ_donations
                        join d in db.donors on od.donor_id equals d.donor_id
                        where od.status == "Bekliyor"
                        select new
                        {
                            ID = od.organ_id,
                            Bağışçı = d.name_surname,
                            Kan = d.blood_type + d.rh_factor,
                            Organ = od.organ_name,
                            Tarih = od.donation_date
                        }).ToList();

            dgvOrganDonations.DataSource = list;
            dgvOrganDonations.Columns[0].Visible = false;
        }

        private void LoadRequests()
        {
            // Talep tipi 'Organ' olanları getir
            var list = (from r in db.requests
                        join p in db.patients on r.patient_id equals p.patient_id
                        join h in db.hospitals on p.hospital_id equals h.hospital_id
                        where r.request_type == "Organ" && r.status == "Bekliyor"
                        select new
                        {
                            ID = r.request_id,
                            Hasta = p.name_surname,
                            Kan = p.blood_type + p.rh_factor,
                            İstenen = r.required_product,
                            Hastane = h.hospital_name,
                            Aciliyet = p.urgency_status
                        }).ToList();

            dgvRequests.DataSource = list;
            dgvRequests.Columns[0].Visible = false;
        }

        private void LoadMatchSource()
        {
            // Eşleşme sekmesindeki sol tablo (Organ Havuzu)
            var list = (from od in db.organ_donations
                        join d in db.donors on od.donor_id equals d.donor_id
                        where od.status == "Bekliyor"
                        select new
                        {
                            ID = od.organ_id,
                            Organ = od.organ_name,
                            Kan = d.blood_type,
                            Rh = d.rh_factor
                        }).ToList();

            dgvMatchSource.DataSource = list;
            dgvMatchSource.Columns[0].Visible = false;
        }

        private void btnAddOrgan_Click(object sender, EventArgs e)
        {
            if (cmbDonor.SelectedIndex == -1 || cmbOrganType.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bağışçı ve organ seçiniz.");
                return;
            }

            organ_donations od = new organ_donations();
            od.donor_id = (int)cmbDonor.SelectedValue;
            od.organ_name = cmbOrganType.Text;
            od.donation_date = DateTime.Now;
            od.status = "Bekliyor";
            od.is_matched = false;

            db.organ_donations.Add(od);
            db.SaveChanges();

            MessageBox.Show("Organ bağışı havuza eklendi.");
            LoadOrganDonations();
            LoadMatchSource();
        }

        private void dgvMatchSource_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedOrganId = Convert.ToInt32(dgvMatchSource.Rows[e.RowIndex].Cells[0].Value);
                string organName = dgvMatchSource.Rows[e.RowIndex].Cells[1].Value.ToString();
                string bloodType = dgvMatchSource.Rows[e.RowIndex].Cells[2].Value.ToString();
                string rh = dgvMatchSource.Rows[e.RowIndex].Cells[3].Value.ToString();

                FindMatches(organName, bloodType, rh);
            }
        }

        private void FindMatches(string organ, string donorBlood, string donorRh)
        {
            // ALGORİTMA:
            // 1. Organ ismi aynı olmalı.
            // 2. Rh faktörü aynı olmalı (+ ise +, - ise -).
            // 3. Kan grubu uyumu (0 genel verici, AB genel alıcı vb.)

            // Uyumlu kan gruplarını belirle
            string[] compatibleTypes;

            if (donorBlood == "0") compatibleTypes = new string[] { "0", "A", "B", "AB" };
            else if (donorBlood == "A") compatibleTypes = new string[] { "A", "AB" };
            else if (donorBlood == "B") compatibleTypes = new string[] { "B", "AB" };
            else compatibleTypes = new string[] { "AB" }; // AB sadece AB'ye

            // Veritabanında arama yap
            var matches = (from r in db.requests
                           join p in db.patients on r.patient_id equals p.patient_id
                           join h in db.hospitals on p.hospital_id equals h.hospital_id
                           where r.request_type == "Organ"
                                 && r.status == "Bekliyor"
                                 && r.required_product == organ // Organ ismi tutmalı
                                 && p.rh_factor == donorRh // Rh tutmalı
                                 && compatibleTypes.Contains(p.blood_type) // Kan grubu uyumu
                           orderby p.urgency_status descending // Önce 'Kritik' olanlar gelsin
                           select new
                           {
                               TalepID = r.request_id,
                               Hasta = p.name_surname,
                               Kan = p.blood_type + p.rh_factor,
                               Aciliyet = p.urgency_status,
                               Hastane = h.hospital_name
                           }).ToList();

            dgvMatches.DataSource = matches;

            if (matches.Count > 0)
                lblMatchInfo.Text = matches.Count + " adet uygun hasta bulundu! (Aciliyet sırasına göre)";
            else
                lblMatchInfo.Text = "Uygun eşleşme bulunamadı.";
        }

        private void btnConfirmMatch_Click(object sender, EventArgs e)
        {
            if (selectedOrganId == 0 || dgvMatches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen soldan bir organ ve sağdan bir hasta seçiniz.");
                return;
            }

            int requestId = Convert.ToInt32(dgvMatches.SelectedRows[0].Cells[0].Value);

            try
            {
                // 1. Organı güncelle
                var organ = db.organ_donations.Find(selectedOrganId);
                organ.status = "Transferde";
                organ.is_matched = true;

                // 2. Talebi güncelle
                var request = db.requests.Find(requestId);
                request.status = "Karşılandı";

                // 3. Transfer Kaydı Oluştur
                transfer t = new transfer();
                t.request_id = requestId;
                t.organ_id = selectedOrganId;
                t.status = "Hazırlanıyor";
                t.departure_time = DateTime.Now;

                db.transfers.Add(t);
                db.SaveChanges();

                MessageBox.Show("Eşleşme onaylandı! Transfer süreci başlatıldı.");

                // Listeleri Yenile
                LoadOrganDonations();
                LoadRequests();
                LoadMatchSource();
                dgvMatches.DataSource = null;
                selectedOrganId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}