using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmSettings : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        public string ActiveUserName { get; set; }
        int selectedUserId = 0;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            CheckPermission();
            LoadDepartments();
            LoadRoles();
            LoadUsers();
        }

        private void CheckPermission()
        {
            // Giriş yapan kullanıcıyı bul
            var user = db.users.FirstOrDefault(x => x.username == ActiveUserName);
            if (user != null)
            {
                var role = db.roles.Find(user.role_id);
                // Eğer admin değilse ilk sekmeyi (Kullanıcı Yönetimi) gizle veya kaldır
                if (role != null && role.role_name != "admin" && role.role_name != "Admin")
                {
                    tabControl1.TabPages.Remove(tabUsers);
                }
            }
        }

        private void LoadDepartments()
        {
            cmbDepartment.DataSource = db.departments.ToList();
            cmbDepartment.DisplayMember = "department_name";
            cmbDepartment.ValueMember = "department_id";
        }

        private void LoadRoles()
        {
            cmbRole.DataSource = db.roles.ToList();
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "role_id";
        }

        private void LoadUsers()
        {
            var list = (from u in db.users
                        join r in db.roles on u.role_id equals r.role_id
                        join d in db.departments on u.department_id equals d.department_id
                        select new
                        {
                            ID = u.user_id,
                            AdSoyad = u.name_surname,
                            KullanıcıAdı = u.username,
                            Rol = r.role_name,
                            Birim = d.department_name,
                            Durum = u.is_active == true ? "Aktif" : "Pasif"
                        }).ToList();

            dgvUsers.DataSource = list;
            if (dgvUsers.Columns.Count > 0) dgvUsers.Columns[0].Visible = false;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre zorunludur.");
                return;
            }

            try
            {
                user u;
                if (selectedUserId == 0)
                {
                    // Yeni Ekleme
                    // Önce aynı kullanıcı adı var mı kontrol et
                    var check = db.users.FirstOrDefault(x => x.username == txtUsername.Text);
                    if (check != null)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.");
                        return;
                    }

                    u = new user();
                    db.users.Add(u);
                }
                else
                {
                    // Güncelleme
                    u = db.users.Find(selectedUserId);
                }

                u.name_surname = txtNameSurname.Text;
                u.username = txtUsername.Text;
                u.password = txtPassword.Text; // Normalde hashlenmeli ama isterlerde düz metin.
                u.role_id = (int)cmbRole.SelectedValue;
                u.department_id = (int)cmbDepartment.SelectedValue;
                u.is_active = chkActive.Checked;

                db.SaveChanges();
                MessageBox.Show("Kullanıcı işlemi başarılı.");

                // Formu Temizle
                selectedUserId = 0;
                txtUsername.Clear();
                txtPassword.Clear();
                txtNameSurname.Clear();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
                var u = db.users.Find(selectedUserId);
                if (u != null)
                {
                    txtNameSurname.Text = u.name_surname;
                    txtUsername.Text = u.username;
                    txtPassword.Text = u.password;
                    cmbRole.SelectedValue = u.role_id;
                    cmbDepartment.SelectedValue = u.department_id;
                    chkActive.Checked = u.is_active ?? false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) return;

            if (MessageBox.Show("Kullanıcıyı sistemden silmek yerine PASİF yapmanız önerilir. Yine de silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var u = db.users.Find(selectedUserId);
                db.users.Remove(u);
                db.SaveChanges();
                LoadUsers();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            var user = db.users.FirstOrDefault(x => x.username == ActiveUserName);
            if (user != null)
            {
                if (user.password != txtOldPass.Text)
                {
                    MessageBox.Show("Eski şifreniz hatalı.");
                    return;
                }

                if (txtNewPass.Text != txtNewPass2.Text)
                {
                    MessageBox.Show("Yeni şifreler uyuşmuyor.");
                    return;
                }

                user.password = txtNewPass.Text;
                db.SaveChanges();
                MessageBox.Show("Şifreniz başarıyla güncellendi.");

                txtOldPass.Clear();
                txtNewPass.Clear();
                txtNewPass2.Clear();
            }
        }
    }
}