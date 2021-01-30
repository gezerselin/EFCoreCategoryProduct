using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreCategoryProduct.Data;
using EFCoreCategoryProduct.Models;
using EFCoreCategoryProduct.Services;

namespace EFCoreCategoryProduct
{
    public partial class UrunEkle : Form
    {
        ProductAndCategoryDbContext dbContext = new ProductAndCategoryDbContext();
        ProductBusiness productBusiness = new ProductBusiness();

        public UrunEkle()
        {
            InitializeComponent();
        }

        private void buttonAnaMenu_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            
            getCategoriesToSelect();
            buttonUrunEkle.Enabled = false;
            comboBoxKategoriListesi.Text = "Lütfen kategori seçiniz";
        }

        public void getCategoriesToSelect()
        {
            comboBoxKategoriListesi.DataSource = dbContext.Categories.ToList();
            comboBoxKategoriListesi.DisplayMember = "CategoryName";
            comboBoxKategoriListesi.ValueMember = "Id";
        }

        private void buttonAnaMenu_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = textBoxUrunAd.Text;

            try
            {
                product.Price = Convert.ToDouble(textBoxUrunFiyat.Text);
                product.Info = textBoxUrunBilgisi.Text;
                product.CategoryId = Convert.ToInt32(comboBoxKategoriListesi.SelectedValue);
                if (product.ProductName == "")
                {
                    MessageBox.Show("Ürün adı girmek zorunlu!");

                }
                else
                {
                    productBusiness.Add(product);
                    getProducts();

                    textBoxUrunAd.Text = null;
                    textBoxUrunBilgisi.Text = null;
                    textBoxUrunFiyat.Text = null;
                    comboBoxKategoriListesi.Text = "Lütfen kategori seçiniz";
                    buttonUrunEkle.Enabled = false;
                }


                
            }
            catch (Exception)
            {

                MessageBox.Show("Fiyat bilgisi rakamlardan oluşmalıdır");
            }
          
          
        }

       private void getProducts()
        {
            dataGridView1.DataSource = productBusiness.GetProducts();
        }

        private void buttonUrunGoruntule_Click(object sender, EventArgs e)
        {
            getProducts();
        }

        private void buttonYeniKategori_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriEkle = new KategoriEkle();
            kategoriEkle.Show();
            
        }

        private void comboBoxKategoriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUrunEkle.Enabled = true;
        }
    }
}
