using Microsoft.EntityFrameworkCore;
using PAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Entprog.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext db;
        public GenericRepository(AppDbContext db) 
        {
            this.db = db;
        }
        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await db.Set<T>().Where(predicate).ToListAsync();
        }
        public async Task<T> AddAsync(T entity)
        {
           await db.Set<T>().AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            T obj = await db.Set<T>().FindAsync(id);
            db.Set<T>().Remove(obj);
            await db.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            T? obj = await db.Set<T>().FindAsync(id);
            if (obj != null)
            {
                return true;
            }
            else return false;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            T obj = await db.Set<T>().FindAsync(id);
            return obj;
        }

        public async Task UpdateAsync(T entity)
        {
            db.Set<T>().Update(entity);
            await db.SaveChangesAsync();
        }
        public async Task CreateAsync(T entity)
        {
            // Code to save the entity to the database.
            // For example, if you're using Entity Framework Core, you might do something like this:
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
        }
    }
}
