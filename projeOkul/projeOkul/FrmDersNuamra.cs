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
    public partial class FrmDersNuamra : Form
    {
        public FrmDersNuamra()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void FrmDersNuamra_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar FrmSN = new FrmSinavNotlar();
            FrmSN.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesiAra(byte.Parse(txtAra.Text));
        }
    }
}
