namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmPatient
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.lblRequestInfo = new System.Windows.Forms.Label();
            this.btnCreateRequest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpMedical = new System.Windows.Forms.GroupBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.cmbUrgency = new System.Windows.Forms.ComboBox();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.cmbRh = new System.Windows.Forms.ComboBox();
            this.lblRh = new System.Windows.Forms.Label();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panelTop.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.grpRequest.SuspendLayout();
            this.grpMedical.SuspendLayout();
            this.grpPersonal.SuspendLayout();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvPatients);
            this.tabList.Controls.Add(this.panelTop);
            this.tabList.Location = new System.Drawing.Point(4, 26);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(972, 620);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "Hasta Listesi";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(3, 63);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(966, 554);
            this.dgvPatients.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tabDetail.Controls.Add(this.grpRequest);
            this.tabDetail.Controls.Add(this.btnCancel);
            this.tabDetail.Controls.Add(this.btnSave);
            this.tabDetail.Controls.Add(this.grpMedical);
            this.tabDetail.Controls.Add(this.grpPersonal);
            this.tabDetail.Location = new System.Drawing.Point(4, 26);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(972, 620);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Hasta Kartı";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.lblRequestInfo);
            this.grpRequest.Controls.Add(this.btnCreateRequest);
            this.grpRequest.Location = new System.Drawing.Point(60, 350);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(830, 80);
            this.grpRequest.TabIndex = 4;
            this.grpRequest.TabStop = false;
            this.grpRequest.Text = "Talep İşlemleri";
            // 
            // lblRequestInfo
            // 
            this.lblRequestInfo.AutoSize = true;
            this.lblRequestInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblRequestInfo.Location = new System.Drawing.Point(20, 35);
            this.lblRequestInfo.Name = "lblRequestInfo";
            this.lblRequestInfo.Size = new System.Drawing.Size(431, 17);
            this.lblRequestInfo.TabIndex = 1;
            this.lblRequestInfo.Text = "Bu hastaya Kan veya Organ talebi oluşturmak için butona tıklayınız.";
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRequest.ForeColor = System.Drawing.Color.White;
            this.btnCreateRequest.Location = new System.Drawing.Point(650, 25);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(160, 35);
            this.btnCreateRequest.TabIndex = 0;
            this.btnCreateRequest.Text = "Talep Oluştur";
            this.btnCreateRequest.UseVisualStyleBackColor = false;
            this.btnCreateRequest.Click += new System.EventHandler(this.btnCreateRequest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(196, 450);
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
            this.btnSave.Location = new System.Drawing.Point(60, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpMedical
            // 
            this.grpMedical.Controls.Add(this.txtDiagnosis);
            this.grpMedical.Controls.Add(this.lblDiagnosis);
            this.grpMedical.Controls.Add(this.cmbUrgency);
            this.grpMedical.Controls.Add(this.lblUrgency);
            this.grpMedical.Controls.Add(this.cmbHospital);
            this.grpMedical.Controls.Add(this.lblHospital);
            this.grpMedical.Controls.Add(this.cmbRh);
            this.grpMedical.Controls.Add(this.lblRh);
            this.grpMedical.Controls.Add(this.cmbBloodType);
            this.grpMedical.Controls.Add(this.lblBloodType);
            this.grpMedical.Location = new System.Drawing.Point(490, 30);
            this.grpMedical.Name = "grpMedical";
            this.grpMedical.Size = new System.Drawing.Size(400, 300);
            this.grpMedical.TabIndex = 1;
            this.grpMedical.TabStop = false;
            this.grpMedical.Text = "Tıbbi Durum";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(120, 186);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(250, 100);
            this.txtDiagnosis.TabIndex = 9;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Location = new System.Drawing.Point(20, 189);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(50, 17);
            this.lblDiagnosis.TabIndex = 8;
            this.lblDiagnosis.Text = "Teşhis:";
            // 
            // cmbUrgency
            // 
            this.cmbUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrgency.FormattingEnabled = true;
            this.cmbUrgency.Items.AddRange(new object[] {
            "Normal",
            "Acil",
            "Kritik"});
            this.cmbUrgency.Location = new System.Drawing.Point(120, 149);
            this.cmbUrgency.Name = "cmbUrgency";
            this.cmbUrgency.Size = new System.Drawing.Size(250, 25);
            this.cmbUrgency.TabIndex = 7;
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Location = new System.Drawing.Point(20, 152);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(63, 17);
            this.lblUrgency.TabIndex = 6;
            this.lblUrgency.Text = "Aciliyet:";
            // 
            // cmbHospital
            // 
            this.cmbHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(120, 112);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(250, 25);
            this.cmbHospital.TabIndex = 5;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Location = new System.Drawing.Point(20, 115);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(64, 17);
            this.lblHospital.TabIndex = 4;
            this.lblHospital.Text = "Hastane:";
            // 
            // cmbRh
            // 
            this.cmbRh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRh.FormattingEnabled = true;
            this.cmbRh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbRh.Location = new System.Drawing.Point(120, 75);
            this.cmbRh.Name = "cmbRh";
            this.cmbRh.Size = new System.Drawing.Size(250, 25);
            this.cmbRh.TabIndex = 3;
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Location = new System.Drawing.Point(20, 78);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(65, 17);
            this.lblRh.TabIndex = 2;
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
            this.cmbBloodType.Location = new System.Drawing.Point(120, 38);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(250, 25);
            this.cmbBloodType.TabIndex = 1;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(20, 41);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(80, 17);
            this.lblBloodType.TabIndex = 0;
            this.lblBloodType.Text = "Kan Grubu:";
            // 
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.dtpBirthDate);
            this.grpPersonal.Controls.Add(this.lblBirthDate);
            this.grpPersonal.Controls.Add(this.txtNameSurname);
            this.grpPersonal.Controls.Add(this.lblNameSurname);
            this.grpPersonal.Controls.Add(this.txtTCKN);
            this.grpPersonal.Controls.Add(this.lblTCKN);
            this.grpPersonal.Location = new System.Drawing.Point(60, 30);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(400, 300);
            this.grpPersonal.TabIndex = 0;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Kimlik Bilgileri";
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
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatient";
            this.Text = "frmPatient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabDetail.ResumeLayout(false);
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.grpMedical.ResumeLayout(false);
            this.grpMedical.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.GroupBox grpMedical;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbRh;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label lblUrgency;
        private System.Windows.Forms.ComboBox cmbUrgency;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.Label lblRequestInfo;
        private System.Windows.Forms.Button btnCreateRequest;
    }
}