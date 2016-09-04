using ECommerce.Data.Order;
using System.Linq;

namespace ECommerce.Services.OrderServices
{
    public class OrderService :  IOrderService
    {
        private IDBContext _context;
        
        public OrderService(IDBContext ctx)
        {
            this._context = ctx;
           
        }

        public Order GetByTransId(string transId)
        {
            return this._context.Set<Order>()
                .Where(x => x.TransID == transId).FirstOrDefault();
        }

    }
}
