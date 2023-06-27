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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.Renk = "Mavi";
            rb.Hiz = 160;
            rb.Motor = 1245.56;
            rb.Fiyat = 50000;
            rb.Durum = 'S';
            rb.YIL = -2541;
            rb.Markasi = "VW Jetta";
            rb.Plaka = "21 SV 738";
            rb.Muayene = 2022;
            rb.Sahip = "Neşet Can Salık";

            lblRenk.Text = rb.Renk;
            lblHiz.Text = rb.Hiz.ToString();
            lblMotor.Text = rb.Motor.ToString();
            lblFiyat.Text = rb.Fiyat.ToString() + " TL";
            lblDurum.Text = rb.Durum.ToString();
            lblYil.Text = rb.YIL.ToString();
            lblMarka.Text = rb.Markasi;
            lblPlaka.Text = rb.Plaka;
            lblMuayene.Text = rb.Muayene.ToString();
            lblSahip.Text = rb.Sahip;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            Form2 Fr = new Form2();
            Fr.Show();
            this.Hide();
        }
    }
}
