using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.IRepository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetProductByName();
        List<Product> GetProductByCat();
    }
}
