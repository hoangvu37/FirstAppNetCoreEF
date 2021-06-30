﻿using Microsoft.EntityFrameworkCore;
using netcoreapi.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace netcoreapi.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(long id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Delete(T entity);
        void Update(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
