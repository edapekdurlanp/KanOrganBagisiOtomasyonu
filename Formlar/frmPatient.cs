using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmPatient : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        int selectedPatientId = 0;

        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadHospitals();
            btnCreateRequest.Enabled = false;
        }

        private void LoadPatients()
        {
            var list = (from p in db.patients
                        join h in db.hospitals on p.hospital_id equals h.hospital_id into hJoin
                        from h in hJoin.DefaultIfEmpty()
                        select new
                        {
                            Id = p.patient_id,
                            TCKN = p.tckn,
                            AdSoyad = p.name_surname,
                            Kan = p.blood_type + " " + p.rh_factor,
                            Hastane = h != null ? h.hospital_name : "",
                            Aciliyet = p.urgency_status,
                            Tarih = p.registration_date
                        }).ToList();

            dgvPatients.DataSource = list;
            dgvPatients.Columns[0].Visible = false;
        }

        private void LoadHospitals()
        {
            cmbHospital.DataSource = db.hospitals.ToList();
            cmbHospital.DisplayMember = "hospital_name";
            cmbHospital.ValueMember = "hospital_id";
            cmbHospital.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedPatientId = 0;
            ClearForm();
            btnCreateRequest.Enabled = false;
            tabControl1.SelectedTab = tabDetail;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                selectedPatientId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);
                var p = db.patients.Find(selectedPatientId);

                if (p != null)
                {
                    txtTCKN.Text = p.tckn;
                    txtNameSurname.Text = p.name_surname;
                    dtpBirthDate.Value = p.birth_date ?? DateTime.Now;
                    cmbBloodType.SelectedItem = p.blood_type;
                    cmbRh.SelectedItem = p.rh_factor;
                    txtDiagnosis.Text = p.diagnosis;
                    cmbUrgency.SelectedItem = p.urgency_status;

                    if (p.hospital_id != null)
                        cmbHospital.SelectedValue = p.hospital_id;

                    btnCreateRequest.Enabled = true;
                    tabControl1.SelectedTab = tabDetail;
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlenecek kaydı seçiniz.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTCKN.Text) || string.IsNullOrEmpty(txtNameSurname.Text))
            {
                MessageBox.Show("TCKN ve Ad Soyad zorunludur.");
                return;
            }

            try
            {
                patient p;
                if (selectedPatientId == 0)
                {
                    p = new patient();
                    db.patients.Add(p);
                }
                else
                {
                    p = db.patients.Find(selectedPatientId);
                }

                p.tckn = txtTCKN.Text;
                p.name_surname = txtNameSurname.Text;
                p.birth_date = dtpBirthDate.Value;
                p.blood_type = cmbBloodType.Text;
                p.rh_factor = cmbRh.Text;
                p.diagnosis = txtDiagnosis.Text;
                p.urgency_status = cmbUrgency.Text;

                if (cmbHospital.SelectedValue != null)
                    p.hospital_id = (int)cmbHospital.SelectedValue;

                db.SaveChanges();
                MessageBox.Show("İşlem başarılı.");

                selectedPatientId = p.patient_id;
                btnCreateRequest.Enabled = true;

                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);
                    var p = db.patients.Find(id);
                    db.patients.Remove(p);
                    db.SaveChanges();
                    LoadPatients();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.ToLower();
            var list = (from p in db.patients
                        join h in db.hospitals on p.hospital_id equals h.hospital_id into hJoin
                        from h in hJoin.DefaultIfEmpty()
                        where p.tckn.Contains(s) || p.name_surname.Contains(s)
                        select new
                        {
                            Id = p.patient_id,
                            TCKN = p.tckn,
                            AdSoyad = p.name_surname,
                            Kan = p.blood_type + " " + p.rh_factor,
                            Hastane = h != null ? h.hospital_name : ""
                        }).ToList();
            dgvPatients.DataSource = list;
        }

        private void ClearForm()
        {
            txtTCKN.Clear();
            txtNameSurname.Clear();
            cmbBloodType.SelectedIndex = -1;
            cmbRh.SelectedIndex = -1;
            cmbHospital.SelectedIndex = -1;
            cmbUrgency.SelectedIndex = -1;
            txtDiagnosis.Clear();
        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == 0) return;

            DialogResult res = MessageBox.Show("Bu hasta için ORGAN talebi mi oluşturulsun? (Hayır derseniz KAN talebi oluşur)", "Talep Tipi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel) return;

            request req = new request();
            req.patient_id = selectedPatientId;
            req.request_date = DateTime.Now;
            req.status = "Bekliyor";

            if (res == DialogResult.Yes)
            {
                req.request_type = "Organ";
                req.required_product = "Böbrek"; // Test için varsayılan
                MessageBox.Show("Otomatik olarak 'Böbrek' talebi oluşturuldu. (Detaylı seçim eklenebilir)");
            }
            else
            {
                req.request_type = "Kan";
                // Hastanın kan grubunu al
                var p = db.patients.Find(selectedPatientId);
                req.required_product = "Tam Kan";
                req.amount = 1;
            }

            db.requests.Add(req);
            db.SaveChanges();
            MessageBox.Show("Talep başarıyla oluşturuldu.");
        }
    }
}