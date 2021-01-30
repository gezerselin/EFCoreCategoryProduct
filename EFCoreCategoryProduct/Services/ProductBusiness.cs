using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreCategoryProduct.Data;
using EFCoreCategoryProduct.Models;

namespace EFCoreCategoryProduct.Services
{
    class ProductBusiness
    {

        ProductAndCategoryDbContext dbContext = new ProductAndCategoryDbContext();

        public Product GetProductById(int id)
        {
            return dbContext.Products.Find(id);
        }
        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }
        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.Categories.Find(product.CategoryId).ProductCount++;
            dbContext.SaveChanges();
        }

        public void Remove(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.Categories.Find(product.CategoryId).ProductCount--;
            dbContext.SaveChanges();
        }

        public void Edit(Product product)
        {
            dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

    }
}
