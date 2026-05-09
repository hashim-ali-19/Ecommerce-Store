using EcomerceStoreAssi.Models;

namespace EcomerceStoreAssi.Services
{
    public class OrderService
    {
        private OrderModel? _lastOrder;

        public void PlaceOrder(OrderModel order)
        {
            _lastOrder = order;
        }

        public OrderModel? GetLastOrder() => _lastOrder;
    }
}