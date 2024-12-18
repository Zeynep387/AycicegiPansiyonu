
namespace Ayçiçeği_Pansiyon_Uygulaması_v1._0
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnYeniMusteri = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnPersonelMaas = new System.Windows.Forms.Button();
            this.btnMusteriMesaj = new System.Windows.Forms.Button();
            this.btnRadyoDinle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGazeteler = new System.Windows.Forms.Button();
            this.btnSifreGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(12, 12);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(114, 87);
            this.BtnAdminGiris.TabIndex = 0;
            this.BtnAdminGiris.Text = "Admin Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = true;
            this.BtnAdminGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnYeniMusteri
            // 
            this.BtnYeniMusteri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniMusteri.Location = new System.Drawing.Point(167, 12);
            this.BtnYeniMusteri.Name = "BtnYeniMusteri";
            this.BtnYeniMusteri.Size = new System.Drawing.Size(114, 87);
            this.BtnYeniMusteri.TabIndex = 1;
            this.BtnYeniMusteri.Text = "Yeni Müşteri";
            this.BtnYeniMusteri.UseVisualStyleBackColor = true;
            this.BtnYeniMusteri.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.Location = new System.Drawing.Point(12, 144);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(114, 87);
            this.btnMusteriler.TabIndex = 4;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnPersonelMaas
            // 
            this.btnPersonelMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelMaas.Location = new System.Drawing.Point(167, 144);
            this.btnPersonelMaas.Name = "btnPersonelMaas";
            this.btnPersonelMaas.Size = new System.Drawing.Size(114, 87);
            this.btnPersonelMaas.TabIndex = 5;
            this.btnPersonelMaas.Text = "Gelir - Gider Formu";
            this.btnPersonelMaas.UseVisualStyleBackColor = true;
            this.btnPersonelMaas.Click += new System.EventHandler(this.btnPersonelMaas_Click);
            // 
            // btnMusteriMesaj
            // 
            this.btnMusteriMesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriMesaj.Location = new System.Drawing.Point(12, 277);
            this.btnMusteriMesaj.Name = "btnMusteriMesaj";
            this.btnMusteriMesaj.Size = new System.Drawing.Size(114, 87);
            this.btnMusteriMesaj.TabIndex = 8;
            this.btnMusteriMesaj.Text = "Müşteri Mesajları";
            this.btnMusteriMesaj.UseVisualStyleBackColor = true;
            this.btnMusteriMesaj.Click += new System.EventHandler(this.btnMusteriMesaj_Click);
            // 
            // btnRadyoDinle
            // 
            this.btnRadyoDinle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRadyoDinle.Location = new System.Drawing.Point(167, 277);
            this.btnRadyoDinle.Name = "btnRadyoDinle";
            this.btnRadyoDinle.Size = new System.Drawing.Size(114, 87);
            this.btnRadyoDinle.TabIndex = 9;
            this.btnRadyoDinle.Text = "Radyo Dinle";
            this.btnRadyoDinle.UseVisualStyleBackColor = true;
            this.btnRadyoDinle.Click += new System.EventHandler(this.btnRadyoDinle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdalar.Location = new System.Drawing.Point(328, 12);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(114, 87);
            this.BtnOdalar.TabIndex = 2;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = true;
            this.BtnOdalar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.Location = new System.Drawing.Point(328, 144);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(114, 87);
            this.btnStok.TabIndex = 6;
            this.btnStok.Text = "Stoklar";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkimizda.Location = new System.Drawing.Point(328, 277);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(114, 87);
            this.btnHakkimizda.TabIndex = 10;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.UseVisualStyleBackColor = true;
            this.btnHakkimizda.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(495, 277);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(114, 87);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGazeteler
            // 
            this.btnGazeteler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGazeteler.Location = new System.Drawing.Point(495, 144);
            this.btnGazeteler.Name = "btnGazeteler";
            this.btnGazeteler.Size = new System.Drawing.Size(114, 87);
            this.btnGazeteler.TabIndex = 7;
            this.btnGazeteler.Text = "Gazeteler";
            this.btnGazeteler.UseVisualStyleBackColor = true;
            this.btnGazeteler.Click += new System.EventHandler(this.btnGazeteler_Click);
            // 
            // btnSifreGuncelle
            // 
            this.btnSifreGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreGuncelle.Location = new System.Drawing.Point(495, 12);
            this.btnSifreGuncelle.Name = "btnSifreGuncelle";
            this.btnSifreGuncelle.Size = new System.Drawing.Size(114, 87);
            this.btnSifreGuncelle.TabIndex = 3;
            this.btnSifreGuncelle.Text = "Şifre Güncelle";
            this.btnSifreGuncelle.UseVisualStyleBackColor = true;
            this.btnSifreGuncelle.Click += new System.EventHandler(this.btnHavaDurumu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(699, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(699, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(907, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGazeteler);
            this.Controls.Add(this.btnSifreGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHakkimizda);
            this.Controls.Add(this.btnRadyoDinle);
            this.Controls.Add(this.btnMusteriMesaj);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnPersonelMaas);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.BtnYeniMusteri);
            this.Controls.Add(this.BtnAdminGiris);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnYeniMusteri;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnPersonelMaas;
        private System.Windows.Forms.Button btnMusteriMesaj;
        private System.Windows.Forms.Button btnRadyoDinle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOdalar;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnHakkimizda;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGazeteler;
        private System.Windows.Forms.Button btnSifreGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}