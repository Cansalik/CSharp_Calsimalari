using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapiları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S1 = Convert.ToDouble(txtSinav1.Text);
            double S2 = Convert.ToDouble(txtSinav2.Text);
            double P = Convert.ToDouble(txtProje.Text);

            double Ort = (S1 + S2 + P) / 3;

            if (Ort >= 50)
            {
                lblSonuc.Text = Ort.ToString("0.00") + "  İle Geçtiniz.";
            }
            else
            {
                lblSonuc.Text = Ort.ToString("0.00") + "  İle Kaldınız.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double KitapAded = Convert.ToDouble(txtKitapAded.Text);
            double Odenen;
            double Fiyat = 8;

            if (KitapAded > 0 && KitapAded <= 20)
            {
                Odenen = Fiyat * KitapAded * 0.8;
                lblOdenecek.Text = Odenen.ToString("0.0") + " TL'dir.";
            }
            else if (KitapAded >= 21 && KitapAded <= 40)
            {
                Odenen = Fiyat * KitapAded * 0.6;
                lblOdenecek.Text = Odenen.ToString("0.0") + " TL'dir.";
            }
            else if (KitapAded >= 41)
            {
                Odenen = Fiyat * KitapAded * 0.5;
                lblOdenecek.Text = Odenen.ToString("0.0") + " TL'dir.";
            }
            else
            {
                MessageBox.Show("Negatif veya 0 Değer Girdiniz", MessageBoxIcon.Warning.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Ay = Convert.ToInt16(txtAy.Text);

            switch (Ay)
            {
                case 1: lblCevap.Text = "Ocak"; break;
                case 2: lblCevap.Text = "Şubat"; break;
                case 3: lblCevap.Text = "Mart"; break;
                case 4: lblCevap.Text = "Nisan"; break;
                case 5: lblCevap.Text = "Mayıs"; break;
                case 6: lblCevap.Text = "Haziran"; break;
                case 7: lblCevap.Text = "Temmuz"; break;
                case 8: lblCevap.Text = "Ağustos"; break;
                case 9: lblCevap.Text = "Eylül"; break;
                case 10: lblCevap.Text = "Ekim"; break;
                case 11: lblCevap.Text = "Kasım"; break;
                case 12: lblCevap.Text = "Aralık"; break;

                default: lblCevap.Text = "Hatalı Giriş."; break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double S1 = Convert.ToDouble(txtSayi1.Text);
            double S2 = Convert.ToDouble(txtSayi2.Text);

            double Toplam, Fark, Bolum, Carpim, Kalan, Kok1, Kok2, Us;

            Toplam = S1 + S2;
            Fark = S1 - S2;
            Bolum = S1 / S2;
            Carpim = S1 * S2;
            Kalan = S1 % S2;
            Kok1 = Math.Sqrt(S1);
            Kok2 = Math.Sqrt(S2);
            Us = Math.Pow(S1, S2);

            char islem = Convert.ToChar(txtIslem.Text);

            switch (islem)
            {
                case  '+':
                    txtSonuc.Text = Toplam.ToString("0.00"); break;
                case '/':
                    txtSonuc.Text = Bolum.ToString("0.00"); break;
                case '*':
                    txtSonuc.Text = Carpim.ToString("0.00"); break;
                case '-':
                    txtSonuc.Text = Fark.ToString("0.00"); break;
                case '%':
                    txtSonuc.Text = Kalan.ToString("0.00"); break;
                case 'K':
                    txtSonuc.Text = Kok1.ToString("0.00"); break;
                case 'J':
                    txtSonuc.Text = Kok2.ToString("0.00"); break;
                case '^':
                    txtSonuc.Text = Us.ToString("0.00"); break;
                default:
                    txtSonuc.Text = "Hatalı İşlem Girişi."; break;
            }


        }
    }
}
