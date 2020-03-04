using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WD.Data.Model;

namespace WD.Repo.Repository
{
   public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        T Get(int id);
        Task<int> Insert(T entity);
        Task<int> Update(T entity);
        int Delete(T entity);
        void Remove(T entity);
        Task<int> SaveChanges();
    }
}
