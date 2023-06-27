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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        Db_EntityUrunEntities db = new Db_EntityUrunEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var Sorgu = from x in db.Tbl_Admin where x.KullanıcıAdi == txtKAdi.Text && x.Sifre == txtSifre.Text select x;
            if (Sorgu.Any())
            {
                FrmAnaForm Fr = new FrmAnaForm();
                Fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı bilgileri!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
                pcrGorunur.Visible = true;
                pcrGizli.Visible = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                
                pcrGizli.Visible = true;
                pcrGorunur.Visible = false;
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            pcrGizli.Visible = true;
            pcrGorunur.Visible = false;
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

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
    }
}
