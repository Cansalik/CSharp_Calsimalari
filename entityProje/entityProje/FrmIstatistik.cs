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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        Db_EntityUrunEntities db = new Db_EntityUrunEntities();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblKategoriSayisi.Text = db.Tbl_Kategori.Count().ToString();
            lblToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lblAktifMusteri.Text = db.Tbl_Musteri.Count(X=>X.DURUM == true).ToString();
            lblPasifMusteri.Text = db.Tbl_Musteri.Count(X=>X.DURUM == false).ToString();
            lblToplamStok.Text = db.Tbl_Urun.Sum(X => X.STOK).ToString();
            lblEnPahalıUrun.Text = (from x in db.Tbl_Urun orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            lblEnucuzUrun.Text = (from x in db.Tbl_Urun orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            lblKasaToplam.Text = db.Tbl_Satis.Sum(X => X.FIYAT) + " TL";
            lblBeyazEsyaSayisi.Text = db.Tbl_Urun.Count(x => x.KATEGORİ == 1).ToString();
            lblToplamBuzdolabı.Text = db.Tbl_Urun.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            lblMusteriSehirSayisi.Text = (from x in db.Tbl_Musteri select x.SEHIR).Distinct().Count().ToString();
            lblMaxMarka.Text = db.MarkaGetir().FirstOrDefault();
        }
        int M;
        int Mouse_X;
        int Mouse_Y;
        private void panel13_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            if (M== 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel13_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            M = 0;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (M == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            M = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
    }
}
