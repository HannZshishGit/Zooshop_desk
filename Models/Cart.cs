using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ZooShopDesktop.Models
{
    public static class ShoppingCart
    {
        private static List<Product> _items = new List<Product>();
        private static Dictionary<int, int> _quantities = new Dictionary<int, int>();

        public static List<Product> Items => _items;
        public static Dictionary<int, int> Quantities => _quantities;

        public static void AddItem(Product product, int quantity = 1)
        {
            var existingItem = _items.FirstOrDefault(item => item.ProductId == product.ProductId);

            if (existingItem != null)
            {
                _quantities[product.ProductId] += quantity;
            }
            else
            {
                _items.Add(product);
                _quantities[product.ProductId] = quantity;
            }
        }

        public static int GetQuantity(int productId)
        {
            return _quantities.ContainsKey(productId) ? _quantities[productId] : 0;
        }

        public static decimal GetTotalPrice()
        {
            return _items.Sum(item => item.Price * GetQuantity(item.ProductId));
        }

        public static int GetTotalItems()
        {
            return _quantities.Values.Sum();
        }
    }
}
