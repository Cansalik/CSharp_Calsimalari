
namespace Donguler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTum = new System.Windows.Forms.RadioButton();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFakSonuc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaktoriyel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pcbGreen = new System.Windows.Forms.PictureBox();
            this.pcbYellow = new System.Windows.Forms.PictureBox();
            this.pcbRed = new System.Windows.Forms.PictureBox();
            this.pcbNull = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDurdur = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSalise = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNull)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTum);
            this.groupBox1.Controls.Add(this.rdbCift);
            this.groupBox1.Controls.Add(this.rdbTek);
            this.groupBox1.Controls.Add(this.lblSonuc);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aralıktaki Sayıları Toplama";
            // 
            // rdbTum
            // 
            this.rdbTum.AutoSize = true;
            this.rdbTum.Location = new System.Drawing.Point(102, 106);
            this.rdbTum.Name = "rdbTum";
            this.rdbTum.Size = new System.Drawing.Size(68, 25);
            this.rdbTum.TabIndex = 10;
            this.rdbTum.TabStop = true;
            this.rdbTum.Text = "Tümü";
            this.rdbTum.UseVisualStyleBackColor = true;
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Location = new System.Drawing.Point(177, 106);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(52, 25);
            this.rdbCift.TabIndex = 9;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "Çift";
            this.rdbCift.UseVisualStyleBackColor = true;
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Location = new System.Drawing.Point(46, 106);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(50, 25);
            this.rdbTek.TabIndex = 8;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "Tek";
            this.rdbTek.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(64, 142);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(19, 21);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "0";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(99, 71);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(82, 29);
            this.txtY.TabIndex = 6;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(99, 34);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(82, 29);
            this.txtX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitiş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sonuç:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFakSonuc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFaktoriyel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faktöriyel";
            // 
            // lblFakSonuc
            // 
            this.lblFakSonuc.AutoSize = true;
            this.lblFakSonuc.Location = new System.Drawing.Point(68, 72);
            this.lblFakSonuc.Name = "lblFakSonuc";
            this.lblFakSonuc.Size = new System.Drawing.Size(19, 21);
            this.lblFakSonuc.TabIndex = 7;
            this.lblFakSonuc.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sonuç:";
            // 
            // txtFaktoriyel
            // 
            this.txtFaktoriyel.Location = new System.Drawing.Point(54, 32);
            this.txtFaktoriyel.Name = "txtFaktoriyel";
            this.txtFaktoriyel.Size = new System.Drawing.Size(100, 29);
            this.txtFaktoriyel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDurdur);
            this.groupBox3.Controls.Add(this.pcbGreen);
            this.groupBox3.Controls.Add(this.pcbYellow);
            this.groupBox3.Controls.Add(this.pcbRed);
            this.groupBox3.Controls.Add(this.pcbNull);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnBaslat);
            this.groupBox3.Location = new System.Drawing.Point(308, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 182);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // pcbGreen
            // 
            this.pcbGreen.Image = ((System.Drawing.Image)(resources.GetObject("pcbGreen.Image")));
            this.pcbGreen.Location = new System.Drawing.Point(155, 18);
            this.pcbGreen.Name = "pcbGreen";
            this.pcbGreen.Size = new System.Drawing.Size(87, 145);
            this.pcbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGreen.TabIndex = 5;
            this.pcbGreen.TabStop = false;
            this.pcbGreen.Visible = false;
            // 
            // pcbYellow
            // 
            this.pcbYellow.Image = ((System.Drawing.Image)(resources.GetObject("pcbYellow.Image")));
            this.pcbYellow.Location = new System.Drawing.Point(155, 18);
            this.pcbYellow.Name = "pcbYellow";
            this.pcbYellow.Size = new System.Drawing.Size(87, 145);
            this.pcbYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbYellow.TabIndex = 4;
            this.pcbYellow.TabStop = false;
            // 
            // pcbRed
            // 
            this.pcbRed.Image = ((System.Drawing.Image)(resources.GetObject("pcbRed.Image")));
            this.pcbRed.Location = new System.Drawing.Point(155, 18);
            this.pcbRed.Name = "pcbRed";
            this.pcbRed.Size = new System.Drawing.Size(87, 145);
            this.pcbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRed.TabIndex = 3;
            this.pcbRed.TabStop = false;
            // 
            // pcbNull
            // 
            this.pcbNull.Image = ((System.Drawing.Image)(resources.GetObject("pcbNull.Image")));
            this.pcbNull.Location = new System.Drawing.Point(155, 18);
            this.pcbNull.Name = "pcbNull";
            this.pcbNull.Size = new System.Drawing.Size(87, 145);
            this.pcbNull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNull.TabIndex = 2;
            this.pcbNull.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Timer";
            this.label6.Visible = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(6, 28);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(93, 39);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(6, 74);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(93, 39);
            this.btnDurdur.TabIndex = 6;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Location = new System.Drawing.Point(43, 56);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(19, 21);
            this.lblSalise.TabIndex = 6;
            this.lblSalise.Text = "0";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(68, 39);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(32, 37);
            this.lblSaniye.TabIndex = 7;
            this.lblSaniye.Text = "0";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(132, 39);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(32, 37);
            this.lblDakika.TabIndex = 8;
            this.lblDakika.Text = "0";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(188, 39);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(32, 37);
            this.lblSaat.TabIndex = 9;
            this.lblSaat.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblSalise);
            this.groupBox4.Controls.Add(this.lblSaniye);
            this.groupBox4.Controls.Add(this.lblSaat);
            this.groupBox4.Controls.Add(this.lblDakika);
            this.groupBox4.Location = new System.Drawing.Point(295, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 111);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Saniye:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dakika:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Saat:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 82);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(255, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 315);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNull)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbCift;
        private System.Windows.Forms.RadioButton rdbTek;
        private System.Windows.Forms.RadioButton rdbTum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFaktoriyel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFakSonuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbGreen;
        private System.Windows.Forms.PictureBox pcbYellow;
        private System.Windows.Forms.PictureBox pcbRed;
        private System.Windows.Forms.PictureBox pcbNull;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

