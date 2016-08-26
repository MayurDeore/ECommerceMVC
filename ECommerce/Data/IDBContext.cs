using System.Data.Entity;
using ECommerce.Data.Order;

namespace ECommerce.Data
{
    public interface IDBContext
    {
        IDbSet<Order.Order> Orders { get; set; }
    }
}