using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCategoryProduct.Models
{
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ProductCount { get; set; }
        public IList<Product> Products { get; set; }
    }
}
