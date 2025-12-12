using MySql.Data.MySqlClient;
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
    public partial class AuthForm : Form
    {
        private string role;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, введіть коректні данні", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = User.LoginUser(email, password);

            switch (result.Status)
            {
                case LoginStatus.UserNotFound:
                case LoginStatus.WrongPassword:
                case LoginStatus.Error:
                    MessageBox.Show(result.Error, "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                case LoginStatus.Ok:
                    MessageBox.Show($"Вітаємо, {result.FullName}!\nВаша роль: {result.Role}", "Успішний вхід", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenMainForm(result.Role);
                    return;
            }
        }

        private void OpenMainForm(string userRole)
        {
            this.Hide();

            MainForm mainForm = new MainForm(userRole);
            mainForm.Show();
        }
    }
}
