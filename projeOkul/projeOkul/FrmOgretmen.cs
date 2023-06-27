using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeOkul
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 Fr = new Form1();
            Fr.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            FrmDersler FrmD = new FrmDersler();
            FrmD.Show();
            this.Hide();
        }

        private void btnKulup_Click(object sender, EventArgs e)
        {
            FrmKulup FrmK = new FrmKulup();
            FrmK.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci FrOgr = new FrmOgrenci();
            FrOgr.Show();
            this.Hide();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void btnSinav_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar FrmS = new FrmSinavNotlar();
            FrmS.Show();
        }
    }
}
