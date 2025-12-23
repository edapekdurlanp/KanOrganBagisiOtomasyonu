namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmTransfers
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvTransfers = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.btnDeliver);
            this.panelTop.Controls.Add(this.lblInfo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(980, 80);
            this.panelTop.TabIndex = 0;
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeliver.ForeColor = System.Drawing.Color.White;
            this.btnDeliver.Location = new System.Drawing.Point(760, 20);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(200, 40);
            this.btnDeliver.TabIndex = 1;
            this.btnDeliver.Text = "Teslim Edildi İşaretle";
            this.btnDeliver.UseVisualStyleBackColor = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(20, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(374, 19);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Aktif Transfer Listesi (Yolda olan veya hazırlanan)";
            // 
            // dgvTransfers
            // 
            this.dgvTransfers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransfers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransfers.Location = new System.Drawing.Point(0, 80);
            this.dgvTransfers.Name = "dgvTransfers";
            this.dgvTransfers.ReadOnly = true;
            this.dgvTransfers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransfers.Size = new System.Drawing.Size(980, 570);
            this.dgvTransfers.TabIndex = 1;
            // 
            // frmTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.dgvTransfers);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransfers";
            this.Text = "frmTransfers";
            this.Load += new System.EventHandler(this.frmTransfers_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.DataGridView dgvTransfers;
    }
}