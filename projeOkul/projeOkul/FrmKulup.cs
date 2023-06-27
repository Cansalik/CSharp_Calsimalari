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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0AQV4FJ;Initial Catalog=bonusOkul;Integrated Security=True");

        public void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Kulupİd as 'Kulüp No', KulupAd as 'Kulüp Adı' from Tbl_Kulupler", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Temizle()
        {
            txtKulupAd.Text = "";
            txtKulupNo.Text = "";
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmOgretmen FrmOGR = new FrmOgretmen();
            FrmOGR.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand Com = new SqlCommand("insert into Tbl_Kulupler (KulupAd) values (@V1)",Con);
            Com.Parameters.AddWithValue("@V1",txtKulupAd.Text);
            Com.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Kulüp Sisteme Eklendi.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand Com = new SqlCommand("delete from Tbl_Kulupler where Kulupİd=@V1",Con);
            Com.Parameters.AddWithValue("@V1",txtKulupNo.Text);
            Com.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Kulüp Sistemden Silindi.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand Com = new SqlCommand("update Tbl_Kulupler set KulupAd=@V1 where Kulupİd=@V2",Con);
            Com.Parameters.AddWithValue("@V1",txtKulupAd.Text);
            Com.Parameters.AddWithValue("@V2",txtKulupNo.Text);
            Com.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Kulüp Sistemden Güncellendi ", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            Temizle();
        }
    }
}
