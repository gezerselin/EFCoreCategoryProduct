
namespace EFCoreCategoryProduct
{
    partial class KategoriEkle
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
            this.buttonYeniKategoriEkle = new System.Windows.Forms.Button();
            this.textBoxKategoriEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonYeniKategoriEkle
            // 
            this.buttonYeniKategoriEkle.Location = new System.Drawing.Point(181, 128);
            this.buttonYeniKategoriEkle.Name = "buttonYeniKategoriEkle";
            this.buttonYeniKategoriEkle.Size = new System.Drawing.Size(82, 46);
            this.buttonYeniKategoriEkle.TabIndex = 0;
            this.buttonYeniKategoriEkle.Text = "Ekle";
            this.buttonYeniKategoriEkle.UseVisualStyleBackColor = true;
            this.buttonYeniKategoriEkle.Click += new System.EventHandler(this.buttonYeniKategoriEkle_Click);
            // 
            // textBoxKategoriEkle
            // 
            this.textBoxKategoriEkle.Location = new System.Drawing.Point(34, 77);
            this.textBoxKategoriEkle.Name = "textBoxKategoriEkle";
            this.textBoxKategoriEkle.Size = new System.Drawing.Size(229, 26);
            this.textBoxKategoriEkle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eklemek istediğiniz kategori adı:";
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKategoriEkle);
            this.Controls.Add(this.buttonYeniKategoriEkle);
            this.Name = "KategoriEkle";
            this.Text = "KategoriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonYeniKategoriEkle;
        private System.Windows.Forms.TextBox textBoxKategoriEkle;
        private System.Windows.Forms.Label label1;
    }
}