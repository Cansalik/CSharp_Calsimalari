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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                FrmOgrenciNotlar FrmON = new FrmOgrenciNotlar();

                if (textBox1.Text != "")
                {
                    FrmON.No = textBox1.Text; 
                    FrmON.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen Öğrenci Nuamranızı Aşağıdaki Alana Giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmYetkiliOgretmen FrmYOgr = new FrmYetkiliOgretmen();
            FrmYOgr.Show();
            this.Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
