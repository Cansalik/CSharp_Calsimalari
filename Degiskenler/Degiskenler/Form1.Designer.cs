
namespace Degiskenler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbxYas = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDikCevre = new System.Windows.Forms.Label();
            this.lblDikAlan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDikdortgenHesap = new System.Windows.Forms.Button();
            this.txtDikdortgenUzun = new System.Windows.Forms.TextBox();
            this.txtDikdortgenKisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKareCevre = new System.Windows.Forms.Label();
            this.lblKareAlan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKareKenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKareHesap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtKarakter = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDersKod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Location = new System.Drawing.Point(116, 172);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(90, 36);
            this.btnKayit.TabIndex = 1;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(116, 22);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(156, 31);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(116, 96);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(156, 31);
            this.txtMeslek.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(0, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 165);
            this.listBox1.TabIndex = 10;
            // 
            // cmbxCinsiyet
            // 
            this.cmbxCinsiyet.FormattingEnabled = true;
            this.cmbxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diğer"});
            this.cmbxCinsiyet.Location = new System.Drawing.Point(116, 133);
            this.cmbxCinsiyet.Name = "cmbxCinsiyet";
            this.cmbxCinsiyet.Size = new System.Drawing.Size(156, 31);
            this.cmbxCinsiyet.TabIndex = 15;
            // 
            // cmbxYas
            // 
            this.cmbxYas.FormattingEnabled = true;
            this.cmbxYas.Items.AddRange(new object[] {
            "0 - 5",
            "5 - 10",
            "10 - 15",
            "15 - 20 ",
            "20 - 25",
            "25 - 30",
            "30 - 35"});
            this.cmbxYas.Location = new System.Drawing.Point(116, 59);
            this.cmbxYas.Name = "cmbxYas";
            this.cmbxYas.Size = new System.Drawing.Size(156, 31);
            this.cmbxYas.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cinsiyeti";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Mesleği";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Yaşı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Adı Soyadı:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(286, 138);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(0, 23);
            this.lblCinsiyet.TabIndex = 24;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Location = new System.Drawing.Point(286, 101);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(0, 23);
            this.lblMeslek.TabIndex = 23;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(286, 64);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(0, 23);
            this.lblYas.TabIndex = 22;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(286, 25);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 23);
            this.lblAdSoyad.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.lblMeslek);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.lblYas);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.cmbxCinsiyet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbxYas);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 410);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDikCevre);
            this.groupBox2.Controls.Add(this.lblDikAlan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnDikdortgenHesap);
            this.groupBox2.Controls.Add(this.txtDikdortgenUzun);
            this.groupBox2.Controls.Add(this.txtDikdortgenKisa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblKareCevre);
            this.groupBox2.Controls.Add(this.lblKareAlan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtKareKenar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnKareHesap);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(444, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 410);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İnteger";
            // 
            // lblDikCevre
            // 
            this.lblDikCevre.AutoSize = true;
            this.lblDikCevre.Location = new System.Drawing.Point(233, 297);
            this.lblDikCevre.Name = "lblDikCevre";
            this.lblDikCevre.Size = new System.Drawing.Size(0, 23);
            this.lblDikCevre.TabIndex = 38;
            // 
            // lblDikAlan
            // 
            this.lblDikAlan.AutoSize = true;
            this.lblDikAlan.Location = new System.Drawing.Point(81, 292);
            this.lblDikAlan.Name = "lblDikAlan";
            this.lblDikAlan.Size = new System.Drawing.Size(0, 23);
            this.lblDikAlan.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Çevre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 35;
            this.label13.Text = "Alan:";
            // 
            // btnDikdortgenHesap
            // 
            this.btnDikdortgenHesap.Location = new System.Drawing.Point(41, 344);
            this.btnDikdortgenHesap.Name = "btnDikdortgenHesap";
            this.btnDikdortgenHesap.Size = new System.Drawing.Size(203, 44);
            this.btnDikdortgenHesap.TabIndex = 34;
            this.btnDikdortgenHesap.Text = "Dikdörtgen Hesapla";
            this.btnDikdortgenHesap.UseVisualStyleBackColor = true;
            this.btnDikdortgenHesap.Click += new System.EventHandler(this.btnDikdortgenHesap_Click);
            // 
            // txtDikdortgenUzun
            // 
            this.txtDikdortgenUzun.Location = new System.Drawing.Point(233, 239);
            this.txtDikdortgenUzun.Name = "txtDikdortgenUzun";
            this.txtDikdortgenUzun.Size = new System.Drawing.Size(93, 31);
            this.txtDikdortgenUzun.TabIndex = 33;
            // 
            // txtDikdortgenKisa
            // 
            this.txtDikdortgenKisa.Location = new System.Drawing.Point(233, 201);
            this.txtDikdortgenKisa.Name = "txtDikdortgenKisa";
            this.txtDikdortgenKisa.Size = new System.Drawing.Size(93, 31);
            this.txtDikdortgenKisa.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Dikdörtegen Uzun Kenar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dikdörtegen Kısa Kenar:";
            // 
            // lblKareCevre
            // 
            this.lblKareCevre.AutoSize = true;
            this.lblKareCevre.Location = new System.Drawing.Point(236, 67);
            this.lblKareCevre.Name = "lblKareCevre";
            this.lblKareCevre.Size = new System.Drawing.Size(0, 23);
            this.lblKareCevre.TabIndex = 29;
            // 
            // lblKareAlan
            // 
            this.lblKareAlan.AutoSize = true;
            this.lblKareAlan.Location = new System.Drawing.Point(84, 62);
            this.lblKareAlan.Name = "lblKareAlan";
            this.lblKareAlan.Size = new System.Drawing.Size(0, 23);
            this.lblKareAlan.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Çevre:";
            // 
            // txtKareKenar
            // 
            this.txtKareKenar.Location = new System.Drawing.Point(175, 22);
            this.txtKareKenar.Name = "txtKareKenar";
            this.txtKareKenar.Size = new System.Drawing.Size(110, 31);
            this.txtKareKenar.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Karenin Bir Kenarı:";
            // 
            // btnKareHesap
            // 
            this.btnKareHesap.Location = new System.Drawing.Point(88, 96);
            this.btnKareHesap.Name = "btnKareHesap";
            this.btnKareHesap.Size = new System.Drawing.Size(156, 44);
            this.btnKareHesap.TabIndex = 1;
            this.btnKareHesap.Text = "Kare Hesapla";
            this.btnKareHesap.UseVisualStyleBackColor = true;
            this.btnKareHesap.Click += new System.EventHandler(this.btnKareHesap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alan:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(81, 27);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(109, 31);
            this.txtSayi1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sayı 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sayı 2:";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(82, 69);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(109, 31);
            this.txtSayi2.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.txtSayi2);
            this.groupBox3.Controls.Add(this.txtSayi1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(793, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 115);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4 İşlem Hesaplama";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(212, 46);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(99, 33);
            this.btnHesapla.TabIndex = 31;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSinav3);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Controls.Add(this.txtProje);
            this.groupBox4.Controls.Add(this.txtSinav2);
            this.groupBox4.Controls.Add(this.txtSinav1);
            this.groupBox4.Controls.Add(this.txtSoyadi);
            this.groupBox4.Controls.Add(this.txtAdi);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(793, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 286);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Double";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Soyad:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Sınav 1:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 23);
            this.label18.TabIndex = 4;
            this.label18.Text = "Proje:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(151, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 23);
            this.label19.TabIndex = 5;
            this.label19.Text = "Sınav 2:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(103, 25);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(119, 31);
            this.txtAdi.TabIndex = 6;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(103, 58);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(119, 31);
            this.txtSoyadi.TabIndex = 7;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(103, 91);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(40, 31);
            this.txtSinav1.TabIndex = 8;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(228, 91);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(40, 31);
            this.txtSinav2.TabIndex = 9;
            // 
            // txtProje
            // 
            this.txtProje.Location = new System.Drawing.Point(103, 124);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(40, 31);
            this.txtProje.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(9, 166);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(336, 119);
            this.listBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(151, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 23);
            this.label17.TabIndex = 13;
            this.label17.Text = "Sınav 3:";
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(227, 124);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(40, 31);
            this.txtSinav3.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDersKod);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtKarakter);
            this.groupBox5.Location = new System.Drawing.Point(1162, -1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 164);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Char";
            // 
            // txtKarakter
            // 
            this.txtKarakter.Location = new System.Drawing.Point(95, 24);
            this.txtKarakter.Name = "txtKarakter";
            this.txtKarakter.Size = new System.Drawing.Size(169, 31);
            this.txtKarakter.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 23);
            this.label20.TabIndex = 1;
            this.label20.Text = "Ders Adı:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dönüştür";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 23);
            this.label21.TabIndex = 3;
            this.label21.Text = "Ders Kodu:";
            // 
            // lblDersKod
            // 
            this.lblDersKod.AutoSize = true;
            this.lblDersKod.Location = new System.Drawing.Point(108, 124);
            this.lblDersKod.Name = "lblDersKod";
            this.lblDersKod.Size = new System.Drawing.Size(0, 23);
            this.lblDersKod.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1170, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1510, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbxCinsiyet;
        private System.Windows.Forms.ComboBox cmbxYas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKareHesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKareKenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKareCevre;
        private System.Windows.Forms.Label lblKareAlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDikdortgenUzun;
        private System.Windows.Forms.TextBox txtDikdortgenKisa;
        private System.Windows.Forms.Button btnDikdortgenHesap;
        private System.Windows.Forms.Label lblDikCevre;
        private System.Windows.Forms.Label lblDikAlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKarakter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblDersKod;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

