using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public int Name { get; set; }

        public int Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
