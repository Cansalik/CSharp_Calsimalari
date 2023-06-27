using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityProje
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        Db_EntityUrunEntities db = new Db_EntityUrunEntities();

        public void listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_Kategori
                                        select new
                                        {
                                            x.ID,
                                            x.AD

                                        }).ToList();
            dataGridView1.Columns[0].HeaderText = "No";
            dataGridView1.Columns[1].HeaderText = "Kategori Adı";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public void temizle()
        {
            txtAd.Text = "";
            txtID.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori K = new Tbl_Kategori();
            K.AD = txtAd.Text;
            db.Tbl_Kategori.Add(K);
            db.SaveChanges();
            MessageBox.Show("Kategori Sisteme Eklnemiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(txtID.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            ktgr.AD = txtAd.Text;
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Secilen = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.Text = Secilen;
        }
    }
}
