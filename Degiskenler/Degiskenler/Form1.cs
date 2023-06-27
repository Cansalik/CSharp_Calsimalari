using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAdSoyad.Text = txtAdSoyad.Text;
            lblYas.Text = cmbxYas.Text;
            lblMeslek.Text = txtMeslek.Text;
            lblCinsiyet.Text = cmbxCinsiyet.Text;

            listBox1.Items.Add("Adı Soyadı: " + lblAdSoyad.Text);
            listBox1.Items.Add("Yaşı: " + lblYas.Text);
            listBox1.Items.Add("Mesleği:  " + lblMeslek.Text);
            listBox1.Items.Add("Cinsiyeti: " + lblCinsiyet.Text);

        }

        private void btnKareHesap_Click(object sender, EventArgs e)
        {
            int Kenar, Alan, Cevre;

            Kenar = int.Parse(txtKareKenar.Text);

            Alan = Kenar * Kenar;
            Cevre = Kenar * 4;

            lblKareAlan.Text = Alan.ToString();
            lblKareCevre.Text = Cevre.ToString();
        }

        private void btnDikdortgenHesap_Click(object sender, EventArgs e)
        {
            int KKenar, UKenar, Alan, Cevre;

            KKenar = Convert.ToInt32(txtDikdortgenKisa.Text);
            UKenar = int.Parse(txtDikdortgenUzun.Text);

            Alan = KKenar * UKenar;
            Cevre = 2 * (KKenar + UKenar);

            lblDikAlan.Text = Alan.ToString();
            lblDikCevre.Text = Cevre.ToString();

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sayi1, Sayi2, Toplam, Carpim, Bolum, Fark;

            Sayi1 = Convert.ToInt32(txtSayi1.Text);
            Sayi2 = Convert.ToInt32(txtSayi2.Text);

            Toplam = Sayi1 + Sayi2;
            Carpim = Sayi1 * Sayi2;
            Bolum = Sayi1 / Sayi2;
            Fark = Sayi1 - Sayi2;

            MessageBox.Show("Toplam: " + Toplam + "\n" + "Fark: " + Fark + "\n" + "Çarpım: " + Carpim + "\n" + "Bölüm: " + Bolum);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Ad, Soyad;
            int Sinav1, Sinav2, Sinav3, Proje;
            double Ort;

            Ad = txtAdi.Text;
            Soyad = txtSoyadi.Text;

            Sinav1 = Convert.ToInt32(txtSinav1.Text);
            Sinav2 = Convert.ToInt32(txtSinav2.Text);
            Sinav3 = Convert.ToInt32(txtSinav3.Text);
            Proje = Convert.ToInt32(txtProje.Text);

            Ort = (Sinav1 + Sinav2 + Sinav3 + Proje) / 4;

            listBox2.Items.Add("Adı: " + Ad);
            listBox2.Items.Add("Soyadı: "+ Soyad);
            if (Ort>=50) 
            {
                listBox2.Items.Add("Geçme Notunuz: " + Ort);
            }
            else 
            {
                listBox2.Items.Add("Kalma Notunuz: " + Ort);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ders;
            Ders = txtKarakter.Text;

            if (Ders == "Türkçe" || Ders == "TÜRKÇE"  || Ders == "türkçe")
            {
                lblDersKod.Text = "T";
            }
            else if (Ders == "Matematik" || Ders == "MATEMATİK"  || Ders == "matematik")
            {
                lblDersKod.Text = "M";
            }
            else if (Ders == "Fizik" || Ders == "FİZİK" || Ders == "fizik")
            {
                lblDersKod.Text = "F";
            }
            else if (Ders == "Kimya" || Ders == "KİMYA" || Ders == "kimya")
            {
                lblDersKod.Text = "K";
            }
            else if (Ders == "Biyoloji" || Ders == "BİYOLOJİ" || Ders == "biyoloji")
            {
                lblDersKod.Text = "B";
            }
            else
            {
                lblDersKod.Text = "Hatalı veya Eksik Ders İsmi.!";
            }
        }
    }
}
