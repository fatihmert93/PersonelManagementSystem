using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonelManagement.DataAccess.Abstract
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetList();
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<T> Find(int id);


    }
}
