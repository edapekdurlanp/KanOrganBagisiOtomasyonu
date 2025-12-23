namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmDonor
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
            this.tabList = new System.Windows.Forms.TabPage();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.chkOrganDonor = new System.Windows.Forms.CheckBox();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cmbRh = new System.Windows.Forms.ComboBox();
            this.lblRh = new System.Windows.Forms.Label();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.panelTop.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvDonors);
            this.tabList.Controls.Add(this.panelTop);
            this.tabList.Location = new System.Drawing.Point(4, 26);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(972, 620);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "Bağışçı Listesi";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // dgvDonors
            // 
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonors.Location = new System.Drawing.Point(3, 63);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.ReadOnly = true;
            this.dgvDonors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonors.Size = new System.Drawing.Size(966, 554);
            this.dgvDonors.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.btnDonate);
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(966, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnDonate
            // 
            this.btnDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(532, 14);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(110, 32);
            this.btnDonate.TabIndex = 5;
            this.btnDonate.Text = "Bağış Al";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(860, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(764, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(648, 14);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 32);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "+ Yeni Ekle";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(97, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(19, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara (TC):";
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.btnCancel);
            this.tabDetail.Controls.Add(this.btnSave);
            this.tabDetail.Controls.Add(this.grpContact);
            this.tabDetail.Controls.Add(this.grpPersonal);
            this.tabDetail.Location = new System.Drawing.Point(4, 26);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(972, 620);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Kayıt Detayı";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(219, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(83, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtAddress);
            this.grpContact.Controls.Add(this.lblAddress);
            this.grpContact.Controls.Add(this.cmbDistrict);
            this.grpContact.Controls.Add(this.lblDistrict);
            this.grpContact.Controls.Add(this.cmbCity);
            this.grpContact.Controls.Add(this.lblCity);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.txtPhone);
            this.grpContact.Controls.Add(this.lblPhone);
            this.grpContact.Location = new System.Drawing.Point(490, 30);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(400, 400);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "İletişim ve Adres Bilgileri";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 186);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 100);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 189);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Adres:";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(120, 149);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(250, 25);
            this.cmbDistrict.TabIndex = 7;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(20, 152);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(34, 17);
            this.lblDistrict.TabIndex = 6;
            this.lblDistrict.Text = "İlçe:";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(120, 112);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(250, 25);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 115);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(18, 17);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "İl:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Posta:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 38);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 41);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 17);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Telefon:";
            // 
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.chkOrganDonor);
            this.grpPersonal.Controls.Add(this.numWeight);
            this.grpPersonal.Controls.Add(this.lblWeight);
            this.grpPersonal.Controls.Add(this.cmbRh);
            this.grpPersonal.Controls.Add(this.lblRh);
            this.grpPersonal.Controls.Add(this.cmbBloodType);
            this.grpPersonal.Controls.Add(this.lblBloodType);
            this.grpPersonal.Controls.Add(this.cmbGender);
            this.grpPersonal.Controls.Add(this.lblGender);
            this.grpPersonal.Controls.Add(this.dtpBirthDate);
            this.grpPersonal.Controls.Add(this.lblBirthDate);
            this.grpPersonal.Controls.Add(this.txtNameSurname);
            this.grpPersonal.Controls.Add(this.lblNameSurname);
            this.grpPersonal.Controls.Add(this.txtTCKN);
            this.grpPersonal.Controls.Add(this.lblTCKN);
            this.grpPersonal.Location = new System.Drawing.Point(60, 30);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(400, 400);
            this.grpPersonal.TabIndex = 0;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Kişisel Bilgiler";
            // 
            // chkOrganDonor
            // 
            this.chkOrganDonor.AutoSize = true;
            this.chkOrganDonor.Location = new System.Drawing.Point(120, 305);
            this.chkOrganDonor.Name = "chkOrganDonor";
            this.chkOrganDonor.Size = new System.Drawing.Size(189, 21);
            this.chkOrganDonor.TabIndex = 14;
            this.chkOrganDonor.Text = "Organ Bağışçısı Olmak İstiyorum";
            this.chkOrganDonor.UseVisualStyleBackColor = true;
            // 
            // numWeight
            // 
            this.numWeight.DecimalPlaces = 2;
            this.numWeight.Location = new System.Drawing.Point(120, 260);
            this.numWeight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numWeight.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(250, 23);
            this.numWeight.TabIndex = 13;
            this.numWeight.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 262);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 17);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Kilo (kg):";
            // 
            // cmbRh
            // 
            this.cmbRh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRh.FormattingEnabled = true;
            this.cmbRh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbRh.Location = new System.Drawing.Point(120, 223);
            this.cmbRh.Name = "cmbRh";
            this.cmbRh.Size = new System.Drawing.Size(250, 25);
            this.cmbRh.TabIndex = 11;
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Location = new System.Drawing.Point(20, 226);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(65, 17);
            this.lblRh.TabIndex = 10;
            this.lblRh.Text = "Rh Faktör:";
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "0"});
            this.cmbBloodType.Location = new System.Drawing.Point(120, 186);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(250, 25);
            this.cmbBloodType.TabIndex = 9;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(20, 189);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(80, 17);
            this.lblBloodType.TabIndex = 8;
            this.lblBloodType.Text = "Kan Grubu:";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbGender.Location = new System.Drawing.Point(120, 149);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(250, 25);
            this.cmbGender.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 152);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Cinsiyet:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 112);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(250, 23);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(20, 115);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(94, 17);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Doğum Tarihi:";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(120, 75);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(250, 23);
            this.txtNameSurname.TabIndex = 3;
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(20, 78);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(73, 17);
            this.lblNameSurname.TabIndex = 2;
            this.lblNameSurname.Text = "Ad Soyad:";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(120, 38);
            this.txtTCKN.MaxLength = 11;
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(250, 23);
            this.txtTCKN.TabIndex = 1;
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(20, 41);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(43, 17);
            this.lblTCKN.TabIndex = 0;
            this.lblTCKN.Text = "TCKN:";
            // 
            // frmDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonor";
            this.Text = "frmDonor";
            this.Load += new System.EventHandler(this.frmDonor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabDetail.ResumeLayout(false);
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbRh;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.CheckBox chkOrganDonor;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDonate;
    }
}