using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OnlineShop.Models;
using OnlineShop.Controllers;
using OnlineShop.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Repositories
{
    public abstract class RepositorBase<T> : IRepositoryBase<T> where T : class
    {
        protected OnlineShopContext RepositoryContext { get; set; }

        public RepositorBase(OnlineShopContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll() => RepositoryContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);

    }

}
