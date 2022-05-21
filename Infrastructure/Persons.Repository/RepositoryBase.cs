using Microsoft.EntityFrameworkCore;
using Persons.Contracts;
using Persons.Entities.RepositoryContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        protected RepositoryContext repositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }
        public void Create(T entity) => repositoryContext.Set<T>().Add(entity);

        public void Delete(T entity) => repositoryContext.Set<T>().Remove(entity);


        public IQueryable<T> FindAll(bool trackChanges) =>
           !trackChanges ? repositoryContext.Set<T>().AsNoTracking() : repositoryContext.Set<T>();


        public IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expressions, bool trackChange) =>
             !trackChange ? repositoryContext.Set<T>().Where(expressions).AsNoTracking()
            : repositoryContext.Set<T>().Where(expressions);

        public void Update(T entity) => repositoryContext.Set<T>().Update(entity);
    }
}
