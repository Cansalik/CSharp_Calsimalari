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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-0AQV4FJ;Initial Catalog=PersonelVT;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Grafik1
            Conn.Open();

            SqlCommand Com1 = new SqlCommand("Select PerSehir,Count(*) from Tbl_Personel Group By PerSehir",Conn);
            SqlDataReader Dr1 = Com1.ExecuteReader();
            while (Dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(Dr1[0],Dr1[1]);
            }
            Conn.Close();


            //Grafik 2
            Conn.Open();
            SqlCommand Com2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) from Tbl_Personel Group By PerMeslek", Conn);
            SqlDataReader Dr2 = Com2.ExecuteReader();
            while (Dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(Dr2[0], Dr2[1]);
            }
            Conn.Close();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
