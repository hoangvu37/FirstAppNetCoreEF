using netcoreapi.DAL;
using netcoreapi.DBContext;
using netcoreapi.IRepository;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace netcoreapi.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductDBContext context) : base(context)
        {
        }

        public List<Product> GetProductByCat()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByName()
        {
            throw new NotImplementedException();
        }
    }
}
