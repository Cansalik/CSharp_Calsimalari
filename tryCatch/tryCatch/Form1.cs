using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //TRY bloğu ve FINALLY bloğu beraber çalışırlar.
                int S1 = Convert.ToInt32(txtS1.Text);
                int S2 = Convert.ToInt32(txtS2.Text);
                int Toplam = S1 * S2;
                lblSonuc.Text = Toplam.ToString();
            }
            catch (Exception)
            {
                //Hata varsa sadece CATCH bloğu çalışır.
                MessageBox.Show("Hata var CATCH bloğu çalıştı.");
            }
            finally
            {   
                //TRY bloğu ve FINALLY bloğu beraber çalışırlar.
                MessageBox.Show("Finally bloğu çalıştı.");
            }
        }
    }
}
