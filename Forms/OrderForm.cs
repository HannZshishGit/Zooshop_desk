using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            foreach (var product in ShoppingCart.Products)
            {
                dataGridViewOrder.Rows.Add(
                    product.Name,
                    product.Price,
                    product.Weight,
                    product.AnimalAge
                );
            }
        }

        private void CalculateTotal()
        {
            decimal total = ShoppingCart.GetTotalPrice();
            lblTotal.Text = $"Загальна сума: {total} ₴";
            lblItemsCount.Text = $"Кількість товарів: {ShoppingCart.GetCount()} шт.";
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (!ShoppingCart.Products.Any())
            {
                MessageBox.Show("Кошик порожній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Підтвердити оформлення замовлення?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Введіть дані клієнта для підтвердження замовлення");
                }

                SaveOrder();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SaveOrder()
        {
            string email = txtEmail.Text;
            string fullname = txtFullName.Text;

            string query = $"select user_id from users where email_ = '{email}'";

            int userId = 0;

            try
            {
                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        userId = reader.GetInt32("user_id");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Помилка при отриманні id клієнта: {exception}");
            }

            try
            {
                if (userId == 0)
                {
                    MessageBox.Show("Не вдалося знайти клієнта");
                    return;
                }

                string orderQuery = $"insert into Orders (user_id, order_date, status, store_address) values ({userId}, '{DateTime.Now:yyyy-MM-dd}', 'нове', 'Магазин ZooShop'); select last_insert_id() as order_id;";

                int orderId = 0;

                using (var reader = DbConfig.ReadData(orderQuery))
                {
                    if (reader != null && reader.Read())
                    {
                        orderId = reader.GetInt32("order_id");
                    }
                }

                if (orderId == 0)
                {
                    MessageBox.Show("Не вдалося знайти id замовлення");
                    return;
                }

                foreach (var product in ShoppingCart.Products)
                {
                    string orderItemsQuery = $"insert into OrderedProducts (order_id, product_id, quantity, price) values ({orderId}, {product.ProductId}, {1}, {product.Price.ToString(CultureInfo.InvariantCulture)})";

                    DbConfig.ExecuteQuery(orderItemsQuery);
                }

                ShoppingCart.ClearCart();

                MessageBox.Show($"Замовлення #{orderId} успішно оформлено!\nКлієнт: {txtFullName.Text}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оформленні замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShoppingCart.ClearCart();
            LoadOrderItems();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }
    }
}
