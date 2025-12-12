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
        public string CategoryName { get; set; }
        public string ManufacturerName { get; set; }

        public static Dictionary<string, Product> GetProductsByCategory(int categoryId)
        {
            var productsList = new Dictionary<string, Product>();
            string query = $"select * from Products where category_id = {categoryId};";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader == null) return productsList;

                while (reader.Read())
                {
                    var product = new Product
                    {
                        ProductId = reader.GetInt32("product_id"),
                        Name = reader["name"].ToString(),
                        CategoryId = reader.GetInt32("category_id"),
                        ManufacturerId = reader.GetInt32("manufacturer_id"),
                        Price = reader.GetDecimal("price"),
                        StockQuantity = reader.GetInt32("stock_quantity"),
                        Weight = reader["weight"].ToString(),
                        AnimalAge = reader["animal_age"].ToString(),
                        ShelfLifeMonths = reader.GetInt32("shelf_life_months"),
                        Description = reader["description"].ToString()
                    };

                    productsList[product.ProductId.ToString()] = product;
                }
            }

            return productsList;
        }

        public static Product LoadById(int productId)
        {
            if (productId <= 0)
                return null;

            try
            {
                string query = $@"
                select 
                    p.product_id,
                    p.name as product_name,
                    p.price,
                    p.stock_quantity,
                    p.weight,
                    p.animal_age,
                    p.shelf_life_months,
                    p.description,
                    c.category_name,
                    m.manufacturer_name
                from products p
                left join categories c on p.category_id = c.category_id
                left join manufacturers m on p.manufacturer_id = m.manufacturer_id
                where p.product_id = {productId}";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        return new Product
                        {
                            ProductId = Convert.ToInt32(reader["product_id"]),
                            Name = reader["product_name"].ToString(),
                            Price = reader.GetDecimal("price"),
                            StockQuantity = reader.GetInt32("stock_quantity"),
                            Weight = reader["weight"].ToString(),
                            AnimalAge = reader["animal_age"].ToString(),
                            ShelfLifeMonths = reader.GetInt32("shelf_life_months"),
                            Description = reader["description"].ToString(),
                        };
                    }
                }
            }
            catch
            {

            }

            return null;
        }
    }
}
