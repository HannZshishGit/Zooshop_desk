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
            string recipient = txtRecipient.Text;

            var (orderId, error) = Order.CreateOrder(customerId, recipient, ShoppingCart.Products.ToList());

            if (error == null)
            {
                MessageBox.Show($"Замовлення #{orderId} успішно оформлено!\nКлієнт: {txtFullName.Text}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrderItems();
            }
            else
            {
                MessageBox.Show($"Помилка при оформленні замовлення: {error}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            User customer = User.FindByEmail(email);

            if (customer != null)
            {
                customerId = customer.UserId;
                txtFullName.Text = customer.FullName;
                panelCustomerInfo.Visible = true;
                lblCustomerPhone.Text = string.IsNullOrEmpty(customer.Phone) ? "не вказано" : customer.Phone;
                lblCustomerRole.Text = string.IsNullOrEmpty(customer.Role) ? "не вказано" : customer.Role;

                if (customer.Role != null && customer.Role != "Клієнт")
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