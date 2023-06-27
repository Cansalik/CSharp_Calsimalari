using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;
using DataAccessLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void listele()
        {
            dataGridView1.DataSource = LogicPersonel.LLPersonelListesi();
        }

        private void brnListele_Click(object sender, EventArgs e)
        {
            /* ----FARKLI BİR YÖNTEM
             List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
            */
            dataGridView1.DataSource = LogicPersonel.LLPersonelListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sehir = cmbSehir.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            ent.Gorev = txtGorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(txtId.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Secilen = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtId.Text = Secilen;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(txtId.Text);
            ent.Ad = txtAd.Text;
            ent.Soyad = txtSoyad.Text;
            ent.Sehir = cmbSehir.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            ent.Gorev = txtGorev.Text;
            LogicPersonel.LLPersonelGuncelle(ent);
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
