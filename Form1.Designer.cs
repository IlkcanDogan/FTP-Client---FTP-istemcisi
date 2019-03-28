namespace FTP_Erişme
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
            this.tbSunucu = new System.Windows.Forms.TextBox();
            this.tbK_Adi = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbGoster = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDizin = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbYuklenen_dosya = new System.Windows.Forms.Label();
            this.lbllllll = new System.Windows.Forms.Label();
            this.lbIndirilen_dosya = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.bgCalis = new System.ComponentModel.BackgroundWorker();
            this.groupIndir = new System.Windows.Forms.GroupBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIndirme_Dizini = new System.Windows.Forms.TextBox();
            this.groupYukle = new System.Windows.Forms.GroupBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnDizin_Sec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbYukle = new System.Windows.Forms.TextBox();
            this.bgIndir = new System.ComponentModel.BackgroundWorker();
            this.bgYukle = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupIndir.SuspendLayout();
            this.groupYukle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSunucu
            // 
            this.tbSunucu.Location = new System.Drawing.Point(93, 21);
            this.tbSunucu.Name = "tbSunucu";
            this.tbSunucu.Size = new System.Drawing.Size(235, 20);
            this.tbSunucu.TabIndex = 0;
            // 
            // tbK_Adi
            // 
            this.tbK_Adi.Location = new System.Drawing.Point(93, 47);
            this.tbK_Adi.Name = "tbK_Adi";
            this.tbK_Adi.Size = new System.Drawing.Size(235, 20);
            this.tbK_Adi.TabIndex = 1;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(93, 74);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(235, 20);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(220, 100);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(109, 27);
            this.btnBaglan.TabIndex = 3;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sunucu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbGoster);
            this.groupBox1.Controls.Add(this.tbK_Adi);
            this.groupBox1.Controls.Add(this.tbSunucu);
            this.groupBox1.Controls.Add(this.tbSifre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBaglan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Bağlantısı";
            // 
            // chbGoster
            // 
            this.chbGoster.AutoSize = true;
            this.chbGoster.Location = new System.Drawing.Point(99, 100);
            this.chbGoster.Name = "chbGoster";
            this.chbGoster.Size = new System.Drawing.Size(88, 17);
            this.chbGoster.TabIndex = 11;
            this.chbGoster.Text = "Şifreyi Göster";
            this.chbGoster.UseVisualStyleBackColor = true;
            this.chbGoster.CheckedChanged += new System.EventHandler(this.chbGoster_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDizin);
            this.groupBox2.Location = new System.Drawing.Point(345, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTP Dizin";
            // 
            // lbDizin
            // 
            this.lbDizin.FormattingEnabled = true;
            this.lbDizin.Location = new System.Drawing.Point(3, 14);
            this.lbDizin.Name = "lbDizin";
            this.lbDizin.Size = new System.Drawing.Size(227, 173);
            this.lbDizin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbYuklenen_dosya);
            this.panel1.Controls.Add(this.lbllllll);
            this.panel1.Controls.Add(this.lbIndirilen_dosya);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDurum);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(348, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 98);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbYuklenen_dosya
            // 
            this.lbYuklenen_dosya.AutoSize = true;
            this.lbYuklenen_dosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYuklenen_dosya.ForeColor = System.Drawing.Color.Black;
            this.lbYuklenen_dosya.Location = new System.Drawing.Point(58, 71);
            this.lbYuklenen_dosya.Name = "lbYuklenen_dosya";
            this.lbYuklenen_dosya.Size = new System.Drawing.Size(19, 13);
            this.lbYuklenen_dosya.TabIndex = 30;
            this.lbYuklenen_dosya.Text = "....";
            // 
            // lbllllll
            // 
            this.lbllllll.AutoSize = true;
            this.lbllllll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllllll.ForeColor = System.Drawing.Color.Black;
            this.lbllllll.Location = new System.Drawing.Point(3, 71);
            this.lbllllll.Name = "lbllllll";
            this.lbllllll.Size = new System.Drawing.Size(58, 13);
            this.lbllllll.TabIndex = 29;
            this.lbllllll.Text = "Yüklenen :";
            // 
            // lbIndirilen_dosya
            // 
            this.lbIndirilen_dosya.AutoSize = true;
            this.lbIndirilen_dosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIndirilen_dosya.ForeColor = System.Drawing.Color.Black;
            this.lbIndirilen_dosya.Location = new System.Drawing.Point(49, 37);
            this.lbIndirilen_dosya.Name = "lbIndirilen_dosya";
            this.lbIndirilen_dosya.Size = new System.Drawing.Size(19, 13);
            this.lbIndirilen_dosya.TabIndex = 28;
            this.lbIndirilen_dosya.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "İndirilen :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Durum : ";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(47, 5);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(67, 13);
            this.lblDurum.TabIndex = 24;
            this.lblDurum.Text = "Bağlantı Yok";
            // 
            // bgCalis
            // 
            this.bgCalis.DoWork += new System.ComponentModel.DoWorkEventHandler(this.apcalis_DoWork);
            // 
            // groupIndir
            // 
            this.groupIndir.Controls.Add(this.btnIndir);
            this.groupIndir.Controls.Add(this.button1);
            this.groupIndir.Controls.Add(this.label1);
            this.groupIndir.Controls.Add(this.tbIndirme_Dizini);
            this.groupIndir.Location = new System.Drawing.Point(7, 141);
            this.groupIndir.Name = "groupIndir";
            this.groupIndir.Size = new System.Drawing.Size(334, 78);
            this.groupIndir.TabIndex = 13;
            this.groupIndir.TabStop = false;
            this.groupIndir.Text = "Proje İndir";
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(173, 49);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(155, 23);
            this.btnIndir.TabIndex = 17;
            this.btnIndir.Text = "İndir";
            this.btnIndir.UseVisualStyleBackColor = true;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dizin Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "İndirme Dizini : ";
            // 
            // tbIndirme_Dizini
            // 
            this.tbIndirme_Dizini.Location = new System.Drawing.Point(90, 23);
            this.tbIndirme_Dizini.Name = "tbIndirme_Dizini";
            this.tbIndirme_Dizini.Size = new System.Drawing.Size(238, 20);
            this.tbIndirme_Dizini.TabIndex = 15;
            // 
            // groupYukle
            // 
            this.groupYukle.Controls.Add(this.btnYukle);
            this.groupYukle.Controls.Add(this.btnDizin_Sec);
            this.groupYukle.Controls.Add(this.label6);
            this.groupYukle.Controls.Add(this.tbYukle);
            this.groupYukle.Location = new System.Drawing.Point(7, 225);
            this.groupYukle.Name = "groupYukle";
            this.groupYukle.Size = new System.Drawing.Size(334, 73);
            this.groupYukle.TabIndex = 14;
            this.groupYukle.TabStop = false;
            this.groupYukle.Text = "Proje Yükle";
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(173, 45);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(155, 23);
            this.btnYukle.TabIndex = 21;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnDizin_Sec
            // 
            this.btnDizin_Sec.Location = new System.Drawing.Point(90, 45);
            this.btnDizin_Sec.Name = "btnDizin_Sec";
            this.btnDizin_Sec.Size = new System.Drawing.Size(77, 23);
            this.btnDizin_Sec.TabIndex = 18;
            this.btnDizin_Sec.Text = "Dosya Seç";
            this.btnDizin_Sec.UseVisualStyleBackColor = true;
            this.btnDizin_Sec.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yükleme Dizini : ";
            // 
            // tbYukle
            // 
            this.tbYukle.Location = new System.Drawing.Point(91, 19);
            this.tbYukle.Name = "tbYukle";
            this.tbYukle.Size = new System.Drawing.Size(238, 20);
            this.tbYukle.TabIndex = 19;
            // 
            // bgIndir
            // 
            this.bgIndir.WorkerSupportsCancellation = true;
            this.bgIndir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgIndir_DoWork);
            this.bgIndir.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgIndir_RunWorkerCompleted);
            // 
            // bgYukle
            // 
            this.bgYukle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgYukle_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 306);
            this.Controls.Add(this.groupYukle);
            this.Controls.Add(this.groupIndir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP v1.0 | Kodlayan İlkcan Doğan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupIndir.ResumeLayout(false);
            this.groupIndir.PerformLayout();
            this.groupYukle.ResumeLayout(false);
            this.groupYukle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSunucu;
        private System.Windows.Forms.TextBox tbK_Adi;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbGoster;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgCalis;
        private System.Windows.Forms.ListBox lbDizin;
        private System.Windows.Forms.GroupBox groupIndir;
        private System.Windows.Forms.GroupBox groupYukle;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIndirme_Dizini;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnDizin_Sec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYukle;
        private System.Windows.Forms.Label lbYuklenen_dosya;
        private System.Windows.Forms.Label lbllllll;
        private System.Windows.Forms.Label lbIndirilen_dosya;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDurum;
        private System.ComponentModel.BackgroundWorker bgIndir;
        private System.ComponentModel.BackgroundWorker bgYukle;
    }
}

