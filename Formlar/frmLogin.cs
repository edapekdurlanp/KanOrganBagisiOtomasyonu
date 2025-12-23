using KanOrganBagisTakipOtomasyonu.Database;
using KanOrganBagisTakipOtomasyonu.Formlar;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmLogin : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();
        bool drag = false;
        Point start_point = new Point(0, 0);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.users.FirstOrDefault(x => x.username == username && x.password == password);

            if (user != null)
            {
                if (user.is_active == false)
                {
                    MessageBox.Show("Kullanıcınız pasif durumdadır. Yöneticinizle görüşün.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (user.is_locked == true)
                {
                    MessageBox.Show("Hesabınız kilitlenmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user_logs log = new user_logs();
                log.user_id = user.user_id;
                log.action_type = "login";
                log.description = "Sisteme giriş yapıldı.";
                log.log_date = DateTime.Now;
                log.ip_address = "127.0.0.1";
                db.user_logs.Add(log);

                user.failed_login_count = 0;
                user.last_login_date = DateTime.Now;
                db.SaveChanges();

                this.Hide();
                frmMain anaForm = new frmMain();
                anaForm.CurrentUserName = user.username;
                anaForm.Show();
            }
            else
            {
                var checkUser = db.users.FirstOrDefault(x => x.username == username);
                if (checkUser != null)
                {
                    checkUser.failed_login_count = (checkUser.failed_login_count ?? 0) + 1;

                    if (checkUser.failed_login_count >= 3)
                    {
                        checkUser.is_locked = true;
                        MessageBox.Show("3 kez hatalı giriş yaptığınız için hesabınız kilitlendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.SaveChanges();
                }

                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}