using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entityProje.Properties;

namespace entityProje
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        Db_EntityUrunEntities db = new Db_EntityUrunEntities();

        public void temizle()
        {
            txtUurnAd.Text = "";
            txtFiyat.Text = "";
            txtMarka.Text = "";
            txtStok.Text = "";
            txtUrunID.Text = "";
            cmbKategori.Text = "";
            txtDurum.Text = "";

        }

        public void listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.URUNMARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM
                                        }).ToList();
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            

            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[2].HeaderText = "Marka";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[3].HeaderText = "Stok";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[4].HeaderText = "Fiyat";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[5].HeaderText = "Kategori";
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns[6].HeaderText = "Durum";
            dataGridView1.Columns[6].Width = 60;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
            /*dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.URUNMARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM
                                        }).ToList();*/
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urun U = new Tbl_Urun();
            U.URUNAD = txtUurnAd.Text;
            U.URUNMARKA = txtMarka.Text;
            U.STOK = short.Parse(txtStok.Text);
            U.KATEGORİ = int.Parse(cmbKategori.SelectedValue.ToString());
            U.FIYAT = decimal.Parse(txtFiyat.Text);
            U.DURUM = true;
            db.Tbl_Urun.Add(U);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Eklenmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtUrunID.Text);
            var U = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(U);
            db.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            listele();
            var Kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = Kategoriler;



            


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtUrunID.Text);
            var U = db.Tbl_Urun.Find(x);
            U.URUNAD = txtUurnAd.Text;
            U.URUNMARKA = txtMarka.Text;
            U.STOK = short.Parse(txtStok.Text);
            U.FIYAT = decimal.Parse(txtFiyat.Text);
            U.KATEGORİ = int.Parse(cmbKategori.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Tamamlanmıştır.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int M;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUurnAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "True" || dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "true")
            {
                txtDurum.Text = "Yeterli";
            }
            else
            {
                txtDurum.Text = "Az";
            }
            cmbKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
