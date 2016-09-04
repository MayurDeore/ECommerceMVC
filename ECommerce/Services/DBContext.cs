using System.Data.Entity;

namespace ECommerce.Services
{
    public class DBContext : DbContext, IDBContext
    {
        
        public DBContext():base("name=DBConString")
        {

        }
       

        public override DbSet<T> Set<T>()
        {
            return base.Set<T>();
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }


        
    }
}
