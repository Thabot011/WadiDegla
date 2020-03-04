using System;
using System.Collections.Generic;
using System.Text;
using WD.Data.Model;

namespace WD.Repo.Repository
{
   public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
