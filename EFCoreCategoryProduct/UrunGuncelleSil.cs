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
    public partial class UrunGuncelleSil : Form
    {
        ProductAndCategoryDbContext dbContext = new ProductAndCategoryDbContext();
        ProductBusiness productBusiness = new ProductBusiness();
        public UrunGuncelleSil()
        {
            InitializeComponent();
        }

        private void UrunGuncelleSil_Load(object sender, EventArgs e)
        {
            getProducts();
            getProductsToSelect();
            buttonUrunGuncelle.Enabled = false;
            buttonUrunSil.Enabled = false ;
            comboBoxUrunSecimi.Text = "Lütfen ürün seçiniz";
        }

        private void getProductsToSelect()
        {
            dbContext.SaveChanges();
            comboBoxUrunSecimi.DataSource = dbContext.Products.ToList();
            comboBoxUrunSecimi.DisplayMember = "ProductName";
            comboBoxUrunSecimi.ValueMember = "Id";
        }
        Product selectedProduct = null;
        private void comboBoxUrunSecimi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxUrunSecimi.SelectedValue;
    

            var product = productBusiness.GetProductById(selectedProductId);

            selectedProduct= product;

            textBoxUrunAdiGetir.Text = selectedProduct.ProductName;
            textBoxUrunFiyatiGetir.Text = selectedProduct.Price.ToString();
            textBoxUrunInfoGetir.Text = selectedProduct.Info;
            getCategoriesToSelect();
            comboBoxKategoriGetir.Text =dbContext.Categories.Find(selectedProduct.CategoryId).CategoryName;

          

        }
        public void getCategoriesToSelect()
        {
            comboBoxKategoriGetir.DataSource = dbContext.Categories.ToList();
            comboBoxKategoriGetir.DisplayMember = "CategoryName";
            comboBoxKategoriGetir.ValueMember = "Id";
        }

        private void buttonUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProduct.ProductName = textBoxUrunAdiGetir.Text;
                selectedProduct.Price = Convert.ToDouble(textBoxUrunFiyatiGetir.Text);
                selectedProduct.Info = textBoxUrunInfoGetir.Text;
                selectedProduct.CategoryId = Convert.ToInt32(comboBoxKategoriGetir.SelectedValue);
                if (textBoxUrunAdiGetir.Text == "")
                {
                    MessageBox.Show("Ürün adı boş geçilemez");
                }
                else
                {
                    productBusiness.Edit(selectedProduct);
                    getProducts();


                    getProductsToSelect();
                    comboBoxUrunSecimi.Text = "Lütfen ürün seçiniz";


                    this.Hide();
                    UrunGuncelleSil urunGuncelleSil = new UrunGuncelleSil();
                    urunGuncelleSil.Show();
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

        private void buttonUrunSil_Click(object sender, EventArgs e)
        {
            productBusiness.Remove(selectedProduct);
            getProducts();
            getProductsToSelect();
            textBoxUrunAdiGetir.Text = "";
            textBoxUrunFiyatiGetir.Text = "";
            textBoxUrunInfoGetir.Text = "";
            comboBoxKategoriGetir.Text = "";
            comboBoxUrunSecimi.Text = "lütfen ürün seçiniz";
            buttonUrunGuncelle.Enabled = false;
            buttonUrunSil.Enabled = false;
        }

        private void buttonAnaMenu2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void comboBoxUrunSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUrunSil.Enabled = true;
            buttonUrunGuncelle.Enabled = true;
        }
    }
}
