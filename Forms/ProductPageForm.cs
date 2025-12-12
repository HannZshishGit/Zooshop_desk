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
        private Product _product;

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
                _product = Product.LoadById(_product.ProductId);

                if (_product != null)
                {
                    lblProductName.Text = _product.Name;
                    lblPrice.Text = $"{_product.Price} грн";
                    lblCategory.Text = $"Категорія: {_product.CategoryName}";
                    lblManufacturer.Text = $"Виробник: {_product.ManufacturerName}";
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
                    else
                    {
                        btnAddToCart.Enabled = true;
                        btnAddToCart.Text = "Додати в корзину";
                        btnAddToCart.BackColor = Color.FromArgb(255, 152, 0);
                    }
                }
                else
                {
                    MessageBox.Show("Товар не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
