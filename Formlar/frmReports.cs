using KanOrganBagisTakipOtomasyonu.Database;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmReports : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            // 1. İşleme Modunu Ayarla
            this.rvMain.ProcessingMode = ProcessingMode.Local;

            // 2. Grafikleri Yükle
            LoadStockChart();
            LoadOrganChart();

            // 3. COMBOBOX DOLDURMA (Burası Eksik Olabilir)
            // Tasarımda eklemediysek kodla ekleyelim ki kesin olsun.
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Bağışçı Raporu");
            cmbReportType.Items.Add("Hasta Raporu");

            // Varsayılan Seçim
            cmbReportType.SelectedIndex = 0;

            // İlk açılışta raporu yükle
            LoadDonorReport();
            this.rvMain.RefreshReport();
            this.rvMain.RefreshReport();
        }

        private void LoadDonorReport()
        {
            try
            {
                // Dosya Yolu: Raporlar klasöründe
                string raporYolu = Application.StartupPath + @"\Raporlar\rptDonor.rdlc";

                if (!File.Exists(raporYolu))
                {
                    // Yedek kontrol: Belki ana dizindedir (Copy Always yaptıysan)
                    raporYolu = Application.StartupPath + @"\rptDonor.rdlc";
                    if (!File.Exists(raporYolu))
                    {
                        MessageBox.Show("Rapor dosyası bulunamadı! (rptDonor.rdlc)");
                        return;
                    }
                }

                rvMain.LocalReport.ReportPath = raporYolu;

                var list = (from d in db.donors
                            join c in db.cities on d.city_id equals c.city_id into cJoin
                            from c in cJoin.DefaultIfEmpty()
                            select new
                            {
                                d.tckn,
                                d.name_surname,
                                Kan = d.blood_type + d.rh_factor,
                                Sehir = c != null ? c.city_name : "",
                                d.phone,
                                Tarih = d.last_donation_date
                            }).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("TCKN");
                dt.Columns.Add("AdSoyad");
                dt.Columns.Add("KanGrubu");
                dt.Columns.Add("Sehir");
                dt.Columns.Add("Telefon");
                dt.Columns.Add("SonBagisTarihi");

                foreach (var item in list)
                {
                    DataRow row = dt.NewRow();
                    row["TCKN"] = item.tckn;
                    row["AdSoyad"] = item.name_surname;
                    row["KanGrubu"] = item.Kan;
                    row["Sehir"] = item.Sehir;
                    row["Telefon"] = item.phone;
                    row["SonBagisTarihi"] = item.Tarih.HasValue ? item.Tarih.Value.ToShortDateString() : "-";
                    dt.Rows.Add(row);
                }

                rvMain.LocalReport.DataSources.Add(new ReportDataSource("dsDonor", dt));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void LoadPatientReport()
        {
            try
            {
                string raporYolu = Application.StartupPath + @"\Raporlar\rptPatient.rdlc";

                if (!File.Exists(raporYolu))
                {
                    raporYolu = Application.StartupPath + @"\rptPatient.rdlc";
                    if (!File.Exists(raporYolu))
                    {
                        MessageBox.Show("Rapor dosyası bulunamadı! (rptPatient.rdlc)");
                        return;
                    }
                }

                rvMain.LocalReport.ReportPath = raporYolu;

                var list = (from p in db.patients
                            join h in db.hospitals on p.hospital_id equals h.hospital_id into hJoin
                            from h in hJoin.DefaultIfEmpty()
                            select new
                            {
                                p.tckn,
                                p.name_surname,
                                Kan = p.blood_type + p.rh_factor,
                                Hastane = h != null ? h.hospital_name : "",
                                p.diagnosis,
                                p.urgency_status
                            }).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("TCKN");
                dt.Columns.Add("AdSoyad");
                dt.Columns.Add("KanGrubu");
                dt.Columns.Add("Hastane");
                dt.Columns.Add("Teshis");
                dt.Columns.Add("Aciliyet");

                foreach (var item in list)
                {
                    DataRow row = dt.NewRow();
                    row["TCKN"] = item.tckn;
                    row["AdSoyad"] = item.name_surname;
                    row["KanGrubu"] = item.Kan;
                    row["Hastane"] = item.Hastane;
                    row["Teshis"] = item.diagnosis;
                    row["Aciliyet"] = item.urgency_status;
                    dt.Rows.Add(row);
                }

                rvMain.LocalReport.DataSources.Add(new ReportDataSource("dsPatient", dt));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- GRAFİKLER (DEĞİŞMEDİ) ---
        private void LoadStockChart()
        {
            var stockData = (from s in db.blood_stocks
                             where s.is_used == false
                             group s by new { s.blood_type, s.rh_factor } into g
                             select new { KanGrubu = g.Key.blood_type + g.Key.rh_factor, Adet = g.Count() }).ToList();

            chartStock.Series.Clear();
            var series = chartStock.Series.Add("KanStokları");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            foreach (var item in stockData) { series.Points.AddXY(item.KanGrubu, item.Adet); }
            chartStock.Titles.Clear(); chartStock.Titles.Add("Güncel Kan Stoğu");
        }

        private void LoadOrganChart()
        {
            var organData = (from o in db.organ_donations
                             group o by o.organ_name into g
                             select new { Organ = g.Key, Adet = g.Count() }).ToList();

            chartOrgan.Series.Clear();
            var series = chartOrgan.Series.Add("Organlar");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            foreach (var item in organData) { series.Points.AddXY(item.Organ, item.Adet); }
            chartOrgan.Titles.Clear(); chartOrgan.Titles.Add("Organ Bağış Dağılımı");
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            rvMain.Reset();
            rvMain.ProcessingMode = ProcessingMode.Local;

            if (cmbReportType.SelectedIndex == 0)
            {
                LoadDonorReport();
            }
            else if (cmbReportType.SelectedIndex == 1)
            {
                LoadPatientReport();
            }
            else
            {
                MessageBox.Show("Lütfen bir rapor türü seçiniz.");
            }
            this.rvMain.RefreshReport();
        }
    }
}