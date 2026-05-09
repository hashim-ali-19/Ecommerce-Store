using EcomerceStoreAssi.Models;

namespace EcomerceStoreAssi.Models
{
    public class OrderModel
    {
        public string CustomerName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Product? Product { get; set; }
        public decimal TotalPrice => (Product?.Price ?? 0) * Quantity;
    }
}