using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Neşet Can SALIK Tarafından Yapılmıştır.","Hakkımızda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            lblAdi.Text = "Mad Max: Öfkeli Yollar";
            lblBasrol.Text = "Tom HARDY, Charlize THERON";
            lblIMDb.Text = "8.1 / 10";
            lblYapimci.Text = "Warner Bros";
            lblYonetmen.Text = "George Miller";
        }

        private void psILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
            lblAdi.Text = "Not: Seni Seviyorum";
            lblBasrol.Text = "Hilary SWANK, Gerard BUTLER";
            lblIMDb.Text = "7.0 / 10";
            lblYapimci.Text = "Warner Bros";
            lblYonetmen.Text = "Richard LaGravenese";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XwcxcNkLSGE");
            lblAdi.Text = "Korku Seansı";
            lblBasrol.Text = "Patrick Wilson, Vera Farmiga";
            lblIMDb.Text = "7.5 / 10";
            lblYapimci.Text = "New Line Cinema";
            lblYonetmen.Text = "James Wan";
            lblYonetmen2.Text = "James Wan Adlı Yönetmenin Filmleri ve IMDb Puanları.";
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 1", 6.8);
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 2", 5.8);
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 3", 7.4);
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 4", 6.9);
            chart1.Series["Filmleri"].Points.AddXY("Korku Seansı 1", 5.9);
            chart1.Series["Filmleri"].Points.AddXY("Korku Seansı 2", 4.9);
            chart1.Series["Filmleri"].Points.AddXY("Korku Seansı 3", 8.9);
        }

        private void ruhlarBölgesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=QRJvCdCfNzc");
            lblAdi.Text = "Ruhlar Bölgesi";
            lblBasrol.Text = "Patrick Wilson, Rose Byrne";
            lblIMDb.Text = "6.8 / 10";
            lblYapimci.Text = "New Line Cinema";
            lblYonetmen.Text = "James Wan";
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 1",6.8);
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 2", 5.8);
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 3", 7.4);
            chart1.Series["Filmleri"].Points.AddXY("Ruhlar Bölgesi 4", 6.9);
            chart1.Series["Filmleri"].Points.AddXY("Korku Seansı 1", 5.9);
            chart1.Series["Filmleri"].Points.AddXY("Korku Seansı 2", 4.9);
            chart1.Series["Filmleri"].Points.AddXY("Korku Seansı 3", 8.9);
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7BWWWQzTpNU");
            lblAdi.Text = "Uzay Yolcuları";
            lblBasrol.Text = "Jennifer Lawrence, Chris Pratt";
            lblIMDb.Text = "7.0 / 10";
            lblYapimci.Text = "Sony Pictures Releasing";
            lblYonetmen.Text = "Morten Tyldum";
        }

        private void starTrekUzayYoluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=pKFUZ10Wmbw");
            lblAdi.Text = "Uzay Yolu: Bilinmeze Doğru";
            lblBasrol.Text = "Chris Pine, Benedict Cumberbatch";
            lblIMDb.Text = "7.7 / 10";
            lblYapimci.Text = "Paramount Pictures";
            lblYonetmen.Text = "J. J. Abrams";

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void maviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Neşet Can SALIK Tarafından Yapılmıştır.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
