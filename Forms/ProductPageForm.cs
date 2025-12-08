using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooShopDesktop.Models;

namespace ZooShopDesktop.Forms
{
    public partial class ProductPageForm : Form
    {
        private readonly Product _product;

        public ProductPageForm(Product product)
        {
            InitializeComponent();
            _product = product;
            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                string query = @"
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
                    from Products p
                    left JOIN Categories c on p.category_id = c.category_id
                    left JOIN Manufacturers m on p.manufacturer_id = m.manufacturer_id
                    where p.product_id = " + _product.ProductId;

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.HasRows && reader.Read())
                    {
                        _product.Name = reader["product_name"].ToString();
                        _product.Price = reader.GetDecimal("price");
                        _product.StockQuantity = reader.GetInt32("stock_quantity");
                        _product.Weight = reader["weight"].ToString();
                        _product.AnimalAge = reader["animal_age"].ToString();
                        _product.ShelfLifeMonths = reader.GetInt32("shelf_life_months");
                        _product.Description = reader["description"].ToString();


                        lblProductName.Text = _product.Name;
                        lblPrice.Text = $"{_product.Price} грн";
                        lblCategory.Text = $"Категорія: {reader["category_name"].ToString()}";
                        lblManufacturer.Text = $"Виробник: {reader["manufacturer_name"].ToString()}";
                        lblStock.Text = $"На складі: {_product.StockQuantity} шт.";
                        lblWeight.Text = $"Вага: {_product.Weight}";
                        lblAnimalAge.Text = $"Вік: {_product.AnimalAge}";
                        lblShelfLife.Text = $"Термін придатності: {_product.ShelfLifeMonths} міс.";
                        txtDescription.Text = _product.Description;

                        if (_product.StockQuantity <= 0)
                        {
                            btnAddToCart.Enabled = false;
                            btnAddToCart.Text = "Немає в наявності";
                            btnAddToCart.BackColor = Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних товару: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (_product.StockQuantity <= 0)
            {
                MessageBox.Show("Товару немає в наявності", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShoppingCart.AddItem(_product);

            MessageBox.Show($"Товар \"{_product.Name}\" додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
