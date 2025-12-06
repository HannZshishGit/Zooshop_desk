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
    public partial class MainForm : Form
    {
        private string userRole;
        public MainForm(string userRole)
        {
            userRole = userRole;

            InitializeComponent();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            ManagersForm managersForm = new ManagersForm();
            managersForm.Show();
        }
    }
}
