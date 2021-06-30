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
        ProductDBContext _context;
        public ProductRepository(ProductDBContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductByCat()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByName()
        {
            return _context.Products.OrderByDescending(d => d.Name).Take(15).Skip(1).ToList();
        }
    }
}
