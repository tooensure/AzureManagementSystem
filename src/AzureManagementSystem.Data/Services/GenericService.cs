using AzureManagementSystem.Core.Interfaces.IRepositories;
using AzureManagementSystem.Core.Interfaces.IServices;
using AzureManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Data.Services
{
    public abstract class GenericService<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        protected GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
