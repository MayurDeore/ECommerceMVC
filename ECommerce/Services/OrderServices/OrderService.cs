using ECommerce.Data;
using ECommerce.Data.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.OrderServices
{
    public class OrderService 
    {
        private IDBContext _context;
        
        public OrderService(IDBContext ctx)
        {
            this._context = ctx;
           
        }

        public Order GetByTransId(string transId)
        {
            return this._context.Orders.Where(x => x.TransID == transId).FirstOrDefault();
        }

    }
}
