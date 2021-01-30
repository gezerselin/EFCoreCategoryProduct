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
using EFCoreCategoryProduct.Data;
using EFCoreCategoryProduct.Services;

namespace EFCoreCategoryProduct
{
    public partial class Form1 : Form
    {
        ProductBusiness productBusiness = new ProductBusiness();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
            this.Hide() ;
        }

        private void buttonUrunGuncelleSil_Click(object sender, EventArgs e)
        {
            UrunGuncelleSil urunGuncelleSil = new UrunGuncelleSil();
            urunGuncelleSil.Show();
            this.Hide();
        }

        private void buttonKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkleGuncelleSil kategoriEkle = new KategoriEkleGuncelleSil();
            kategoriEkle.Show();
            this.Hide();
        }

        private void buttonKategoriGuncelleSil_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonUrunListele_Click(object sender, EventArgs e)
        {
            getProducts();
        }
        private void getProducts()
        {
            dataGridView1.DataSource = productBusiness.GetProducts();
        }
    }
}
