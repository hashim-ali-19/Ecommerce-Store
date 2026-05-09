using EcomerceStoreAssi.Models;
using EcomerceStoreAssi.Models;

namespace EcomerceStoreAssi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Wireless Headphones", Price = 79.99m,
                Description = "Premium sound quality with noise cancellation.",
                ImageUrl = "headphones.jpg" },

            new Product { Id = 2, Name = "Smart Watch", Price = 149.99m,
                Description = "Track fitness and stay connected on the go.",
                ImageUrl = "watches.jpg" },

            new Product { Id = 3, Name = "Laptop Backpack", Price = 49.99m,
                Description = "Durable and spacious 15-inch laptop bag.",
                ImageUrl = "bag.jpg" },

            new Product { Id = 4, Name = "Mechanical Keyboard", Price = 99.99m,
                Description = "Tactile feedback for professional typists.",
                ImageUrl = "keyboard.jpg" },

            new Product { Id = 5, Name = "USB-C Hub", Price = 34.99m,
                Description = "7-in-1 hub with HDMI, USB, and SD card slots.",
                ImageUrl = "cport.jpg" },

            new Product { Id = 6, Name = "Portable Charger", Price = 29.99m,
                Description = "20,000mAh fast-charging power bank.",
                ImageUrl = "pb.jpg" },
        };

        public List<Product> GetProducts() => _products;

        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}