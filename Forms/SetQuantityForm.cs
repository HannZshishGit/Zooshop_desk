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
    public partial class SetQuanityForm : Form
    {
        public int Quantity { get; private set; } = 1;

        public SetQuanityForm(int currentQuantity = 1)
        {
            InitializeComponent();
            Quantity = currentQuantity;
            txtQuantity.Text = currentQuantity.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                Quantity = quantity;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Введіть коректну кількість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
