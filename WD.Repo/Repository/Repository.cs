using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WD.Data.Model;
using WD.Repo.DBContext;

namespace WD.Repo.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly WDContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(WDContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public async Task<int> Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
           await entities.AddAsync(entity);
           return context.SaveChanges();
        }

        public async Task<int> Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
           return await context.SaveChangesAsync();
        }

        public int Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
           return context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public async Task<int> SaveChanges()
        {
           return await context.SaveChangesAsync();
        }
    }
}
