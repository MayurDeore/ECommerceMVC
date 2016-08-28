using ECommerce.Data.Order;

namespace ECommerce.Services.OrderServices
{
    public interface IOrderService
    {
        Order GetByTransId(string transId);
    }
}