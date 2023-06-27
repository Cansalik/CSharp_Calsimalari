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
    public partial class FrmYetkiliOgretmen : Form
    {
        public FrmYetkiliOgretmen()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0AQV4FJ;Initial Catalog=bonusOkul;Integrated Security=True");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
                pcrGorunur.Visible = true;
                pcrGizli.Visible = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                pcrGizli.Visible = true;
                pcrGorunur.Visible = false;
            }
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (mskTC.Text != "" && txtSifre.Text != "")
            {
                Con.Open();
                SqlCommand Com = new SqlCommand("Select * from Tbl_YetkiliOgretmen where OgrSifre=@V1 and OgrTC=@V2", Con);
                Com.Parameters.AddWithValue("@v1", txtSifre.Text);
                Com.Parameters.AddWithValue("@V2", mskTC.Text);
                SqlDataReader Dr = Com.ExecuteReader();
                if (Dr.Read())
                {
                    Con.Close();
                    FrmOgretmen FrmOgr = new FrmOgretmen();
                    FrmOgr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatallı Yetkili Girişi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
