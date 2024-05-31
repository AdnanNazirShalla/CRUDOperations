using CRUDinMVC.Application.Abstractions.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Persistance.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly AppDbContext dbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int Add<T>(T model) where T : class
        {
            dbContext.Set<T>().Add(model);
            return dbContext.SaveChanges();
        }

        public int Delete<T>(T model) where T : class
        {
            dbContext.Set<T>().Remove(model);
            return dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return dbContext.Set<T>();
        }

        public T GetById<T>(Guid id) where T : class
        {
            return dbContext.Set<T>().Find(id);
        }

        public int Update<T>(T model) where T : class
        {
            dbContext.Set<T>().Update(model);
            return dbContext.SaveChanges();
        }
    }
}
