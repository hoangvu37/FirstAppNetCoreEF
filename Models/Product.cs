using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Models
{
    public class Product
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate  { get; set; }
        public DateTime DiscontinuedDate { get; set; }

        public Int16 Rating { get; set; }
        public double Price { get; set; }
        //public int CategoryID { get; set; }
        public  virtual ICollection<Category> Categorys { get; set; }
        //public virtual ICollection<ProductCategory> ProductCategorys { get; set; }
        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
    }
}
