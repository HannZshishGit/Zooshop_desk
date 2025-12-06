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
            string query = "select user_id, full_name, phone, email_, role_ from Users where role_ = 'Менеджер';";

            using (var reader = DbConfig.ReadData(query))
            {
                dataGridViewManagers.Rows.Clear();

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        dataGridViewManagers.Rows.Add(
                            reader["full_name"],
                            reader["email_"],
                            reader["phone"],
                            reader["user_id"]
                        );
                    }
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            string query = $"insert into Users (full_name, phone, email_, password_, role_) values ('{fullName}', '{phone}', '{email}', '{password}', 'Менеджер');";

            try
            {
                DbConfig.ExecuteQuery(query);

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

            string query = $"delete from Users where user_id = {userId}";

            DbConfig.ExecuteQuery(query);

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
            updateManagerForm.Show();
        }

        private void ClearTextBoxes()
        {
            textBoxFullName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
        }
    }
}
