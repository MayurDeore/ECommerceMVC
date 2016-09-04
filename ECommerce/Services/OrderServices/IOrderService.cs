using ECommerce.Data.Order;

namespace ECommerce.Services.OrderServices
{
    public interface IOrderService : IServices<Order>
    {
        Order GetByTransId(string transId);
    }
}