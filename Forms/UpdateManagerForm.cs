using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooShopDesktop.Forms
{
    public partial class UpdateManagerForm : Form
    {
        private int managerId;

        public UpdateManagerForm(int id)
        {
            managerId = id;

            InitializeComponent();
            LoadManagerData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Введіть ПІБ менеджера.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введіть номер телефону.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Введіть email.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string updateQuery = $"update users set full_name = '{textBoxFullName.Text}', phone = '{textBoxPhone.Text}', email_ = '{textBoxEmail.Text}' where user_id = '{managerId}';";

                DbConfig.ExecuteQuery(updateQuery);

                MessageBox.Show("Дані менеджера успішно оновлено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

                var managerForm = this.FindForm() as ManagersForm;
                if (managerForm != null)
                {
                    managerForm.LoadManagers();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Помилка при оновленні даних: {exception.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadManagerData()
        {
            string query = $"select * from users where user_id = '{managerId}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        textBoxFullName.Text = reader["full_name"].ToString();
                        textBoxEmail.Text = reader["email_"].ToString();
                        textBoxPhone.Text = reader["phone"].ToString();
                    }
                }
            }
        }
    }
}
