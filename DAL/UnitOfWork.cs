using netcoreapi.DBContext;
using netcoreapi.IRepository;
using netcoreapi.Models;
using netcoreapi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductDBContext _context;
        public UnitOfWork(ProductDBContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }
        public IProductRepository Products { get; private set; }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
