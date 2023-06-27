using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projeOkul
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0AQV4FJ;Initial Catalog=bonusOkul;Integrated Security=True");

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtOgrenciNo.Text));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmOgretmen FrmO = new FrmOgretmen();
            FrmO.Show();
            this.Hide();
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand Com = new SqlCommand("select * from Tbl_Dersler", Con);
            SqlDataAdapter da = new SqlDataAdapter(Com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "Dersid";
            cmbDers.DataSource = dt;
        }
        int Notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOgrenciNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtS1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtS2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtS3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        int S1, S2, S3, P;

        private void btnDersNo_Click(object sender, EventArgs e)
        {
            FrmDersNuamra FrmDn = new FrmDersNuamra();
            FrmDn.Show();
            this.Hide();
        }

        decimal Ort;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            //string Durum;

            S1 = Convert.ToInt32(txtS1.Text);
            S2 = Convert.ToInt32(txtS2.Text);
            S3 = Convert.ToInt32(txtS3.Text);
            P = Convert.ToInt32(txtProje.Text);
            Ort = (S1 + S2 + S3 + P) / 4;
            txtOrtalama.Text = Ort.ToString();
            if (Ort>=50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelleme(byte.Parse(cmbDers.SelectedValue.ToString()),int.Parse(txtOgrenciNo.Text),byte.Parse(txtS1.Text), byte.Parse(txtS2.Text), byte.Parse(txtS3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtOrtalama.Text),bool.Parse(txtDurum.Text),Notid);
            MessageBox.Show("Güncelleme İşlemi Tamamlanmıştır","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
