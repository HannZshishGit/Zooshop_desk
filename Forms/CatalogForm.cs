using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZooShopDesktop.Components;
using ZooShopDesktop.Models;

namespace ZooShopDesktop.Forms
{
    public partial class CatalogForm : Form
    {
        private Dictionary<string, Product> catsProducts = new Dictionary<string, Product>();
        private Dictionary<string, Product> dogsProducts = new Dictionary<string, Product>();
        private Dictionary<string, Product> birdsProducts = new Dictionary<string, Product>();
        private Dictionary<string, Product> fishProducts = new Dictionary<string, Product>();

        public CatalogForm()
        {
            InitializeComponent();
            LoadProductsData();
            RenderProducts();
        }

        private void LoadProductsData()
        {
            LoadCategoryProducts(1, catsProducts); // Коти
            LoadCategoryProducts(2, dogsProducts); // Собаки
            LoadCategoryProducts(3, birdsProducts); // Птахи
            LoadCategoryProducts(4, fishProducts); // Риби
        }

        private void LoadCategoryProducts(int categoryId, Dictionary<string, Product> productsList)
        {
            string query = $"SELECT * FROM Products WHERE category_id = {categoryId}";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader == null) return;

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
                        ShelfLifeMonths = reader["shelf_life_months"].ToString(),
                        Description = reader["description"].ToString()
                    };

                    productsList[product.ProductId.ToString()] = product;
                }
            }
        }

        private void RenderProducts()
        {
            RenderCategoryProducts(catsProducts, catsFlowPanel);
            RenderCategoryProducts(dogsProducts, dogsFlowPanel);
            RenderCategoryProducts(birdsProducts, birdsFlowPanel);
            RenderCategoryProducts(fishProducts, fishFlowPanel);
        }

        private void RenderCategoryProducts(Dictionary<string, Product> products, FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();

            foreach (var product in products.Values)
            {
                var productCard = new ProductCard(product);
                flowPanel.Controls.Add(productCard);
            }
        }
    }
}
