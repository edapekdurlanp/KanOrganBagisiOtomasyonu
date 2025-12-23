namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabMyAccount = new System.Windows.Forms.TabPage();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.lblNewPass2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.tabMyAccount.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabMyAccount);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.panelAdmin);
            this.tabUsers.Location = new System.Drawing.Point(4, 26);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(972, 620);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Kullanıcı Yönetimi (Admin)";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 143);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(966, 474);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAdmin.Controls.Add(this.chkActive);
            this.panelAdmin.Controls.Add(this.cmbDepartment);
            this.panelAdmin.Controls.Add(this.lblDept);
            this.panelAdmin.Controls.Add(this.btnDelete);
            this.panelAdmin.Controls.Add(this.btnSaveUser);
            this.panelAdmin.Controls.Add(this.cmbRole);
            this.panelAdmin.Controls.Add(this.lblRole);
            this.panelAdmin.Controls.Add(this.txtPassword);
            this.panelAdmin.Controls.Add(this.lblPass);
            this.panelAdmin.Controls.Add(this.txtUsername);
            this.panelAdmin.Controls.Add(this.lblUser);
            this.panelAdmin.Controls.Add(this.txtNameSurname);
            this.panelAdmin.Controls.Add(this.lblName);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(3, 3);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(966, 140);
            this.panelAdmin.TabIndex = 0;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(700, 20);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(107, 21);
            this.chkActive.TabIndex = 12;
            this.chkActive.Text = "Aktif Kullanıcı";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(460, 55);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(200, 25);
            this.cmbDepartment.TabIndex = 11;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(380, 58);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(83, 17);
            this.lblDept.TabIndex = 10;
            this.lblDept.Text = "Departman:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(840, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil / Pasif";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(700, 55);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(120, 30);
            this.btnSaveUser.TabIndex = 8;
            this.btnSaveUser.Text = "Kaydet";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(460, 18);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 25);
            this.cmbRole.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(380, 21);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 17);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Rol:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(20, 95);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(37, 17);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Şifre:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 58);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(90, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Kullanıcı Adı:";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(120, 18);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(200, 23);
            this.txtNameSurname.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ad Soyad:";
            // 
            // tabMyAccount
            // 
            this.tabMyAccount.Controls.Add(this.grpPassword);
            this.tabMyAccount.Location = new System.Drawing.Point(4, 26);
            this.tabMyAccount.Name = "tabMyAccount";
            this.tabMyAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyAccount.Size = new System.Drawing.Size(972, 620);
            this.tabMyAccount.TabIndex = 1;
            this.tabMyAccount.Text = "Hesabım";
            this.tabMyAccount.UseVisualStyleBackColor = true;
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.btnChangePass);
            this.grpPassword.Controls.Add(this.txtNewPass2);
            this.grpPassword.Controls.Add(this.lblNewPass2);
            this.grpPassword.Controls.Add(this.txtNewPass);
            this.grpPassword.Controls.Add(this.lblNewPass);
            this.grpPassword.Controls.Add(this.txtOldPass);
            this.grpPassword.Controls.Add(this.lblOldPass);
            this.grpPassword.Location = new System.Drawing.Point(30, 30);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(400, 300);
            this.grpPassword.TabIndex = 0;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Şifre Değiştir";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Goldenrod;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(150, 180);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(200, 40);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Şifreyi Güncelle";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(150, 130);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.PasswordChar = '*';
            this.txtNewPass2.Size = new System.Drawing.Size(200, 23);
            this.txtNewPass2.TabIndex = 5;
            // 
            // lblNewPass2
            // 
            this.lblNewPass2.AutoSize = true;
            this.lblNewPass2.Location = new System.Drawing.Point(30, 133);
            this.lblNewPass2.Name = "lblNewPass2";
            this.lblNewPass2.Size = new System.Drawing.Size(89, 17);
            this.lblNewPass2.TabIndex = 4;
            this.lblNewPass2.Text = "Tekrar Yeni:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(150, 90);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(200, 23);
            this.txtNewPass.TabIndex = 3;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(30, 93);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(71, 17);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Yeni Şifre:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(150, 50);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(200, 23);
            this.txtOldPass.TabIndex = 1;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(30, 53);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(67, 17);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Eski Şifre:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.tabMyAccount.ResumeLayout(false);
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabMyAccount;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Label lblNewPass2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.CheckBox chkActive;
    }
}