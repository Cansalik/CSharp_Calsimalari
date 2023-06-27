using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();

            rb2.Renk = "Yeşil";
            rb2.Hiz = 140;
            rb2.Motor = 1220.34;
            rb2.Fiyat = 35850;
            rb2.Durum = 'İ';
            rb2.Markasi = "Audi A8";
            rb2.YIL = -2020;
            rb2.Sahip = "Regaip SALIK";
            rb2.Plaka = "21 SV 438";
            rb2.Muayene = 2022;

            lblRenk.Text = rb2.Renk;
            lblHiz.Text = rb2.Hiz.ToString();
            lblMotor.Text = rb2.Motor.ToString();
            lblFiyat.Text = rb2.Fiyat.ToString() + " TL";
            lblDurum.Text = rb2.Durum.ToString();
            lblMarka.Text = rb2.Markasi;
            lblYil.Text = rb2.YIL.ToString();
            lblPlaka.Text = rb2.Plaka;
            lblSahip.Text = rb2.Sahip;
            lblMuayene.Text = rb2.Muayene.ToString();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            Form1 Fr = new Form1();
            Fr.Show();
            this.Hide();
        }
    }
}
