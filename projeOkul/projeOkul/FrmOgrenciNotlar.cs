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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        public string No;
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0AQV4FJ;Initial Catalog=bonusOkul;Integrated Security=True");


        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand Com = new SqlCommand("select DersAd as 'Ders Adı', Sinav1 as '1.Sınav', Sinav2 as '2.Sınav', Sinav3 as '3.Sınav', Proje, Ortalama,Durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.Dersid = Tbl_Dersler.Dersid where Ogrİd = @V1", Con);
            Com.Parameters.AddWithValue("@V1",No);
            this.Text = No.ToString();
            SqlDataAdapter da = new SqlDataAdapter(Com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 Fr = new Form1();
            Fr.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
