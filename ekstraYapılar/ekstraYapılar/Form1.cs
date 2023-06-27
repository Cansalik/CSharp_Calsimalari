using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekstraYapılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int S1,S2,S3;
            S1 = rnd.Next(1,11);
            S2 = rnd.Next(9, 20);
            S3 = rnd.Next(19, 30);
            lblRndm.Text = S1.ToString();
            lblRndm2.Text = S2.ToString();
            lblRndm3.Text = S3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int S1, S2, S3, S4, S5, S6;
            Random rst = new Random();

            S1 = rst.Next(0,10);
            S2 = rst.Next(0, 10);
            S3 = rst.Next(0, 10);
            S4 = rst.Next(0, 10);
            S5 = rst.Next(0, 10);
            S6 = rst.Next(0, 10);

            txtS1.Text = S1.ToString();
            txtS2.Text = S2.ToString();
            txtS3.Text = S3.ToString();
            txtS4.Text = S4.ToString();
            txtS5.Text = S5.ToString();
            txtS6.Text = S6.ToString();
        }

        private void btnSayisal_Click(object sender, EventArgs e)
        {
            int S1, S2, S3, S4, S5, S6;
            Random say = new Random();

            S1 = say.Next(0, 6);
            S2 = say.Next(0, 6);
            S3 = say.Next(0, 6);
            S4 = say.Next(0, 6);

            label13.Text = S1.ToString();
            label12.Text = S2.ToString();
            label11.Text = S3.ToString();
            label10.Text = S4.ToString();

            //Sayı 1
            if (txtSayisal1.Text == label13.Text)
            {
                txtSayisal1.BackColor = Color.Green;
            }
            else
            {
                txtSayisal1.BackColor = Color.Red;
            }

            //Sayı 2
            if (txtSayisal2.Text == label12.Text)
            {
                txtSayisal2.BackColor = Color.Green;
            }
            else
            {
                txtSayisal2.BackColor = Color.Red;
            }

            //Sayı 3
            if (txtSayisal3.Text == label11.Text)
            {
                txtSayisal3.BackColor = Color.Green;
            }
            else
            {
                txtSayisal3.BackColor = Color.Red;
            }

            //Sayı 4
            if (txtSayisal4.Text == label10.Text)
            {
                txtSayisal4.BackColor = Color.Green;
            }
            else
            {
                txtSayisal4.BackColor = Color.Red;
            }
        }

        private void btnDogrulama_Click(object sender, EventArgs e)
        {


            if (txtDogrulama.Text == label18.Text)
            {
                MessageBox.Show("Başarılı.");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin.!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l", "m" };
            string[] Sembol2 = { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M" };
            string[] Sembol3 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Random r = new Random();

            int S1, S2, S3, S4, S5, S6;

            S1 = r.Next(0, Sembol1.Length);
            S2 = r.Next(0, Sembol2.Length);
            S3 = r.Next(0, Sembol3.Length);
            S4 = r.Next(0, Sembol1.Length);
            S5 = r.Next(0, Sembol2.Length);
            S6 = r.Next(0, Sembol3.Length);
            label18.Text = Sembol1[S1].ToString() + Sembol2[S2].ToString() + Sembol3[S3].ToString() + Sembol1[S4].ToString() + Sembol2[S5].ToString() + Sembol3[S6].ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            string[] Sembol1 = {"a","b","c","d","e","f","g","h","j","k","l","m"};
            string[] Sembol2 = { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L","M"};
            string[] Sembol3 = {"0","1","2","3","4","5","6","7","8","9"};

            Random r = new Random();

            int S1, S2, S3,S4,S5,S6;

            S1 = r.Next(0, Sembol1.Length);
            S2 = r.Next(0, Sembol2.Length);
            S3 = r.Next(0, Sembol3.Length);
            S4 = r.Next(0, Sembol1.Length);
            S5 = r.Next(0, Sembol2.Length);
            S6 = r.Next(0, Sembol3.Length);
            label18.Text = Sembol1[S1].ToString() + Sembol2[S2].ToString() + Sembol3[S3].ToString() + Sembol1[S4].ToString() + Sembol2[S5].ToString() + Sembol3[S6].ToString();

        }

        private void btbPoint_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            int X, Y;
            Random rnd = new Random();

            X = rnd.Next(25,480);
            Y = rnd.Next(25,85);

            konum.X = X;
            konum.Y = Y;

            pictureBox2.Location = konum;
        }


        enum Sehirler {X,ADANA, ADIYAMAN, AFYONKARAHİSAR, AĞRI, AMASYA, ANKARA, ANTALYA, ARTVİN, AYDIN, BALIKESİR, BİLECİK, BİNGÖL, BİTLİS, BOLU, BURDUR, BURSA, ÇANAKKALE, ÇANKIRI, ÇORUM, DENİZLİ, DİYARBAKIR, EDİRNE, ELAZIĞ, ERZİNCAN, ERZURUM, ESKİŞEHİR, GAZİANTEP, GİRESUN, GÜMÜŞHANE, HAKKARİ, HATAY, ISPARTA, MERSİN, İSTANBUL, İZMİR, KARS, KASTAMONU, KAYSERİ, KIRKLARELİ, KIRŞEHİR, KOCAELİ, KONYA, KÜTAHYA, MALATYA, MANİSA, KAHRAMANMARAŞ, MARDİN, MUĞLA, MUŞ, NEVŞEHİR, NİĞDE, ORDU, RİZE, SAKARYA, SAMSUN, SİİRT, SİNOP, SİVAS, TEKİRDAĞ, TOKAT, TRABZON, TUNCELİ, ŞANLIURFA, UŞAK, VAN, YOZGAT, ZONGULDAK, AKSARAY, BAYBURT, KARAMAN, KIRIKKALE, BATMAN, ŞIRNAK, BARTIN, ARDAHAN, IĞDIR, YALOVA, KARABÜK, KİLİS, OSMANİYE, DÜZCE}

        private void btnPlaka_Click(object sender, EventArgs e)
        {
            int Plaka = Convert.ToInt32(txtPlaka.Text);

            Sehirler s;
            s = (Sehirler)Plaka;
            lblSehir.Text = s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Sayi = Convert.ToDouble(txtMutlak.Text);
            lblMutlak.Text = Math.Abs(Sayi).ToString();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            double Sayi = Convert.ToDouble(txtUst.Text);
            lblUstYakın.Text = Math.Ceiling(Sayi).ToString();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            double Sayi = Convert.ToDouble(txtAlt.Text);
            lblAlt.Text = Math.Floor(Sayi).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Sayi = Convert.ToInt32(txtUsSayi.Text);
            int Kuvvet = Convert.ToInt32(txtKuvvet.Text);

            lblUs.Text = Math.Pow(Sayi, Kuvvet).ToString();
        }

        private void btnKok_Click(object sender, EventArgs e)
        {
            int Sayi = Convert.ToInt32(txtKok.Text);
            lblKok.Text = Math.Sqrt(Sayi).ToString();
        }
    }
}
/*
 * ABS = Mutlak
 * Ceil = Üst'e Yuvarlama
 * Floor = Alt'a Yuvarlama
 * Pow = Üs Alma
 * SQRT = Kök Alma
 */