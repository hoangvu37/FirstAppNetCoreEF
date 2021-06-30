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
        public string Name { get; set; }

        public string Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
