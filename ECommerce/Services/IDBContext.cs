using System.Data.Entity;

namespace ECommerce.Services
{
    public interface IDBContext
    {

        DbSet<T> Set<T>() where T :class;
    }
}