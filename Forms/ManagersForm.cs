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
    public partial class ManagersForm : Form
    {
        public ManagersForm()
        {
            InitializeComponent();
            LoadManagers();
        }
        public void LoadManagers()
        {
            var managers = User.GetManagers();
            dataGridViewManagers.Rows.Clear();

            foreach (var manager in managers)
            {
                dataGridViewManagers.Rows.Add(
                    manager.FullName,
                    manager.Email,
                    manager.Phone ?? "-",
                    manager.UserId
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            try
            {
                User.AddManager(fullName, phone, email, password);

                MessageBox.Show("Нового менеджера булу успішно додано");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Помила: {exception}");
            }

            LoadManagers();

            ClearTextBoxes();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = dataGridViewManagers.SelectedRows[0];

            int userId = Convert.ToInt32(row.Cells["Id"].Value);

            var result = MessageBox.Show("Ви впевнені, що хочете видалити менеджера?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            string error = User.DeleteManager(userId);

            if (error != null)
            {
                MessageBox.Show($"Error: {error}");
            }

            LoadManagers();

            MessageBox.Show("Менеджера успішно видалено.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = dataGridViewManagers.SelectedRows[0];
            int userId = Convert.ToInt32(row.Cells["Id"].Value);

            UpdateManagerForm updateManagerForm = new UpdateManagerForm(userId);

            updateManagerForm.StartPosition = FormStartPosition.Manual;
            updateManagerForm.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - updateManagerForm.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - updateManagerForm.Height / 2);

            updateManagerForm.Show();
        }

        private void ClearTextBoxes()
        {
            textBoxFullName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadManagers();
        }
    }
}
