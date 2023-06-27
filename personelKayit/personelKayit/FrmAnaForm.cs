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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        void Temizle() 
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtMeslek.Text = "";
            txtSoyad.Text = "";
            mskMaas.Text = "";
            cmbSehir.Text = "";
            rdbBekar.Checked = false;
            rdbEvli.Checked = false;
            txtAd.Focus();
        }

        SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-0AQV4FJ;Initial Catalog=PersonelVT;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVTDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Conn.Open();

            SqlCommand Com = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas,PerDurum,PerMeslek) values (@V1,@V2,@V3,@V4,@V5,@V6)", Conn);
            Com.Parameters.AddWithValue("@V1",txtAd.Text);
            Com.Parameters.AddWithValue("@V2",txtSoyad.Text);
            Com.Parameters.AddWithValue("@V3", cmbSehir.Text);
            Com.Parameters.AddWithValue("@V4", mskMaas.Text);
            if (rdbBekar.Checked == true || rdbEvli.Checked == false)
            {
                Com.Parameters.AddWithValue("@V5",false);
            }
            else
            {
                Com.Parameters.AddWithValue("@V5", true);
            }
            Com.Parameters.AddWithValue("@V6", txtMeslek.Text);
            Com.ExecuteNonQuery();

            Conn.Close();
            MessageBox.Show("Personel Bilgileri Kaydedilmiştir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[Secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[Secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[Secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[Secilen].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[Secilen].Cells[6].Value.ToString();
            lblRadio.Text = dataGridView1.Rows[Secilen].Cells[5].Value.ToString();
            
        }

        private void lblRadio_TextChanged(object sender, EventArgs e)
        {
            if (lblRadio.Text == "True")
            {
                rdbEvli.Checked = true;
            }
            if (lblRadio.Text == "False")
            {
                rdbBekar.Checked = true;
            }
        }

        private void rdbBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBekar.Checked == true)
            {
                lblRadio.Text = "False";
            }
        }

        private void rdbEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEvli.Checked == true)
            {
                lblRadio.Text = "True";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("delete from Tbl_Personel where Perid = @V1",Conn);
            Com.Parameters.AddWithValue("@V1", txtId.Text);
            Com.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Personel Silinmiştir.!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("update Tbl_Personel Set PerAd = @V1, PerSoyad = @V2, PerSehir = @V3, PerMaas = @V4, PerDurum = @V5, PerMeslek = @V6 where Perid = @V7",Conn);
            Com.Parameters.AddWithValue("@V1",txtAd.Text);
            Com.Parameters.AddWithValue("@V2", txtSoyad.Text);
            Com.Parameters.AddWithValue("@V3", cmbSehir.Text);
            Com.Parameters.AddWithValue("@V4", mskMaas.Text);
            Com.Parameters.AddWithValue("@V5", lblRadio.Text);
            Com.Parameters.AddWithValue("@V6", txtMeslek.Text);
            Com.Parameters.AddWithValue("@V7", txtId.Text);
            Com.ExecuteNonQuery();
            Conn.Close();

            MessageBox.Show("Personel Bilgileri Güncellendi.");
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik FrmI = new FrmIstatistik();
            FrmI.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler FrmG = new FrmGrafikler();
            FrmG.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmRaporlar FrmR = new FrmRaporlar();
            FrmR.Show();
        }
    }
}
