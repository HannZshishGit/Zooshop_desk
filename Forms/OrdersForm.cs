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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            dgvOrders.Rows.Clear();
            var orders = Order.LoadOrders();

            foreach (var order in orders)
            {
                dgvOrders.Rows.Add(
                    order.CustomerName,
                    order.OrderDate,
                    order.Status,
                    order.StoreAddress,
                    order.TotalAmount,
                    order.Recipient,
                    order.OrderId
                );
            }
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus("опрацьовується");
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            ChangeOrderStatus("виконано");
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть замовлення для оновлення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderId"].Value);
            string storeAddress = txtStoreAddress.Text;
            string recipient = txtRecipient.Text;

            string error = Order.UpdateInfo(orderId, storeAddress, recipient);

            if (error == null)
            {
                MessageBox.Show("Інформацію про замовлення оновлено успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrders();
            }
            else
            {
                MessageBox.Show($"Помилка оновлення замовлення: {error}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете скасувати це замовлення?", "Підтвердження скасування", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ChangeOrderStatus("скасовано");
            }
        }

        private void ChangeOrderStatus(string newStatus)
        {
            var row = dgvOrders.SelectedRows[0];

            int orderId = Convert.ToInt32(row.Cells["OrderId"].Value);

            if (orderId == 0)
            {
                MessageBox.Show("Виберіть замовлення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string error = Order.ChangeStatus(orderId, newStatus);

            if (error == null)
            {
                MessageBox.Show($"Статус замовлення змінено на '{newStatus}'", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrders();
            }
            else
            {
                MessageBox.Show($"Помилка зміни статусу: {error}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
