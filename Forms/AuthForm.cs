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
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace ZooShopDesktop.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // Валидация полей
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть коректні данні", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = $"select user_id, email_, password_, role_, full_name from Users WHERE email_ = '{email}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.HasRows && reader.Read())
                    {
                        int userId = reader.GetInt32("user_id");
                        string storedEmail = reader["email_"].ToString();
                        string storedPassword = reader["password_"].ToString();
                        string role = reader["role_"].ToString();
                        string fullName = reader["full_name"].ToString();

                        if (password == storedPassword)
                        {
                            MessageBox.Show($"Вітаємо, {fullName}!\nВаша роль: {role}", "Успішний вхід", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            OpenMainForm(role);
                        }
                        else
                        {
                            MessageBox.Show("Невірний пароль", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            passwordTextBox.Clear();
                            passwordTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Користувача з таким email не знайдено", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailTextBox.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час входу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenMainForm(string userRole)
        {
            this.Hide();

            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }
    }
}
