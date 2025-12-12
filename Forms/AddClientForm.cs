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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string FullName = txtFullName.Text;
            string Phone = txtPhone.Text;
            string Email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(FullName))
            {
                MessageBox.Show("Будь ласка, введіть ПІБ клієнта", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Phone))
            {
                MessageBox.Show("Будь ласка, введіть телефон клієнта", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Будь ласка, введіть email клієнта", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                string error = User.AddClient(FullName, Phone, Email);

                if (error == null)
                {
                    MessageBox.Show("Нового клієнта було успішно додано!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Помилка при додаванні клієнта: " + error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
