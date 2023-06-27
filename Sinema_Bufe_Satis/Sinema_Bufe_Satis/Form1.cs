using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int KasaTutar = 0;


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Misir, Su, Cay, Bilet;
            int MT, ST, CT, BT;
            int KasaToplam;

            Misir = Convert.ToInt32(txtMisir.Text);
            Su = Convert.ToInt32(txtSu.Text);
            Cay = Convert.ToInt32(txtCay.Text);
            Bilet = Convert.ToInt32(txtBilet.Text);

            MT = Misir * 4;
            ST = Su * 1;
            CT = Cay * 2;
            BT = Bilet * 8;

            KasaToplam = MT + ST + CT + BT;

            lblKasaToplam.Text = KasaToplam + " TL";

            KasaTutar = KasaTutar + KasaToplam;

            lblGenelToplam.Text = KasaTutar + " TL";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMisir.Text = "";
            txtSu.Text = "";
            txtCay.Text = "";
            txtBilet.Text = "";
            lblKasaToplam.Text = "00 TL";
            txtMisir.Focus();
        }
    }
}
