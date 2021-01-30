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
    public partial class KategoriEkleGuncelleSil : Form
    {
        ProductAndCategoryDbContext dbContext = new ProductAndCategoryDbContext();
        CategoriesBusiness categoriesBusiness = new CategoriesBusiness();
        public KategoriEkleGuncelleSil()
        {
            InitializeComponent();
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            getCategories();
            getCategoriesToSelect();
            comboBoxKategoriAd.Text = "Lütfen kategori seçiniz";
            buttonKategoriGuncelle.Enabled = false;
            buttonKategoriSil.Enabled = false;
        }
        private void getCategories()
        {
            dataGridView1.DataSource = categoriesBusiness.GetCategory();
        }

        private void buttonKategoriEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBoxKategoriAd.Text;
            int flag = 1;
            foreach (var item in dbContext.Categories)
            {
                if (item.CategoryName == category.CategoryName)
                {
                    MessageBox.Show("Bu kategori zaten var!");
                    flag = 0;
                    break;
                }

            }
            if (flag != 0)
            {
                if (textBoxKategoriAd.Text == "")
                {
                    MessageBox.Show("Kategori adı boş geçilemez");
                }
                else
                {
                    categoriesBusiness.Add(category);
                    getCategories();
                    getCategoriesToSelect();
                    comboBoxKategoriAd.Text = "Lütfen kategori seçiniz";
                    textBoxKategoriAd.Enabled = false;
                    textBoxKategoriAd.Text = null;
                    buttonKategoriEkle.Enabled = false;
                }
               
               
            } 
        }

        private void buttonAnaMenu3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }


        private void getCategoriesToSelect()
        {
     
            comboBoxKategoriAd.DataSource = dbContext.Categories.ToList();
            comboBoxKategoriAd.DisplayMember = "CategoryName";
            comboBoxKategoriAd.ValueMember = "Id";
        }

        Category selectedCategory = null;
        private void comboBoxKategoriAd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int selectedCategoryId = (int)comboBoxKategoriAd.SelectedValue;


            int selectedCategoryId = (int)comboBoxKategoriAd.SelectedValue;

            var category = categoriesBusiness.GetCategoryById(selectedCategoryId);
            selectedCategory = category;
            textBoxKategori.Text = selectedCategory.CategoryName;


        }

        private void buttonKategoriSil_Click(object sender, EventArgs e)
        {
            //if (dbContext.Products.Find(selectedCategory.Id).Id== 0)
            // {
            //TODO 1: ürünü olan kategoriler silinemesin
           
            Category newCategory = dbContext.Categories.Find(selectedCategory.Id);
            if (newCategory.ProductCount ==0)
            {
                categoriesBusiness.Remove(selectedCategory);
                getCategories();
                getCategoriesToSelect();
                textBoxKategori.Text = "";
                comboBoxKategoriAd.Text = "Lütfen kategori seçiniz";
                

            }
            else
            {
                MessageBox.Show("Kategoriye ait ürünler olduğu için bu kategori silinemez");
            }

        }

        private void buttonKategoriGuncelle_Click(object sender, EventArgs e)
        {
            selectedCategory.CategoryName = textBoxKategori.Text;
            categoriesBusiness.Edit(selectedCategory);
            getCategories();
            getCategoriesToSelect();
            comboBoxKategoriAd.Text = "Lütfen kategori seçiniz";
      
            textBoxKategori.Text = "";
            buttonKategoriGuncelle.Enabled = false;
            buttonKategoriSil.Enabled = false;
            this.Hide();  
            KategoriEkleGuncelleSil kategoriEkleGuncelleSil =new  KategoriEkleGuncelleSil();
            kategoriEkleGuncelleSil.Show();
          
        }

        private void buttonYeniKategori_Click(object sender, EventArgs e)
        {
            labelKategoriAd.Enabled = true;
            textBoxKategoriAd.Enabled = true;
            buttonKategoriEkle.Enabled = true;
            
        }

        private void comboBoxKategoriAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonKategoriGuncelle.Enabled =true;
            buttonKategoriSil.Enabled = true;
        }
    }
}
