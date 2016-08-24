using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class EntityService<T> : IEntityService<T> where T : class
    {
        protected readonly DBContext _context;
        protected DbSet<T> Entity;
        public EntityService(DBContext context)
        {
            this._context = context;
            this.Entity=_context.Set<T>();
        }
        public void Add(T entity)
        {
            this.Entity.Add(entity);
        }

        public void Delete(T entity)
        {
            this.Entity.Remove(entity);
            
        }

        public T FindById(int id)
        {
            return (T)this.Entity.Find();
        }

        public IQueryable<T> GetAll()
        {
            return this.Entity;
        }

        public IQueryable<T> GetAll(Func<T, bool> predicate)
        {
            return this.Entity.Where(predicate).AsQueryable();
        }
    }
}
