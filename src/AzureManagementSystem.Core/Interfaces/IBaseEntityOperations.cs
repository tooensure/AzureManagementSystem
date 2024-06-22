using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Core.Interfaces
{
    public interface IBaseEntityOperations<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T?> GetAsync(int id);
        Task<bool> DeleteAsync(int id);
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy);
        Task<int> UpdateAsync(T entity);
    }
}
