namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmBloodStock
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
            this.tabStockList = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panelTopStock = new System.Windows.Forms.Panel();
            this.lblStockInfo = new System.Windows.Forms.Label();
            this.tabLab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPendingDonations = new System.Windows.Forms.DataGridView();
            this.lblPendingInfo = new System.Windows.Forms.Label();
            this.grpTestResult = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTests = new System.Windows.Forms.GroupBox();
            this.chkSyphilis = new System.Windows.Forms.CheckBox();
            this.chkHIV = new System.Windows.Forms.CheckBox();
            this.chkHepatitisC = new System.Windows.Forms.CheckBox();
            this.chkHepatitisB = new System.Windows.Forms.CheckBox();
            this.txtSelectedBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabStockList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panelTopStock.SuspendLayout();
            this.tabLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingDonations)).BeginInit();
            this.grpTestResult.SuspendLayout();
            this.groupBoxTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStockList);
            this.tabControl1.Controls.Add(this.tabLab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 650);
            this.tabControl1.TabIndex = 2;
            // 
            // tabStockList
            // 
            this.tabStockList.Controls.Add(this.dgvStock);
            this.tabStockList.Controls.Add(this.panelTopStock);
            this.tabStockList.Location = new System.Drawing.Point(4, 26);
            this.tabStockList.Name = "tabStockList";
            this.tabStockList.Padding = new System.Windows.Forms.Padding(3);
            this.tabStockList.Size = new System.Drawing.Size(972, 620);
            this.tabStockList.TabIndex = 0;
            this.tabStockList.Text = "Mevcut Kan Stokları";
            this.tabStockList.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(3, 53);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(966, 564);
            this.dgvStock.TabIndex = 1;
            // 
            // panelTopStock
            // 
            this.panelTopStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTopStock.Controls.Add(this.lblStockInfo);
            this.panelTopStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopStock.Location = new System.Drawing.Point(3, 3);
            this.panelTopStock.Name = "panelTopStock";
            this.panelTopStock.Size = new System.Drawing.Size(966, 50);
            this.panelTopStock.TabIndex = 0;
            // 
            // lblStockInfo
            // 
            this.lblStockInfo.AutoSize = true;
            this.lblStockInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblStockInfo.Location = new System.Drawing.Point(15, 15);
            this.lblStockInfo.Name = "lblStockInfo";
            this.lblStockInfo.Size = new System.Drawing.Size(378, 18);
            this.lblStockInfo.TabIndex = 0;
            this.lblStockInfo.Text = "Depoda kullanıma hazır (test edilmiş) kan üniteleri:";
            // 
            // tabLab
            // 
            this.tabLab.Controls.Add(this.splitContainer1);
            this.tabLab.Location = new System.Drawing.Point(4, 26);
            this.tabLab.Name = "tabLab";
            this.tabLab.Padding = new System.Windows.Forms.Padding(3);
            this.tabLab.Size = new System.Drawing.Size(972, 620);
            this.tabLab.TabIndex = 1;
            this.tabLab.Text = "Laboratuvar (Test ve Onay)";
            this.tabLab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPendingDonations);
            this.splitContainer1.Panel1.Controls.Add(this.lblPendingInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpTestResult);
            this.splitContainer1.Size = new System.Drawing.Size(966, 614);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvPendingDonations
            // 
            this.dgvPendingDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingDonations.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendingDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendingDonations.Location = new System.Drawing.Point(0, 30);
            this.dgvPendingDonations.Name = "dgvPendingDonations";
            this.dgvPendingDonations.ReadOnly = true;
            this.dgvPendingDonations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingDonations.Size = new System.Drawing.Size(550, 584);
            this.dgvPendingDonations.TabIndex = 1;
            this.dgvPendingDonations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingDonations_CellClick);
            // 
            // lblPendingInfo
            // 
            this.lblPendingInfo.BackColor = System.Drawing.Color.MistyRose;
            this.lblPendingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPendingInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPendingInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblPendingInfo.Location = new System.Drawing.Point(0, 0);
            this.lblPendingInfo.Name = "lblPendingInfo";
            this.lblPendingInfo.Size = new System.Drawing.Size(550, 30);
            this.lblPendingInfo.TabIndex = 0;
            this.lblPendingInfo.Text = "TEST BEKLEYEN (KARANTİNA) BAĞIŞLAR";
            this.lblPendingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTestResult
            // 
            this.grpTestResult.Controls.Add(this.btnSaveResult);
            this.grpTestResult.Controls.Add(this.lblProductType);
            this.grpTestResult.Controls.Add(this.cmbProductType);
            this.grpTestResult.Controls.Add(this.lblExpDate);
            this.grpTestResult.Controls.Add(this.dtpExpiration);
            this.grpTestResult.Controls.Add(this.groupBoxTests);
            this.grpTestResult.Controls.Add(this.txtSelectedBarcode);
            this.grpTestResult.Controls.Add(this.lblBarcode);
            this.grpTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTestResult.Location = new System.Drawing.Point(0, 0);
            this.grpTestResult.Name = "grpTestResult";
            this.grpTestResult.Size = new System.Drawing.Size(412, 614);
            this.grpTestResult.TabIndex = 0;
            this.grpTestResult.TabStop = false;
            this.grpTestResult.Text = "Laboratuvar Sonuç Girişi";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSaveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResult.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveResult.ForeColor = System.Drawing.Color.White;
            this.btnSaveResult.Location = new System.Drawing.Point(30, 480);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(350, 50);
            this.btnSaveResult.TabIndex = 7;
            this.btnSaveResult.Text = "Sonuçları Kaydet ve Onayla";
            this.btnSaveResult.UseVisualStyleBackColor = false;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(27, 360);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(200, 17);
            this.lblProductType.TabIndex = 6;
            this.lblProductType.Text = "Dönüştürülecek Ürün (Bileşen):";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Tam Kan",
            "Eritrosit Süspansiyonu",
            "Taze Donmuş Plazma",
            "Trombosit"});
            this.cmbProductType.Location = new System.Drawing.Point(30, 380);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(350, 25);
            this.cmbProductType.TabIndex = 5;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(27, 290);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(176, 17);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "Stok Son Kullanma Tarihi:";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Location = new System.Drawing.Point(30, 310);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(350, 23);
            this.dtpExpiration.TabIndex = 3;
            // 
            // groupBoxTests
            // 
            this.groupBoxTests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxTests.Controls.Add(this.chkSyphilis);
            this.groupBoxTests.Controls.Add(this.chkHIV);
            this.groupBoxTests.Controls.Add(this.chkHepatitisC);
            this.groupBoxTests.Controls.Add(this.chkHepatitisB);
            this.groupBoxTests.Location = new System.Drawing.Point(30, 90);
            this.groupBoxTests.Name = "groupBoxTests";
            this.groupBoxTests.Size = new System.Drawing.Size(350, 180);
            this.groupBoxTests.TabIndex = 2;
            this.groupBoxTests.TabStop = false;
            this.groupBoxTests.Text = "Test Sonuçları (Pozitif olanı işaretleyin)";
            // 
            // chkSyphilis
            // 
            this.chkSyphilis.AutoSize = true;
            this.chkSyphilis.Location = new System.Drawing.Point(20, 140);
            this.chkSyphilis.Name = "chkSyphilis";
            this.chkSyphilis.Size = new System.Drawing.Size(121, 21);
            this.chkSyphilis.TabIndex = 3;
            this.chkSyphilis.Text = "Syphilis (Frengi)";
            this.chkSyphilis.UseVisualStyleBackColor = true;
            // 
            // chkHIV
            // 
            this.chkHIV.AutoSize = true;
            this.chkHIV.Location = new System.Drawing.Point(20, 105);
            this.chkHIV.Name = "chkHIV";
            this.chkHIV.Size = new System.Drawing.Size(95, 21);
            this.chkHIV.TabIndex = 2;
            this.chkHIV.Text = "HIV (AIDS)";
            this.chkHIV.UseVisualStyleBackColor = true;
            // 
            // chkHepatitisC
            // 
            this.chkHepatitisC.AutoSize = true;
            this.chkHepatitisC.Location = new System.Drawing.Point(20, 70);
            this.chkHepatitisC.Name = "chkHepatitisC";
            this.chkHepatitisC.Size = new System.Drawing.Size(139, 21);
            this.chkHepatitisC.TabIndex = 1;
            this.chkHepatitisC.Text = "Hepatit C (HCV)";
            this.chkHepatitisC.UseVisualStyleBackColor = true;
            // 
            // chkHepatitisB
            // 
            this.chkHepatitisB.AutoSize = true;
            this.chkHepatitisB.Location = new System.Drawing.Point(20, 35);
            this.chkHepatitisB.Name = "chkHepatitisB";
            this.chkHepatitisB.Size = new System.Drawing.Size(137, 21);
            this.chkHepatitisB.TabIndex = 0;
            this.chkHepatitisB.Text = "Hepatit B (HBsAg)";
            this.chkHepatitisB.UseVisualStyleBackColor = true;
            // 
            // txtSelectedBarcode
            // 
            this.txtSelectedBarcode.Enabled = false;
            this.txtSelectedBarcode.Location = new System.Drawing.Point(30, 50);
            this.txtSelectedBarcode.Name = "txtSelectedBarcode";
            this.txtSelectedBarcode.Size = new System.Drawing.Size(350, 23);
            this.txtSelectedBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(27, 30);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(107, 17);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Seçilen Barkod:";
            // 
            // frmBloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBloodStock";
            this.Text = "frmBloodStock";
            this.Load += new System.EventHandler(this.frmBloodStock_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStockList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panelTopStock.ResumeLayout(false);
            this.panelTopStock.PerformLayout();
            this.tabLab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingDonations)).EndInit();
            this.grpTestResult.ResumeLayout(false);
            this.grpTestResult.PerformLayout();
            this.groupBoxTests.ResumeLayout(false);
            this.groupBoxTests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStockList;
        private System.Windows.Forms.TabPage tabLab;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panelTopStock;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPendingDonations;
        private System.Windows.Forms.Label lblPendingInfo;
        private System.Windows.Forms.GroupBox grpTestResult;
        private System.Windows.Forms.GroupBox groupBoxTests;
        private System.Windows.Forms.TextBox txtSelectedBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.CheckBox chkSyphilis;
        private System.Windows.Forms.CheckBox chkHIV;
        private System.Windows.Forms.CheckBox chkHepatitisC;
        private System.Windows.Forms.CheckBox chkHepatitisB;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Label lblStockInfo;
    }
}