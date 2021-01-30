
namespace EFCoreCategoryProduct
{
    partial class UrunEkle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonYeniKategori = new System.Windows.Forms.Button();
            this.buttonUrunGoruntule = new System.Windows.Forms.Button();
            this.buttonAnaMenu = new System.Windows.Forms.Button();
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            this.comboBoxKategoriListesi = new System.Windows.Forms.ComboBox();
            this.textBoxUrunBilgisi = new System.Windows.Forms.TextBox();
            this.textBoxUrunFiyat = new System.Windows.Forms.TextBox();
            this.textBoxUrunAd = new System.Windows.Forms.TextBox();
            this.labelUrunKategori = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelUrunInfo = new System.Windows.Forms.Label();
            this.labelUrunAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonYeniKategori);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUrunGoruntule);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAnaMenu);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUrunEkle);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxKategoriListesi);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxUrunBilgisi);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxUrunFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxUrunAd);
            this.splitContainer1.Panel1.Controls.Add(this.labelUrunKategori);
            this.splitContainer1.Panel1.Controls.Add(this.labelFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.labelUrunInfo);
            this.splitContainer1.Panel1.Controls.Add(this.labelUrunAd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(968, 519);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonYeniKategori
            // 
            this.buttonYeniKategori.Location = new System.Drawing.Point(197, 330);
            this.buttonYeniKategori.Name = "buttonYeniKategori";
            this.buttonYeniKategori.Size = new System.Drawing.Size(177, 54);
            this.buttonYeniKategori.TabIndex = 11;
            this.buttonYeniKategori.Text = "Yeni bir kategori eklemek istiyorum";
            this.buttonYeniKategori.UseVisualStyleBackColor = true;
            this.buttonYeniKategori.Click += new System.EventHandler(this.buttonYeniKategori_Click);
            // 
            // buttonUrunGoruntule
            // 
            this.buttonUrunGoruntule.Location = new System.Drawing.Point(134, 20);
            this.buttonUrunGoruntule.Name = "buttonUrunGoruntule";
            this.buttonUrunGoruntule.Size = new System.Drawing.Size(110, 64);
            this.buttonUrunGoruntule.TabIndex = 10;
            this.buttonUrunGoruntule.Text = "Ürünleri Görüntüle";
            this.buttonUrunGoruntule.UseVisualStyleBackColor = true;
            this.buttonUrunGoruntule.Click += new System.EventHandler(this.buttonUrunGoruntule_Click);
            // 
            // buttonAnaMenu
            // 
            this.buttonAnaMenu.Location = new System.Drawing.Point(29, 430);
            this.buttonAnaMenu.Name = "buttonAnaMenu";
            this.buttonAnaMenu.Size = new System.Drawing.Size(180, 47);
            this.buttonAnaMenu.TabIndex = 9;
            this.buttonAnaMenu.Text = "Ana menüye geri dön";
            this.buttonAnaMenu.UseVisualStyleBackColor = true;
            this.buttonAnaMenu.Click += new System.EventHandler(this.buttonAnaMenu_Click_1);
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Enabled = false;
            this.buttonUrunEkle.Location = new System.Drawing.Point(234, 416);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(140, 74);
            this.buttonUrunEkle.TabIndex = 8;
            this.buttonUrunEkle.Text = "Ürünü Ekle";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            this.buttonUrunEkle.Click += new System.EventHandler(this.buttonUrunEkle_Click);
            // 
            // comboBoxKategoriListesi
            // 
            this.comboBoxKategoriListesi.FormattingEnabled = true;
            this.comboBoxKategoriListesi.Location = new System.Drawing.Point(172, 296);
            this.comboBoxKategoriListesi.Name = "comboBoxKategoriListesi";
            this.comboBoxKategoriListesi.Size = new System.Drawing.Size(202, 28);
            this.comboBoxKategoriListesi.TabIndex = 7;
            this.comboBoxKategoriListesi.Text = "Lütfen kategori seçiniz";
            this.comboBoxKategoriListesi.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategoriListesi_SelectedIndexChanged);
            // 
            // textBoxUrunBilgisi
            // 
            this.textBoxUrunBilgisi.Location = new System.Drawing.Point(33, 215);
            this.textBoxUrunBilgisi.Multiline = true;
            this.textBoxUrunBilgisi.Name = "textBoxUrunBilgisi";
            this.textBoxUrunBilgisi.Size = new System.Drawing.Size(341, 49);
            this.textBoxUrunBilgisi.TabIndex = 6;
            // 
            // textBoxUrunFiyat
            // 
            this.textBoxUrunFiyat.Location = new System.Drawing.Point(212, 138);
            this.textBoxUrunFiyat.Name = "textBoxUrunFiyat";
            this.textBoxUrunFiyat.Size = new System.Drawing.Size(162, 26);
            this.textBoxUrunFiyat.TabIndex = 5;
            // 
            // textBoxUrunAd
            // 
            this.textBoxUrunAd.Location = new System.Drawing.Point(29, 138);
            this.textBoxUrunAd.Name = "textBoxUrunAd";
            this.textBoxUrunAd.Size = new System.Drawing.Size(136, 26);
            this.textBoxUrunAd.TabIndex = 4;
            // 
            // labelUrunKategori
            // 
            this.labelUrunKategori.AutoSize = true;
            this.labelUrunKategori.Location = new System.Drawing.Point(29, 296);
            this.labelUrunKategori.Name = "labelUrunKategori";
            this.labelUrunKategori.Size = new System.Drawing.Size(122, 20);
            this.labelUrunKategori.TabIndex = 3;
            this.labelUrunKategori.Text = "Ürün Kategorisi:";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(208, 103);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(89, 20);
            this.labelFiyat.TabIndex = 2;
            this.labelFiyat.Text = "Ürün Fiyatı:";
            // 
            // labelUrunInfo
            // 
            this.labelUrunInfo.AutoSize = true;
            this.labelUrunInfo.Location = new System.Drawing.Point(29, 182);
            this.labelUrunInfo.Name = "labelUrunInfo";
            this.labelUrunInfo.Size = new System.Drawing.Size(96, 20);
            this.labelUrunInfo.TabIndex = 1;
            this.labelUrunInfo.Text = "Ürün Bilgisi :";
            // 
            // labelUrunAd
            // 
            this.labelUrunAd.AutoSize = true;
            this.labelUrunAd.Location = new System.Drawing.Point(25, 103);
            this.labelUrunAd.Name = "labelUrunAd";
            this.labelUrunAd.Size = new System.Drawing.Size(75, 20);
            this.labelUrunAd.TabIndex = 0;
            this.labelUrunAd.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(563, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // UrunEkle
            // 
            this.ClientSize = new System.Drawing.Size(968, 519);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUrunEklendi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxUrunBilgisi;
        private System.Windows.Forms.TextBox textBoxUrunFiyat;
        private System.Windows.Forms.TextBox textBoxUrunAd;
        private System.Windows.Forms.Label labelUrunKategori;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelUrunInfo;
        private System.Windows.Forms.Label labelUrunAd;
        private System.Windows.Forms.ComboBox comboBoxKategoriListesi;
        private System.Windows.Forms.Button buttonAnaMenu;
        private System.Windows.Forms.Button buttonUrunEkle;
        private System.Windows.Forms.Button buttonUrunGoruntule;
        private System.Windows.Forms.Button buttonYeniKategori;
    }
}