using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucusRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: "+ comboBox1.Text + " - "+ comboBox2.Text);
            listBox1.Items.Add("Tarih ve Saat: " + maskedTextBox4.Text + " - " + maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Adı ve Soyadı: " + textBox1.Text);
            listBox1.Items.Add("Yolcu T.C. Kimlik No: " + maskedTextBox2.Text);
            listBox1.Items.Add("Yolcu Telefon No: " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Kopru,Kopru2;

            Kopru =  comboBox1.Text;
            Kopru2 = comboBox2.Text;

            comboBox2.Text = Kopru;
            comboBox1.Text = Kopru2;
        }
    }
}
