using System;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Sehirler = {"Ankara","Adana","Antalya","Diyarbakır","Balıkesir","İstanbul","Manisa","Batman"};

            for (int i = 0; i < Sehirler.Length; i++)
            {
                listBox1.Items.Add(Sehirler[i]);
            }
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            int S1 = Convert.ToInt32(txtSayi1.Text);
            int S2 = Convert.ToInt32(txtSayi2.Text);
            int U = S2 - S1;
            int[] Eklenen = new int[U];

            if (rdbCift.Checked == true)
           {
                listBox2.Items.Clear();
                do
                {
                    for (int i = 0; i < Eklenen.Length; i++)
                    {
                        Eklenen[0] = S1;
                        S1++;
                        if (Eklenen[0]%2==0)
                        {
                            listBox2.Items.Add(Eklenen[0]);
                        }
                    }

                } while (S1 < S2);

            }
            else if (rdbTek.Checked == true)
            {
                listBox2.Items.Clear();
                do
                {
                    for (int i = 0; i < Eklenen.Length; i++)
                    {
                        Eklenen[0] = S1;
                        S1++;
                        if (Eklenen[0] % 2 != 0)
                        {
                            listBox2.Items.Add(Eklenen[0]);
                        }
                    }

                } while (S1 < S2);
            }
            else if (rdbTum.Checked == true)
            {
                listBox2.Items.Clear();
                do
                {
                    for (int i = 0; i < Eklenen.Length; i++)
                    {
                        Eklenen[0] = S1;
                        S1++;
                        listBox2.Items.Add(Eklenen[0]);
                    }

                } while (S1 < S2);
            }
            else
            {
                MessageBox.Show("Lütfen Sayı Türünü Seçiniz.!");
            }
        }

        private void btnForech_Click(object sender, EventArgs e)
        {
            string[] kisiler = {"Ali","Ahmet","Mehmet","Neşet","Ömer","Musa","Regaip","Hasan","Hüseyin" };

            foreach (string K in kisiler)
            {
                listBox3.Items.Add(K);
            }
        }

        private void btnForeachInt_Click(object sender, EventArgs e)
        {
            int[] Sinavlar = { 70, 65, 80, 100, 90 };
            int Toplam = 0,Ort;

            foreach  (int S in Sinavlar)
            {
                listBox4.Items.Add(S);

                Toplam = Toplam + S;
            }
            Ort = Toplam / Sinavlar.Length;
            lblCevap.Text = Ort.ToString();
        }
    }
}
