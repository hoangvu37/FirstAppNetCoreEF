using Microsoft.EntityFrameworkCore;
using netcoreapi.DBContext;
using netcoreapi.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace netcoreapi.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ProductDBContext _context;
        public GenericRepository(ProductDBContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int take = 15, int skip = 0)
        {
            var query = _context.Set<T>().Where(expression);
            //foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            //{
            //    query = query.Include(includeProperty);
            //}
            query = query.Skip(skip).Take(take);
            if (orderBy != null)
                query = orderBy(query);
            return query.ToList();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(long id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
