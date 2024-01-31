using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entprog.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T entity);
        Task<bool> ExistsAsync(int id);
        Task CreateAsync(T entity);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);

    }
}
