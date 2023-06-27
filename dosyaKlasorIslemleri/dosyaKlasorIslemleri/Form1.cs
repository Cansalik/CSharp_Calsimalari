using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dosyaKlasorIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }


        string dosyaAdi, dosyaYolu;
        StreamWriter Sw;

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            dosyaAdi = txtDosyaAd.Text;
            Sw = File.CreateText(dosyaYolu + "\\" + dosyaAdi + ".txt");
            Sw.Close();
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                StreamReader Sr = new StreamReader(openFileDialog1.FileName);
                string satir = Sr.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = Sr.ReadLine();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları|*.txt";
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Kayıt Oluşturuldu");
        }

        private void btnYolSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog2.SelectedPath.ToString();
                txtDosyaYol.Text = dosyaYolu;
                
            }
        }
    }
}
