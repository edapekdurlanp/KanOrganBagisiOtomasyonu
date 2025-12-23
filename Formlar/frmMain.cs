using KanOrganBagisTakipOtomasyonu.Formlar;
using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmMain : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public string CurrentUserName { get; set; }
        public string CurrentUserRole { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }

            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Bağışçı İşlemleri";
            OpenChildForm(new frmDonor());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Hasta ve Talep İşlemleri";
            OpenChildForm(new KanOrganBagisTakipOtomasyonu.Formlar.frmPatient());
        }

        private void btnBloodStock_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Kan Stok ve Laboratuvar";
            OpenChildForm(new KanOrganBagisTakipOtomasyonu.Formlar.frmBloodStock());
        }

        private void btnOrgan_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Organ Bağış ve Eşleşme";
            OpenChildForm(new KanOrganBagisTakipOtomasyonu.Formlar.frmOrgan());
        }

        private void btnTransfers_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Transfer İşlemleri";
            OpenChildForm(new KanOrganBagisTakipOtomasyonu.Formlar.frmTransfers());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Raporlar ve İstatistikler";
            OpenChildForm(new KanOrganBagisTakipOtomasyonu.Formlar.frmReports());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Kullanıcı Yönetimi ve Ayarlar";

            KanOrganBagisTakipOtomasyonu.Formlar.frmSettings settingsForm = new KanOrganBagisTakipOtomasyonu.Formlar.frmSettings();
            settingsForm.ActiveUserName = this.CurrentUserName;

            OpenChildForm(settingsForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
}