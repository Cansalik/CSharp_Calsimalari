using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int soruNo = 0, Dogru = 0, Yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;


            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";

                label4.Text = "1923";
            }
            else if (soruNo == 2)
            {
                richTextBox1.Text = "Diyarbakır ilimiz neyiyle meşhurdur ?";
                btnA.Text = "Kaysı";
                btnB.Text = "Karpuz";
                btnC.Text = "Vişne";
                btnD.Text = "Elma";
                label4.Text = "Karpuz";
            }

            else if (soruNo == 3)
            {
                richTextBox1.Text = "Osmanlı devleti kaç yılında imparatorluk olmuştur ?";
                btnA.Text = "1699";
                btnB.Text = "1442";
                btnC.Text = "1453";
                btnD.Text = "1789";
                label4.Text = "1453";
            }
            else if (soruNo == 4)
            {
                richTextBox1.Text = "Aşağdakilerden hangisi programlama dili değildir ?";
                btnA.Text = "Ruby";
                btnB.Text = "Java";
                btnC.Text = "Go";
                btnD.Text = "Html";
                label4.Text = "Html";
            }
            else if (soruNo == 5)
            {
                richTextBox1.Text = "Hollandanın Başkenti neresidir ?";
                btnA.Text = "Amsterdam";
                btnB.Text = "Prag";
                btnC.Text = "Lima";
                btnD.Text = "Helsinki";
                label4.Text = "Amsterdam";
                btnSonraki.Text = "Sonuçlar.";
            }
            else if (soruNo == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;

                MessageBox.Show("Doğru: "+Dogru+"\n" + "Yanlış: " + Yanlis);
            }
        }
    }
}
