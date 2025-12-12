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
            string fullname = textBoxFullName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;

            if (string.IsNullOrWhiteSpace(fullname))
            {
                MessageBox.Show("Введіть ПІБ менеджера.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Введіть номер телефону.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Введіть email.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string err = User.UpdateManager(fullname, phone, email, managerId);

            if (err != null)
            {
                MessageBox.Show($"Помилка при оновленні даних: {err}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Дані менеджера успішно оновлено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();

            var managerForm = this.FindForm() as ManagersForm;
            if (managerForm != null)
            {
                managerForm.LoadManagers();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadManagerData()
        {
            User manager = User.LoadById(managerId);

            if (manager != null)
            {
                textBoxFullName.Text = manager.FullName;
                textBoxEmail.Text = manager.Email;
                textBoxPhone.Text = manager.Phone;
            }
            else
            {
                MessageBox.Show("Не вдалося завантажити дані менеджера", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
