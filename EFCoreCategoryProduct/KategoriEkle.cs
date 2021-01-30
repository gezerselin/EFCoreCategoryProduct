using EFCoreCategoryProduct.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreCategoryProduct.Models;
using EFCoreCategoryProduct.Services;

namespace EFCoreCategoryProduct
{
    public partial class KategoriEkle : Form
    {
        ProductAndCategoryDbContext dbContext = new ProductAndCategoryDbContext();
        CategoriesBusiness categoriesBusiness = new CategoriesBusiness();
        
        public KategoriEkle()
        {
            InitializeComponent();
        }

        private void buttonYeniKategoriEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBoxKategoriEkle.Text;
            int flag = 1;
            foreach(var item in dbContext.Categories)
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
                categoriesBusiness.Add(category);
                MessageBox.Show($"{category.CategoryName} kategorilere eklendi");
                this.Hide();
                UrunEkle urunEkle = (UrunEkle)Application.OpenForms["UrunEkle"];
                urunEkle.getCategoriesToSelect();
         
            }
        }

  
    }
}
