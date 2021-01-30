
namespace EFCoreCategoryProduct
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
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            this.buttonUrunGuncelleSil = new System.Windows.Forms.Button();
            this.buttonKategoriEkleSilGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUrunListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Location = new System.Drawing.Point(23, 128);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(230, 75);
            this.buttonUrunEkle.TabIndex = 0;
            this.buttonUrunEkle.Text = "Ürün Ekle";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            this.buttonUrunEkle.Click += new System.EventHandler(this.buttonUrunEkle_Click);
            // 
            // buttonUrunGuncelleSil
            // 
            this.buttonUrunGuncelleSil.Location = new System.Drawing.Point(23, 224);
            this.buttonUrunGuncelleSil.Name = "buttonUrunGuncelleSil";
            this.buttonUrunGuncelleSil.Size = new System.Drawing.Size(230, 75);
            this.buttonUrunGuncelleSil.TabIndex = 1;
            this.buttonUrunGuncelleSil.Text = "Ürün Güncelle/Sil";
            this.buttonUrunGuncelleSil.UseVisualStyleBackColor = true;
            this.buttonUrunGuncelleSil.Click += new System.EventHandler(this.buttonUrunGuncelleSil_Click);
            // 
            // buttonKategoriEkleSilGuncelle
            // 
            this.buttonKategoriEkleSilGuncelle.Location = new System.Drawing.Point(23, 335);
            this.buttonKategoriEkleSilGuncelle.Name = "buttonKategoriEkleSilGuncelle";
            this.buttonKategoriEkleSilGuncelle.Size = new System.Drawing.Size(230, 75);
            this.buttonKategoriEkleSilGuncelle.TabIndex = 3;
            this.buttonKategoriEkleSilGuncelle.Text = "Kategori Ekle/Sil/Güncelle";
            this.buttonKategoriEkleSilGuncelle.UseVisualStyleBackColor = true;
            this.buttonKategoriEkleSilGuncelle.Click += new System.EventHandler(this.buttonKategoriEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(459, 383);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonUrunListele
            // 
            this.buttonUrunListele.Location = new System.Drawing.Point(23, 27);
            this.buttonUrunListele.Name = "buttonUrunListele";
            this.buttonUrunListele.Size = new System.Drawing.Size(230, 75);
            this.buttonUrunListele.TabIndex = 5;
            this.buttonUrunListele.Text = "Ürünleri Listele";
            this.buttonUrunListele.UseVisualStyleBackColor = true;
            this.buttonUrunListele.Click += new System.EventHandler(this.buttonUrunListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUrunListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonKategoriEkleSilGuncelle);
            this.Controls.Add(this.buttonUrunGuncelleSil);
            this.Controls.Add(this.buttonUrunEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUrunEkle;
        private System.Windows.Forms.Button buttonUrunGuncelleSil;
        private System.Windows.Forms.Button buttonKategoriEkleSilGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUrunListele;
    }
}

