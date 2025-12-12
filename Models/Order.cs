using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShopDesktop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public string StoreAddress { get; set; }
        public string Recipient { get; set; }
        public decimal TotalAmount { get; set; }

        public static List<Order> LoadOrders()
        {
            var orders = new List<Order>();

            try
            {
                string query = @"
                select 
                    o.order_id,
                    u.full_name as customer_name,
                    o.order_date,
                    o.status,
                    o.store_address,
                    o.recipient,
                    ifnull(sum(op.quantity * op.price), 0) as total_amount
                from orders o
                join users u on o.user_id = u.user_id
                left join orderedproducts op on o.order_id = op.order_id
                group by 
                    o.order_id,
                    u.full_name,
                    o.order_date,
                    o.status,
                    o.store_address,
                    o.recipient
                order by o.order_date desc;
            ";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            orders.Add(new Order
                            {
                                OrderId = Convert.ToInt32(reader["order_id"]),
                                CustomerName = reader["customer_name"].ToString(),
                                OrderDate = Convert.ToDateTime(reader["order_date"]),
                                Status = reader["status"].ToString(),
                                StoreAddress = reader["store_address"].ToString(),
                                Recipient = reader["recipient"].ToString(),
                                TotalAmount = Convert.ToDecimal(reader["total_amount"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження замовлень: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orders;
        }

        public static string ChangeStatus(int orderId, string newStatus)
        {
            if (orderId <= 0)
            {
                return "Невірний ідентифікатор замовлення";
            }

            try
            {
                string query = $"update orders set status = '{newStatus}' where order_id = {orderId}";
                DbConfig.ExecuteQuery(query);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string UpdateInfo(int orderId, string storeAddress, string recipient)
        {
            if (orderId <= 0)
                return "Невірний ідентифікатор замовлення";

            if (string.IsNullOrEmpty(storeAddress))
                return "Введіть адресу магазину";

            if (string.IsNullOrEmpty(recipient))
                return "Введіть отримувача замовлення";

            try
            {
                string query = $@"update orders
                                      set store_address = '{storeAddress}',
                                      recipient = '{recipient}'
                                  where order_id = {orderId}";

                DbConfig.ExecuteQuery(query);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static (int orderId, string error) CreateOrder(int customerId, string recipient, List<Product> products)
        {
            if (customerId <= 0)
                return (0, "Невірний ідентифікатор клієнта");

            if (string.IsNullOrWhiteSpace(recipient))
                return (0, "Введіть отримувача замовлення");

            if (products == null || products.Count == 0)
                return (0, "Кошик порожній");

            try
            {
                string orderQuery = $"insert into orders (user_id, order_date, status, store_address, recipient) values ({customerId}, '{DateTime.Now:yyyy-MM-dd}', 'нове', '{"Магазин ZooShop"}', '{recipient}'); select last_insert_id() as order_id;";

                int orderId = 0;

                using (var reader = DbConfig.ReadData(orderQuery))
                {
                    if (reader != null && reader.Read())
                    {
                        orderId = reader.GetInt32("order_id");
                    }
                }

                if (orderId == 0)
                    return (0, "Не вдалося створити замовлення");

                foreach (var product in products)
                {
                    string orderItemsQuery = $"insert into orderedproducts (order_id, product_id, quantity, price) values ({orderId}, {product.ProductId}, 1, {product.Price.ToString(CultureInfo.InvariantCulture)})";

                    DbConfig.ExecuteQuery(orderItemsQuery);
                }

                ShoppingCart.ClearCart();

                return (orderId, null);
            }
            catch (Exception ex)
            {
                return (0, ex.Message);
            }
        }
    }
}