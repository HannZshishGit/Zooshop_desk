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
using ZooShopDesktop.Models;

namespace ZooShopDesktop.Forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            LoadOrderItems();
            CalculateTotal();
        }

        private void LoadOrderItems()
        {
            dataGridViewOrder.Rows.Clear();

            foreach (var product in ShoppingCart.Items)
            {
                int quantity = ShoppingCart.GetQuantity(product.ProductId);
                decimal totalPrice = product.Price * quantity;

                dataGridViewOrder.Rows.Add(
                    product.Name,
                    product.Price,
                    quantity,
                    totalPrice,
                    product.Weight,
                    product.AnimalAge
                );
            }
        }

        private void CalculateTotal()
        {
            decimal total = ShoppingCart.GetTotalPrice();
            lblTotal.Text = $"Загальна сума: {total} ₴";
            lblItemsCount.Text = $"Кількість товарів: {ShoppingCart.GetTotalItems()} шт.";
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (!ShoppingCart.Items.Any())
            {
                MessageBox.Show("Кошик порожній", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Підтвердити оформлення замовлення?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveOrder();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SaveOrder()
        {
            try
            {
                string orderQuery = $"INSERT INTO Orders (user_id, order_date, status, store_address) VALUES (NULL, '{DateTime.Now:yyyy-MM-dd}', 'нове', 'Магазин ZooShop'); SELECT LAST_INSERT_ID() as order_id;";

                using (var reader = DbConfig.ReadData(orderQuery))
                {
                    if (reader != null && reader.Read())
                    {
                        int orderId = reader.GetInt32("order_id");

                        foreach (var product in ShoppingCart.Items)
                        {
                            int quantity = ShoppingCart.GetQuantity(product.ProductId);

                            string orderItemsQuery = $"INSERT INTO OrderedProducts (order_id, product_id, quantity, price) VALUES ({orderId}, {product.ProductId}, {quantity}, {product.Price})";

                            DbConfig.ExecuteQuery(orderItemsQuery);
                        }

                        MessageBox.Show($"Замовлення №{orderId} успішно оформлено!\nКлієнт: {txtFullName.Text}\nТелефон: {txtPhone.Text}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Не вдалося отримати ID створеного замовлення");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оформленні замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
