using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityProje
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKtgrIslelm_Click(object sender, EventArgs e)
        {
            FrmKategori fr = new FrmKategori();
            fr.Show();
        }

        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            FrmUrun Fr = new FrmUrun();
            Fr.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik Fr = new FrmIstatistik();
            Fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int M;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }
    }
}
