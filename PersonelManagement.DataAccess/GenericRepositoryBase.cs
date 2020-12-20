using Microsoft.EntityFrameworkCore;
using PersonelManagement.DataAccess.Abstract;
using PersonelManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelManagement.DataAccess
{
    public class GenericRepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext dbContext;

        public async Task Create(T entity)
        {
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await dbContext.Set<T>().FirstOrDefaultAsync(v => v.Id == id);
            dbContext.Set<T>().Remove(entity);

        }

        public async Task<T> Find(int id)
        {
            var entity = await dbContext.Set<T>().FirstOrDefaultAsync(v => v.Id == id);
            return entity;
        }

        public async Task<IEnumerable<T>> GetList()
        {
            var list = await dbContext.Set<T>().ToListAsync();
            return list;
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
