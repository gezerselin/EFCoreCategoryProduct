using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCoreCategoryProduct.Data;
using EFCoreCategoryProduct.Models;

namespace EFCoreCategoryProduct.Services
{
    class CategoriesBusiness
    {
        ProductAndCategoryDbContext dbContext = new ProductAndCategoryDbContext();

        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.Find(id);
        }
        public List<Category> GetCategory()
        {
            return dbContext.Categories.ToList();
        }
        public void Add(Category category)
        {
             dbContext.Categories.Add(category);
             dbContext.SaveChanges();

        }
        public void Remove(Category category)
        {
            
                dbContext.Categories.Remove(category);
                dbContext.SaveChanges();
           
            
        }
        public void Edit(Category category)
        {
            dbContext.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

    }
}
