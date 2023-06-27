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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0AQV4FJ;Initial Catalog=bonusOkul;Integrated Security=True");
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmOgretmen FrmOgrt = new FrmOgretmen();
            FrmOgrt.Show();
            this.Hide();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            dataGridView1.DataSource = ds.OgrenciListesi();
            Con.Open();
            SqlCommand Com = new SqlCommand("select * from Tbl_Kulupler",Con);
            SqlDataAdapter da = new SqlDataAdapter(Com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulup.DisplayMember = "KulupAd";
            cmbKulup.ValueMember = "Kulupİd";
            cmbKulup.DataSource = dt;
        }

        public void listele()
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        public void temizle()
        {
            txtAd.Text = "";
            txtOgrenciNo.Text = "";
            txtSoyad.Text = "";
            cmbKulup.Text = "";
        }
        string C = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (rdbErkek.Checked == true && rdbKiz.Checked==false)
            {
                C = "ERKEK";
            }
            if(rdbErkek.Checked == false && rdbKiz.Checked == true)
            {
                C = "KIZ";
            }
            ds.OgrenciEkle(txtAd.Text,txtSoyad.Text,byte.Parse(cmbKulup.SelectedValue.ToString()),C);
            MessageBox.Show("Öğrenci Sisteme Eklenmiştir","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtOgrenciNo.Text));
            temizle();
            MessageBox.Show("Öğrenci Sistemden Sİlinmiştir.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (rdbErkek.Checked == true && rdbKiz.Checked == false)
            {
                C = "ERKEK";
            }
            if (rdbErkek.Checked == false && rdbKiz.Checked == true)
            {
                C = "KIZ";
            }
            ds.OgrenciGuncelleme(txtAd.Text,txtSoyad.Text,byte.Parse(cmbKulup.SelectedValue.ToString()),C,int.Parse(txtOgrenciNo.Text));
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "ERKEK" || dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek" || dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "erkek")
            {
                rdbErkek.Checked = true;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "KIZ" || dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kız" || dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "kız")
            {
                rdbKiz.Checked = true;
            }
            cmbKulup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ds.OgrenciGetir(txtAra.Text);
           txtAra.Text = "";
        }
    }
}
