using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public interface IEntityService<T> : IService where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        T FindById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Func<T, bool> predicate);
         

    }
}
