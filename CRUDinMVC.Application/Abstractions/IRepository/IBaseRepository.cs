using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Application.Abstractions.IRepository
{
    public interface IBaseRepository
    {
        int Add<T>(T model) where T : class;

         int Update<T>(T model) where T : class;

         int Delete<T>(T model)where T : class;


        IEnumerable<T> GetAll<T>() where T : class;


        T GetById<T>(Guid id) where T : class;
    }
}
