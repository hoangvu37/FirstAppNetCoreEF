using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Models
{
    public class ProductCategory
    {
        public long ID { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category{ get; set; }
        public long ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
