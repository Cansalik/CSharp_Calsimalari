using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pastaPisirmeİslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value%20==10)
            {
                label1.ForeColor = Color.Red;
            }
            if (progressBar1.Value % 20 == 0)
            {
               label1.ForeColor = Color.White;
                if (progressBar1.Value == 100)
                {
                    label1.Text = "Un ve Yumurta Karıştırıldı...";
                }
            }
            if (progressBar1.Value ==100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            progressBar2.Value += 10;
            if (progressBar2.Value % 20 == 10)
            {
                label2.ForeColor = Color.Red;
            }
            if (progressBar2.Value % 20 == 0)
            {
                label2.ForeColor = Color.White;
                if (progressBar2.Value == 100)
                {
                    label2.Text = "Çırpma İşlemi Yapıldı..";
                }
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 10)
            {
                label3.ForeColor = Color.Red;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.ForeColor = Color.White;
                if (progressBar3.Value == 100)
                {
                    label3.Text = "Malzemeler Eklendi ve Karıştırıldı..";
                }
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;
            if (progressBar4.Value % 20 == 10)
            {
                label4.ForeColor = Color.Red;
            }
            if (progressBar4.Value % 20 == 0)
            {
                label4.ForeColor = Color.White;
                if (progressBar4.Value == 100)
                {
                    label4.Text = "Pasta Pişti.";
                }
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
