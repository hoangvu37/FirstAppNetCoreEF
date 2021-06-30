using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Models
{
    public class ProductDetail
    {
        public long ID { get; set; }
        public long ProductID { get; set; }
        public long Details { get; set; }
        public virtual Product Product { get; set; }
    }
}
