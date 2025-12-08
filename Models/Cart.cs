using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShopDesktop.Models
{
    public static class ShoppingCart
    {
        private static List<Product> items = new List<Product>();

        public static IReadOnlyList<Product> Products => items;

        public static void AddItem(Product product, int quantity = 1)
        {
            if (product == null)
            {
                return;
            }

            items.Add(product);
        }

        public static void ClearCart()
        {
            items.Clear();
        }
        public static decimal GetTotalPrice()
        {
            return items.Sum(p => p.Price);
        }

        public static int GetCount()
        {
            return items.Count;
        }
    }
}
