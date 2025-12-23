using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmDonor : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        int selectedDonorId = 0;

        public frmDonor()
        {
            InitializeComponent();
        }

        private void frmDonor_Load(object sender, EventArgs e)
        {
            LoadDonors();
            LoadCities();
        }

        private void LoadDonors()
        {
            var list = (from d in db.donors
                        join c in db.cities on d.city_id equals c.city_id into cityJoin
                        from c in cityJoin.DefaultIfEmpty()
                        select new
                        {
                            Id = d.donor_id,
                            TCKN = d.tckn,
                            AdSoyad = d.name_surname,
                            KanGrubu = d.blood_type + " " + d.rh_factor,
                            Sehir = c != null ? c.city_name : "",
                            Telefon = d.phone,
                            SonBagis = d.last_donation_date,
                            OrganBagiscisi = d.is_organ_donor
                        }).ToList();

            dgvDonors.DataSource = list;
            dgvDonors.Columns[0].Visible = false;
        }

        private void LoadCities()
        {
            cmbCity.DataSource = db.cities.ToList();
            cmbCity.DisplayMember = "city_name";
            cmbCity.ValueMember = "city_id";
            cmbCity.SelectedIndex = -1;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedValue != null)
            {
                int cityId;
                if (int.TryParse(cmbCity.SelectedValue.ToString(), out cityId))
                {
                    var districts = db.districts.Where(x => x.city_id == cityId).ToList();
                    cmbDistrict.DataSource = districts;
                    cmbDistrict.DisplayMember = "district_name";
                    cmbDistrict.ValueMember = "district_id";
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedDonorId = 0;
            ClearForm();
            tabControl1.SelectedTab = tabDetail;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            if (dgvDonors.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDonors.SelectedRows[0].Cells[0].Value);

                frmDonationPopup popup = new frmDonationPopup();
                popup.DonorId = id;
                popup.ShowDialog();

                LoadDonors();
            }
            else
            {
                MessageBox.Show("Lütfen bağış alacağınız kişiyi listeden seçiniz.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDonors.SelectedRows.Count > 0)
            {
                selectedDonorId = Convert.ToInt32(dgvDonors.SelectedRows[0].Cells[0].Value);
                var donor = db.donors.Find(selectedDonorId);

                if (donor != null)
                {
                    txtTCKN.Text = donor.tckn;
                    txtNameSurname.Text = donor.name_surname;
                    dtpBirthDate.Value = donor.birth_date ?? DateTime.Now;
                    cmbGender.SelectedItem = donor.gender;
                    cmbBloodType.SelectedItem = donor.blood_type;
                    cmbRh.SelectedItem = donor.rh_factor;
                    numWeight.Value = donor.weight ?? 0;
                    chkOrganDonor.Checked = donor.is_organ_donor ?? false;
                    txtPhone.Text = donor.phone;
                    txtEmail.Text = donor.email;
                    txtAddress.Text = donor.address_detail;

                    if (donor.city_id != null)
                        cmbCity.SelectedValue = donor.city_id;

                    if (donor.district_id != null)
                        cmbDistrict.SelectedValue = donor.district_id;

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
                donor d;
                if (selectedDonorId == 0)
                {
                    d = new donor();
                    db.donors.Add(d);
                }
                else
                {
                    d = db.donors.Find(selectedDonorId);
                }

                d.tckn = txtTCKN.Text;
                d.name_surname = txtNameSurname.Text;
                d.birth_date = dtpBirthDate.Value;
                d.gender = cmbGender.Text;
                d.blood_type = cmbBloodType.Text;
                d.rh_factor = cmbRh.Text;
                d.weight = numWeight.Value;
                d.is_organ_donor = chkOrganDonor.Checked;
                d.phone = txtPhone.Text;
                d.email = txtEmail.Text;
                d.address_detail = txtAddress.Text;

                if (cmbCity.SelectedValue != null)
                    d.city_id = (int)cmbCity.SelectedValue;

                if (cmbDistrict.SelectedValue != null)
                    d.district_id = (int)cmbDistrict.SelectedValue;

                db.SaveChanges();
                MessageBox.Show("İşlem başarılı.");
                LoadDonors();
                tabControl1.SelectedTab = tabList;
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
            if (dgvDonors.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvDonors.SelectedRows[0].Cells[0].Value);
                    var d = db.donors.Find(id);
                    db.donors.Remove(d);
                    db.SaveChanges();
                    LoadDonors();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.ToLower();
            var list = (from d in db.donors
                        where d.tckn.Contains(s) || d.name_surname.Contains(s)
                        select new
                        {
                            Id = d.donor_id,
                            TCKN = d.tckn,
                            AdSoyad = d.name_surname,
                            KanGrubu = d.blood_type + " " + d.rh_factor
                        }).ToList();
            dgvDonors.DataSource = list;
        }

        private void ClearForm()
        {
            txtTCKN.Clear();
            txtNameSurname.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbCity.SelectedIndex = -1;
            cmbDistrict.DataSource = null;
            cmbBloodType.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            chkOrganDonor.Checked = false;
        }
    }
}