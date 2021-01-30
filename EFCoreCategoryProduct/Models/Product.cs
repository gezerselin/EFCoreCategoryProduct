using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCategoryProduct.Models
{
    class Product
    {
        
        public int Id { get; set; }
        public string ProductName{ get; set; }
        public string Info { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
