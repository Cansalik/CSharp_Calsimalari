using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdbTum.Checked == true)
            {
                int X = Convert.ToInt32(txtX.Text);
                int Y = Convert.ToInt32(txtY.Text);

                int T = 0;

                for (int i = X; i <= Y; i++)
                {
                    T = T + i;
                }

                lblSonuc.Text = T.ToString();
            }
            else if (rdbCift.Checked == true)
            {
                int X = Convert.ToInt32(txtX.Text);
                int Y = Convert.ToInt32(txtY.Text);

                int T = 0;

                for (int i = X; i <= Y; i++)
                {
                    if (i%2==0)
                    {
                        T = T + i;

                    }
                }
                lblSonuc.Text = T.ToString();
            }
            else if (rdbTek.Checked==true)
            {
                int X = Convert.ToInt32(txtX.Text);
                int Y = Convert.ToInt32(txtY.Text);

                int T = 0;

                for (int i = X; i <= Y; i++)
                {
                    if (i % 2 != 0)
                    {
                        T = T + i;
                    }
                }
                lblSonuc.Text = T.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen İşlem Türünü Belirtin.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(txtFaktoriyel.Text);
            int Fak=1;

            for (int i = 1; i <=X ; i++)
            {
                Fak = Fak * i;
            }
            lblFakSonuc.Text = Fak.ToString();
        }


        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int Sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sayac++;
            label6.Text = Sayac.ToString();


            if (Sayac == 5)
            {
                pcbNull.Visible = false;
                pcbRed.Visible = true;
            }
            else if (Sayac == 35)
            {
                pcbRed.Visible = false;
                pcbYellow.Visible = true;
            }
            else if (Sayac == 50)
            {
                pcbYellow.Visible = false;
                pcbGreen.Visible = true;
            }
            else if (Sayac == 85)
            {
                pcbGreen.Visible = false;
                pcbNull.Visible = true;
                Sayac = 4;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbRed.Visible = false;
            pcbYellow.Visible = false;
            pcbGreen.Visible = false;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int Saat = 0, Dakika = 0, Saniye = 0, Salise = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            Salise++;
            lblSalise.Text = Salise.ToString();
            if (Salise == 10)
            {
                Saniye++;
                progressBar1.Value = Saniye;
                lblSaniye.Text = Saniye.ToString();
                Salise = 0;
                if (Saniye == 60)
                {
                    Dakika++;
                    lblDakika.Text = Dakika.ToString();
                    Saniye = 0;
                    if (Dakika == 60)
                    {
                        Saat++;
                        lblSaat.Text = Saat.ToString();
                        Dakika = 0;
                    }
                }
            }
    
        }
    }
}
