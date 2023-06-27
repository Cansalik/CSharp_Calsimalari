using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KitaplikProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\cansa\Documents\Visual Studio 2019\Projects\KitaplikProje\AccessVT\Kitaplik.mdb");

        void listele() 
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle() 
        {
            txtAd.Text = "";
            txtid.Text = "";
            txtSayfaSayisi.Text = "";
            txtYazar.Text = "";
            cmbTur.Text = "";
            rdbIkınciEl.Checked = false;
            rdbPaket.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand Com = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur,SayfaSayi,Durum) values (@V1,@V2,@V3,@V4,@V5)",baglanti);
            Com.Parameters.AddWithValue("@V1",txtAd.Text);
            Com.Parameters.AddWithValue("@V2", txtYazar.Text);
            Com.Parameters.AddWithValue("@V3", cmbTur.Text);
            Com.Parameters.AddWithValue("@V4", txtSayfaSayisi.Text);
            if (rdbIkınciEl.Checked == true || rdbPaket.Checked==false)
            {
                lblDurum.Text = "0";
            }
            if (rdbPaket.Checked == true || rdbIkınciEl.Checked == false)
            {
                lblDurum.Text = "1";
            }
            Com.Parameters.AddWithValue("@V5",lblDurum.Text);
            Com.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);

            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand Com = new OleDbCommand("delete from Kitaplar where Kitapid=@V1",baglanti);
            Com.Parameters.AddWithValue("@V1",txtid.Text);
            Com.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sistemden Silindi","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[Secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[Secilen].Cells[2].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[Secilen].Cells[3].Value.ToString();
            txtSayfaSayisi.Text = dataGridView1.Rows[Secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[Secilen].Cells[5].Value.ToString() == "True")
            {
                rdbPaket.Checked = true;
            }
            else
            {
                rdbIkınciEl.Checked = true; ;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand Com = new OleDbCommand("update Kitaplar set KitapAd=@V1,Yazar=@V2,Tur=@V3,SayfaSayi=@V4,Durum=@V5 where Kitapid=@V6",baglanti);
            Com.Parameters.AddWithValue("@V1",txtAd.Text);
            Com.Parameters.AddWithValue("@V2", txtYazar.Text);
            Com.Parameters.AddWithValue("@V3", cmbTur.Text);
            Com.Parameters.AddWithValue("@V4", txtSayfaSayisi.Text);
            if (rdbIkınciEl.Checked == true)
            {
                Com.Parameters.AddWithValue("@V5","0");
            }
            if (rdbPaket.Checked == true)
            {
                Com.Parameters.AddWithValue("@V5", "1");
            }
            Com.Parameters.AddWithValue("@V6",txtid.Text);
            Com.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand Com = new OleDbCommand("select * from Kitaplar where KitapAd=@V1",baglanti);
            Com.Parameters.AddWithValue("@V1",txtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand Com = new OleDbCommand("select * from Kitaplar where KitapAd like '%"+ txtKitapBul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
    }
}
