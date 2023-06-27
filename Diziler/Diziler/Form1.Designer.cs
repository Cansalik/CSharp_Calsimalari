
namespace Diziler
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSayi = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.rdbTum = new System.Windows.Forms.RadioButton();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnForech = new System.Windows.Forms.Button();
            this.btnForeachInt = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(14, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 130);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İller\'i Listeleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSayi2);
            this.groupBox2.Controls.Add(this.txtSayi1);
            this.groupBox2.Controls.Add(this.rdbTum);
            this.groupBox2.Controls.Add(this.rdbCift);
            this.groupBox2.Controls.Add(this.rdbTek);
            this.groupBox2.Controls.Add(this.btnSayi);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(245, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 198);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sayı Listeleme";
            // 
            // btnSayi
            // 
            this.btnSayi.Location = new System.Drawing.Point(14, 160);
            this.btnSayi.Name = "btnSayi";
            this.btnSayi.Size = new System.Drawing.Size(107, 29);
            this.btnSayi.TabIndex = 0;
            this.btnSayi.Text = "Yazdır";
            this.btnSayi.UseVisualStyleBackColor = true;
            this.btnSayi.Click += new System.EventHandler(this.btnSayi_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(14, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(107, 130);
            this.listBox2.TabIndex = 2;
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Location = new System.Drawing.Point(163, 160);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(50, 25);
            this.rdbTek.TabIndex = 3;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "Tek";
            this.rdbTek.UseVisualStyleBackColor = true;
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Location = new System.Drawing.Point(163, 94);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(52, 25);
            this.rdbCift.TabIndex = 4;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "Çift";
            this.rdbCift.UseVisualStyleBackColor = true;
            // 
            // rdbTum
            // 
            this.rdbTum.AutoSize = true;
            this.rdbTum.Location = new System.Drawing.Point(163, 129);
            this.rdbTum.Name = "rdbTum";
            this.rdbTum.Size = new System.Drawing.Size(59, 25);
            this.rdbTum.TabIndex = 5;
            this.rdbTum.TabStop = true;
            this.rdbTum.Text = "Tüm";
            this.rdbTum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbTum.UseVisualStyleBackColor = true;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(252, 24);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(29, 29);
            this.txtSayi1.TabIndex = 6;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(252, 59);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(29, 29);
            this.txtSayi2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Başlangıç Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bitiş Sayısı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCevap);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listBox4);
            this.groupBox3.Controls.Add(this.btnForeachInt);
            this.groupBox3.Controls.Add(this.btnForech);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 188);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Foreach";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(14, 28);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(187, 151);
            this.listBox3.TabIndex = 0;
            // 
            // btnForech
            // 
            this.btnForech.Location = new System.Drawing.Point(226, 28);
            this.btnForech.Name = "btnForech";
            this.btnForech.Size = new System.Drawing.Size(84, 28);
            this.btnForech.TabIndex = 1;
            this.btnForech.Text = "Başlat";
            this.btnForech.UseVisualStyleBackColor = true;
            this.btnForech.Click += new System.EventHandler(this.btnForech_Click);
            // 
            // btnForeachInt
            // 
            this.btnForeachInt.Location = new System.Drawing.Point(226, 150);
            this.btnForeachInt.Name = "btnForeachInt";
            this.btnForeachInt.Size = new System.Drawing.Size(84, 28);
            this.btnForeachInt.TabIndex = 2;
            this.btnForeachInt.Text = "Başlat";
            this.btnForeachInt.UseVisualStyleBackColor = true;
            this.btnForeachInt.Click += new System.EventHandler(this.btnForeachInt_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 21;
            this.listBox4.Location = new System.Drawing.Point(333, 28);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(187, 151);
            this.listBox4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ortalama:";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(282, 122);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(28, 21);
            this.lblCevap.TabIndex = 5;
            this.lblCevap.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 416);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSayi;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton rdbTum;
        private System.Windows.Forms.RadioButton rdbCift;
        private System.Windows.Forms.RadioButton rdbTek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnForech;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnForeachInt;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label label3;
    }
}

