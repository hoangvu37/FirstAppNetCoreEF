using netcoreapi.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        int SaveChanges();
    }
}
