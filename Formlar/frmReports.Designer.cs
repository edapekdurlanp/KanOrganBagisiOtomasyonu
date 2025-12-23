namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    partial class frmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOrgan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.rvMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabCharts.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrgan)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCharts);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1307, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.tableLayoutPanel1);
            this.tabCharts.Controls.Add(this.panelInfo);
            this.tabCharts.Location = new System.Drawing.Point(4, 30);
            this.tabCharts.Margin = new System.Windows.Forms.Padding(4);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Padding = new System.Windows.Forms.Padding(4);
            this.tabCharts.Size = new System.Drawing.Size(1299, 766);
            this.tabCharts.TabIndex = 0;
            this.tabCharts.Text = "Grafikler ve Analiz";
            this.tabCharts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartStock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartOrgan, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 66);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1291, 696);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chartStock
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea3);
            this.chartStock.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartStock.Legends.Add(legend3);
            this.chartStock.Location = new System.Drawing.Point(4, 4);
            this.chartStock.Margin = new System.Windows.Forms.Padding(4);
            this.chartStock.Name = "chartStock";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "StokAdeti";
            this.chartStock.Series.Add(series3);
            this.chartStock.Size = new System.Drawing.Size(637, 688);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart1";
            // 
            // chartOrgan
            // 
            chartArea4.Name = "ChartArea1";
            this.chartOrgan.ChartAreas.Add(chartArea4);
            this.chartOrgan.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartOrgan.Legends.Add(legend4);
            this.chartOrgan.Location = new System.Drawing.Point(649, 4);
            this.chartOrgan.Margin = new System.Windows.Forms.Padding(4);
            this.chartOrgan.Name = "chartOrgan";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "OrganDagilimi";
            this.chartOrgan.Series.Add(series4);
            this.chartOrgan.Size = new System.Drawing.Size(638, 688);
            this.chartOrgan.TabIndex = 1;
            this.chartOrgan.Text = "chart2";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfo.Controls.Add(this.lblInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(4, 4);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1291, 62);
            this.panelInfo.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(20, 18);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(842, 23);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Sol: Kan Grubuna Göre Stok Miktarı (Sütun)  |  Sağ: Bağışlanan Organ Dağılımı (Pa" +
    "sta)";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.rvMain);
            this.tabReports.Controls.Add(this.btnShowReport);
            this.tabReports.Controls.Add(this.cmbReportType);
            this.tabReports.Location = new System.Drawing.Point(4, 30);
            this.tabReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(4);
            this.tabReports.Size = new System.Drawing.Size(1299, 766);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Yazdırılabilir Raporlar";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(26, 96);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(1248, 53);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Raporu Göster";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // cmbReportType
            // 
            this.cmbReportType.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Bağışçı Raporu",
            "Hasta Raporu"});
            this.cmbReportType.Location = new System.Drawing.Point(26, 20);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(1248, 45);
            this.cmbReportType.TabIndex = 1;
            // 
            // rvMain
            // 
            this.rvMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rvMain.Location = new System.Drawing.Point(4, 185);
            this.rvMain.Name = "rvMain";
            this.rvMain.ServerReport.BearerToken = null;
            this.rvMain.Size = new System.Drawing.Size(1291, 577);
            this.rvMain.TabIndex = 3;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 800);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCharts.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrgan)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrgan;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnShowReport;
        private Microsoft.Reporting.WinForms.ReportViewer rvMain;
    }
}