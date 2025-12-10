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
using Org.BouncyCastle.Asn1.Cmp;

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
            try
            {
                string query = @"select 
                                    o.order_id,
                                    u.full_name as customer_name,
                                    o.order_date,
                                    o.status,
                                    o.store_address,
                                    o.recipient,
                                    ifnull(sum(op.quantity * op.price), 0) as total_amount
                                from Orders o
                                join Users u on o.user_id = u.user_id
                                left join OrderedProducts op on o.order_id = op.order_id
                                group by 
                                    o.order_id,
                                    u.full_name,
                                    o.order_date,
                                    o.status,
                                    o.store_address
                                order by o.order_date desc;";

                using (var reader = DbConfig.ReadData(query))
                {
                    dgvOrders.Rows.Clear();

                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            dgvOrders.Rows.Add(
                                reader["customer_name"],
                                reader["order_date"],
                                reader["status"],
                                reader["store_address"],
                                reader["total_amount"],
                                reader["recipient"],
                                reader["order_id"]
                            );
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Помилка завантаження замовлень: {exception.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var row = dgvOrders.SelectedRows[0];

            int orderId = Convert.ToInt32(row.Cells["OrderId"].Value);

            if (orderId == 0)
            {
                MessageBox.Show("Виберіть замовлення для оновлення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string storeAddress = txtStoreAddress.Text;
                string recipient = txtRecipient.Text;

                if (string.IsNullOrEmpty(storeAddress))
                {
                    MessageBox.Show("Введіть адресу магазину", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(recipient))
                {
                    MessageBox.Show("Введіть отримувача замовлення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = $@"update Orders 
                                    set
                                    store_address = '{storeAddress}',
                                    recipient = '{recipient}'
                                  where order_id = {orderId}";

                DbConfig.ExecuteQuery(query);

                MessageBox.Show("Інформацію про замовлення оновлено успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                string query = $"update Orders set status = '{newStatus}' where order_id = {orderId}";

                DbConfig.ExecuteQuery(query);
                MessageBox.Show($"Статус замовлення змінено на '{newStatus}'", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка зміни статусу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
