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

namespace personelKayit
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-0AQV4FJ;Initial Catalog=PersonelVT;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı.
            Conn.Open();
            SqlCommand Com1 = new SqlCommand("select Count(*) from Tbl_Personel",Conn);
            SqlDataReader Dr1 = Com1.ExecuteReader();
            while (Dr1.Read()) 
            {
                lblTopPers.Text = Dr1[0].ToString();
            }
            Conn.Close();


            //Evli Personel Sayısı
            Conn.Open();
            SqlCommand Com2 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum=1",Conn);
            SqlDataReader Dr2 = Com2.ExecuteReader();
            while (Dr2.Read())
            {
                lblEvliPers.Text = Dr2[0].ToString();
            }
            Conn.Close();


            //Bekar Personel Sayısı
            Conn.Open();
            SqlCommand Com3 = new SqlCommand("Select Count(*) from Tbl_Personel where PerDurum=0", Conn);
            SqlDataReader Dr3 = Com3.ExecuteReader();
            while (Dr3.Read())
            {
                lblBekarPers.Text = Dr3[0].ToString();
            }
            Conn.Close();


            //Şehir Sayısı
            Conn.Open();
            SqlCommand Com4 = new SqlCommand("Select Count(distinct(PerSehir)) from Tbl_Personel",Conn);
            SqlDataReader Dr4 = Com4.ExecuteReader();
            while (Dr4.Read())
            {
                lblSehirSayisi.Text = Dr4[0].ToString();
            }
            Conn.Close();


            //Toplam Maaş
            Conn.Open();
            SqlCommand Com5 = new SqlCommand("select Sum(PerMaas) from Tbl_Personel",Conn);
            SqlDataReader Dr5 = Com5.ExecuteReader();
            while (Dr5.Read())
            {
                lblTopMaas.Text = Dr5[0].ToString();
            }
            Conn.Close();


            //Ortalama Maas
            Conn.Open();
            SqlCommand Com6 = new SqlCommand("select Avg(PerMaas) from Tbl_Personel",Conn);
            SqlDataReader Dr6 = Com6.ExecuteReader();
            while (Dr6.Read())
            {
                lblOrtMaas.Text = Dr6[0].ToString();
            }
            Conn.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
