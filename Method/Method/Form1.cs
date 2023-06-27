using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        private void Renkle()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Blue;
            textBox1.Focus();
        }



        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnRenkle_Click(object sender, EventArgs e)
        {
            Renkle();
        }

        int Kup(int S1)
        {
            int S2 = S1 * S1 * S1;
            return(S2);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int Sayi = Convert.ToInt32(txtSayi.Text);
            lblSonuc.Text = Kup(Sayi).ToString();
        }
    }
}
