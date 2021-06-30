using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Models
{
    public class ProductDetail
    {
        public long ID { get; set; }
        public string Details { get; set; }
        public long ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
