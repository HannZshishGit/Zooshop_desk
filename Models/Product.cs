using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShopDesktop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Weight { get; set; }
        public string AnimalAge { get; set; }
        public int ShelfLifeMonths { get; set; }
        public string Description { get; set; }
    }
}
