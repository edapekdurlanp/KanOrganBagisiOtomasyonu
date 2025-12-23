using KanOrganBagisTakipOtomasyonu.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KanOrganBagisTakipOtomasyonu.Formlar
{
    public partial class frmTransfers : Form
    {
        KOBDB_Entites db = new KOBDB_Entites();

        public frmTransfers()
        {
            InitializeComponent();
        }

        private void frmTransfers_Load(object sender, EventArgs e)
        {
            LoadTransfers();
        }

        private void LoadTransfers()
        {
            var list = (from t in db.transfers
                        join r in db.requests on t.request_id equals r.request_id
                        join p in db.patients on r.patient_id equals p.patient_id
                        join h in db.hospitals on p.hospital_id equals h.hospital_id
                        where t.status != "TeslimEdildi"
                        select new
                        {
                            TransferID = t.transfer_id,
                            Tip = r.request_type,
                            Ürün = r.required_product,
                            Hasta = p.name_surname,
                            HedefHastane = h.hospital_name,
                            ÇıkışZamanı = t.departure_time,
                            Durum = t.status
                        }).ToList();

            dgvTransfers.DataSource = list;
            if (dgvTransfers.Columns.Count > 0)
                dgvTransfers.Columns[0].Visible = false;
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (dgvTransfers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTransfers.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("Transferin başarıyla tamamlandığını onaylıyor musunuz?", "Teslimat Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        var transfer = db.transfers.Find(id);
                        transfer.status = "TeslimEdildi";
                        transfer.actual_arrival = DateTime.Now;

                        // İlgili talebi de kapat
                        var request = db.requests.Find(transfer.request_id);
                        request.status = "Tamamlandı";

                        db.SaveChanges();
                        MessageBox.Show("Teslimat kaydı başarıyla işlendi.");
                        LoadTransfers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir transfer seçiniz.");
            }
        }
    }
}