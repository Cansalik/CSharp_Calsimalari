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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

           SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-0AQV4FJ;Initial Catalog=PersonelVT;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@V1 and Sifre=@V2",Conn);
            Com.Parameters.AddWithValue("@V1",txtKadi.Text);
            Com.Parameters.AddWithValue("@V2", txtSifre.Text);
            SqlDataReader Dr = Com.ExecuteReader();
            if (Dr.Read())
            {
                FrmAnaForm Frm = new FrmAnaForm();
                Frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Bilgileri!","HATA",MessageBoxButtons.OK);
            }

            Conn.Close();
        }
    }
}
