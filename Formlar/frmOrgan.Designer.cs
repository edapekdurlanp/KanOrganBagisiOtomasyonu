namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmOrgan
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
            this.tabDonations = new System.Windows.Forms.TabPage();
            this.dgvOrganDonations = new System.Windows.Forms.DataGridView();
            this.panelTopDonation = new System.Windows.Forms.Panel();
            this.btnAddOrgan = new System.Windows.Forms.Button();
            this.cmbOrganType = new System.Windows.Forms.ComboBox();
            this.lblOrgan = new System.Windows.Forms.Label();
            this.cmbDonor = new System.Windows.Forms.ComboBox();
            this.lblDonor = new System.Windows.Forms.Label();
            this.tabRequests = new System.Windows.Forms.TabPage();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panelTopRequest = new System.Windows.Forms.Panel();
            this.lblRequestInfo = new System.Windows.Forms.Label();
            this.tabMatching = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpAvailable = new System.Windows.Forms.GroupBox();
            this.dgvMatchSource = new System.Windows.Forms.DataGridView();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.panelMatchAction = new System.Windows.Forms.Panel();
            this.btnConfirmMatch = new System.Windows.Forms.Button();
            this.lblMatchInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDonations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganDonations)).BeginInit();
            this.panelTopDonation.SuspendLayout();
            this.tabRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.panelTopRequest.SuspendLayout();
            this.tabMatching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchSource)).BeginInit();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.panelMatchAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDonations);
            this.tabControl1.Controls.Add(this.tabRequests);
            this.tabControl1.Controls.Add(this.tabMatching);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDonations
            // 
            this.tabDonations.Controls.Add(this.dgvOrganDonations);
            this.tabDonations.Controls.Add(this.panelTopDonation);
            this.tabDonations.Location = new System.Drawing.Point(4, 26);
            this.tabDonations.Name = "tabDonations";
            this.tabDonations.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonations.Size = new System.Drawing.Size(972, 620);
            this.tabDonations.TabIndex = 0;
            this.tabDonations.Text = "Organ Bağış Havuzu";
            this.tabDonations.UseVisualStyleBackColor = true;
            // 
            // dgvOrganDonations
            // 
            this.dgvOrganDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganDonations.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrganDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrganDonations.Location = new System.Drawing.Point(3, 83);
            this.dgvOrganDonations.Name = "dgvOrganDonations";
            this.dgvOrganDonations.ReadOnly = true;
            this.dgvOrganDonations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganDonations.Size = new System.Drawing.Size(966, 534);
            this.dgvOrganDonations.TabIndex = 1;
            // 
            // panelTopDonation
            // 
            this.panelTopDonation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTopDonation.Controls.Add(this.btnAddOrgan);
            this.panelTopDonation.Controls.Add(this.cmbOrganType);
            this.panelTopDonation.Controls.Add(this.lblOrgan);
            this.panelTopDonation.Controls.Add(this.cmbDonor);
            this.panelTopDonation.Controls.Add(this.lblDonor);
            this.panelTopDonation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopDonation.Location = new System.Drawing.Point(3, 3);
            this.panelTopDonation.Name = "panelTopDonation";
            this.panelTopDonation.Size = new System.Drawing.Size(966, 80);
            this.panelTopDonation.TabIndex = 0;
            // 
            // btnAddOrgan
            // 
            this.btnAddOrgan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddOrgan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrgan.ForeColor = System.Drawing.Color.White;
            this.btnAddOrgan.Location = new System.Drawing.Point(630, 24);
            this.btnAddOrgan.Name = "btnAddOrgan";
            this.btnAddOrgan.Size = new System.Drawing.Size(120, 30);
            this.btnAddOrgan.TabIndex = 4;
            this.btnAddOrgan.Text = "Bağış Ekle";
            this.btnAddOrgan.UseVisualStyleBackColor = false;
            this.btnAddOrgan.Click += new System.EventHandler(this.btnAddOrgan_Click);
            // 
            // cmbOrganType
            // 
            this.cmbOrganType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganType.FormattingEnabled = true;
            this.cmbOrganType.Items.AddRange(new object[] {
            "Böbrek",
            "Karaciğer",
            "Kalp",
            "Kornea",
            "Akciğer",
            "İlik"});
            this.cmbOrganType.Location = new System.Drawing.Point(420, 27);
            this.cmbOrganType.Name = "cmbOrganType";
            this.cmbOrganType.Size = new System.Drawing.Size(180, 25);
            this.cmbOrganType.TabIndex = 3;
            // 
            // lblOrgan
            // 
            this.lblOrgan.AutoSize = true;
            this.lblOrgan.Location = new System.Drawing.Point(360, 31);
            this.lblOrgan.Name = "lblOrgan";
            this.lblOrgan.Size = new System.Drawing.Size(54, 17);
            this.lblOrgan.TabIndex = 2;
            this.lblOrgan.Text = "Organ:";
            // 
            // cmbDonor
            // 
            this.cmbDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonor.FormattingEnabled = true;
            this.cmbDonor.Location = new System.Drawing.Point(100, 27);
            this.cmbDonor.Name = "cmbDonor";
            this.cmbDonor.Size = new System.Drawing.Size(240, 25);
            this.cmbDonor.TabIndex = 1;
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Location = new System.Drawing.Point(20, 31);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(59, 17);
            this.lblDonor.TabIndex = 0;
            this.lblDonor.Text = "Bağışçı:";
            // 
            // tabRequests
            // 
            this.tabRequests.Controls.Add(this.dgvRequests);
            this.tabRequests.Controls.Add(this.panelTopRequest);
            this.tabRequests.Location = new System.Drawing.Point(4, 26);
            this.tabRequests.Name = "tabRequests";
            this.tabRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequests.Size = new System.Drawing.Size(972, 620);
            this.tabRequests.TabIndex = 1;
            this.tabRequests.Text = "Bekleme Listesi (Talepler)";
            this.tabRequests.UseVisualStyleBackColor = true;
            // 
            // dgvRequests
            // 
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(3, 53);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(966, 564);
            this.dgvRequests.TabIndex = 1;
            // 
            // panelTopRequest
            // 
            this.panelTopRequest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTopRequest.Controls.Add(this.lblRequestInfo);
            this.panelTopRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopRequest.Location = new System.Drawing.Point(3, 3);
            this.panelTopRequest.Name = "panelTopRequest";
            this.panelTopRequest.Size = new System.Drawing.Size(966, 50);
            this.panelTopRequest.TabIndex = 0;
            // 
            // lblRequestInfo
            // 
            this.lblRequestInfo.AutoSize = true;
            this.lblRequestInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblRequestInfo.Location = new System.Drawing.Point(15, 15);
            this.lblRequestInfo.Name = "lblRequestInfo";
            this.lblRequestInfo.Size = new System.Drawing.Size(462, 17);
            this.lblRequestInfo.TabIndex = 0;
            this.lblRequestInfo.Text = "Burada organ nakli bekleyen hastalar listelenir. (Talep tipi: Organ olanlar)";
            // 
            // tabMatching
            // 
            this.tabMatching.Controls.Add(this.splitContainer1);
            this.tabMatching.Location = new System.Drawing.Point(4, 26);
            this.tabMatching.Name = "tabMatching";
            this.tabMatching.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatching.Size = new System.Drawing.Size(972, 620);
            this.tabMatching.TabIndex = 2;
            this.tabMatching.Text = "Akıllı Eşleşme";
            this.tabMatching.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpAvailable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpResult);
            this.splitContainer1.Size = new System.Drawing.Size(966, 614);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpAvailable
            // 
            this.grpAvailable.Controls.Add(this.dgvMatchSource);
            this.grpAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAvailable.Location = new System.Drawing.Point(0, 0);
            this.grpAvailable.Name = "grpAvailable";
            this.grpAvailable.Size = new System.Drawing.Size(450, 614);
            this.grpAvailable.TabIndex = 0;
            this.grpAvailable.TabStop = false;
            this.grpAvailable.Text = "1. Adım: Kullanılabilir Organı Seçin";
            // 
            // dgvMatchSource
            // 
            this.dgvMatchSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatchSource.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatchSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatchSource.Location = new System.Drawing.Point(3, 19);
            this.dgvMatchSource.Name = "dgvMatchSource";
            this.dgvMatchSource.ReadOnly = true;
            this.dgvMatchSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatchSource.Size = new System.Drawing.Size(444, 592);
            this.dgvMatchSource.TabIndex = 0;
            this.dgvMatchSource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatchSource_CellClick);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.dgvMatches);
            this.grpResult.Controls.Add(this.panelMatchAction);
            this.grpResult.Controls.Add(this.lblMatchInfo);
            this.grpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResult.Location = new System.Drawing.Point(0, 0);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(512, 614);
            this.grpResult.TabIndex = 0;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "2. Adım: Eşleşen Hastalar (Sistem Önerisi)";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatches.Location = new System.Drawing.Point(3, 49);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(506, 502);
            this.dgvMatches.TabIndex = 2;
            // 
            // panelMatchAction
            // 
            this.panelMatchAction.Controls.Add(this.btnConfirmMatch);
            this.panelMatchAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMatchAction.Location = new System.Drawing.Point(3, 551);
            this.panelMatchAction.Name = "panelMatchAction";
            this.panelMatchAction.Size = new System.Drawing.Size(506, 60);
            this.panelMatchAction.TabIndex = 1;
            // 
            // btnConfirmMatch
            // 
            this.btnConfirmMatch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirmMatch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirmMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmMatch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmMatch.ForeColor = System.Drawing.Color.White;
            this.btnConfirmMatch.Location = new System.Drawing.Point(306, 0);
            this.btnConfirmMatch.Name = "btnConfirmMatch";
            this.btnConfirmMatch.Size = new System.Drawing.Size(200, 60);
            this.btnConfirmMatch.TabIndex = 0;
            this.btnConfirmMatch.Text = "Eşleşmeyi Onayla ve Transfere Gönder";
            this.btnConfirmMatch.UseVisualStyleBackColor = false;
            this.btnConfirmMatch.Click += new System.EventHandler(this.btnConfirmMatch_Click);
            // 
            // lblMatchInfo
            // 
            this.lblMatchInfo.BackColor = System.Drawing.Color.MistyRose;
            this.lblMatchInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMatchInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMatchInfo.Location = new System.Drawing.Point(3, 19);
            this.lblMatchInfo.Name = "lblMatchInfo";
            this.lblMatchInfo.Size = new System.Drawing.Size(506, 30);
            this.lblMatchInfo.TabIndex = 0;
            this.lblMatchInfo.Text = "Sol taraftan bir organ seçtiğinizde uygun hastalar burada listelenir.";
            this.lblMatchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrgan";
            this.Text = "frmOrgan";
            this.Load += new System.EventHandler(this.frmOrgan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDonations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganDonations)).EndInit();
            this.panelTopDonation.ResumeLayout(false);
            this.panelTopDonation.PerformLayout();
            this.tabRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.panelTopRequest.ResumeLayout(false);
            this.panelTopRequest.PerformLayout();
            this.tabMatching.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchSource)).EndInit();
            this.grpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.panelMatchAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDonations;
        private System.Windows.Forms.TabPage tabRequests;
        private System.Windows.Forms.TabPage tabMatching;
        private System.Windows.Forms.DataGridView dgvOrganDonations;
        private System.Windows.Forms.Panel panelTopDonation;
        private System.Windows.Forms.Button btnAddOrgan;
        private System.Windows.Forms.ComboBox cmbOrganType;
        private System.Windows.Forms.Label lblOrgan;
        private System.Windows.Forms.ComboBox cmbDonor;
        private System.Windows.Forms.Label lblDonor;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Panel panelTopRequest;
        private System.Windows.Forms.Label lblRequestInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpAvailable;
        private System.Windows.Forms.DataGridView dgvMatchSource;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Panel panelMatchAction;
        private System.Windows.Forms.Button btnConfirmMatch;
        private System.Windows.Forms.Label lblMatchInfo;
    }
}