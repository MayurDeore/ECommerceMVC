using ECommerce.Data.Order;
using System.Data.Entity;
using System.Linq;

namespace ECommerce.Services.OrderServices
{
    public class OrderService :  IOrderService
    {
        private IDBContext _context;
        private DbSet<Order> _order;
        
        public OrderService(IDBContext ctx)
        {
            this._context = ctx;
            this._order = this._context.Set<Order>();
           
        }

        public Order GetByTransId(string transId)
        {
            return this._order
                .Where(x => x.TransID == transId).FirstOrDefault();
        }

    }
}
