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
        private int customerId = 0;

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

            if (customerId == 0 || string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Спочатку знайдіть або додайте клієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string orderQuery = $"insert into Orders (user_id, order_date, status, store_address) values ({customerId}, '{DateTime.Now:yyyy-MM-dd}', 'нове', 'Магазин ZooShop'); select last_insert_id() as order_id;";

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
                    MessageBox.Show("Не вдалося створити замовлення");
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
            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    SearchCustomerByEmail(txtEmail.Text);
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Введіть email для пошуку клієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchCustomerByEmail(email);
        }

        private void SearchCustomerByEmail(string email)
        {
            try
            {
                string query = $"select user_id, full_name, phone, email_, role_ from users where email_ = '{email}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        customerId = reader.GetInt32("user_id");
                        txtFullName.Text = reader.GetString("full_name");

                        panelCustomerInfo.Visible = true;

                        if (!reader.IsDBNull(reader.GetOrdinal("phone")))
                        {
                            lblCustomerPhone.Text = reader.GetString("phone");
                        }
                        else
                        {
                            lblCustomerPhone.Text = "не вказано";
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("role_")))
                        {
                            string role = reader.GetString("role_");
                            lblCustomerRole.Text = role;

                            if (role != "Клієнт")
                            {
                                lblCustomerFound.ForeColor = Color.Orange;
                                lblCustomerFound.Text = "Користувач знайдений (не клієнт)";
                                btnConfirmOrder.Enabled = false;
                            }
                            else
                            {
                                lblCustomerFound.ForeColor = Color.Green;
                                lblCustomerFound.Text = "Клієнт знайдений";
                                btnConfirmOrder.Enabled = true;
                            }
                        }
                        else
                        {
                            lblCustomerRole.Text = "не вказано";
                            lblCustomerFound.ForeColor = Color.Green;
                            lblCustomerFound.Text = "Клієнт знайдений";
                            btnConfirmOrder.Enabled = true;
                        }
                    }
                    else
                    {
                        customerId = 0;
                        txtFullName.Clear();
                        panelCustomerInfo.Visible = true;
                        lblCustomerPhone.Text = "-";
                        lblCustomerRole.Text = "-";
                        lblCustomerFound.ForeColor = Color.Red;
                        lblCustomerFound.Text = "Користувач не знайдений";
                        btnConfirmOrder.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при пошуку клієнта: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ClearCustomerInfo();
        }

        private void ClearCustomerInfo()
        {
            customerId = 0;
            txtFullName.Clear();
            panelCustomerInfo.Visible = false;
            btnConfirmOrder.Enabled = false;
        }
    }
}