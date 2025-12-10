//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ZooShopDesktop.Forms
//{
//    public partial class MainForm : Form
//    {
//        private string userRole;
//        public MainForm(string userRole)
//        {
//            userRole = userRole;

//            InitializeComponent();
//        }

//        private void btnCatalog_Click(object sender, EventArgs e)
//        {
//            CatalogForm catalogForm = new CatalogForm();
//            catalogForm.Show();
//        }

//        private void btnManagers_Click(object sender, EventArgs e)
//        {
//            ManagersForm managersForm = new ManagersForm();
//            managersForm.Show();
//        }
//    }
//}

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
        private Button btnOrders;

        public MainForm(string userRole)
        {
            this.userRole = userRole;

            InitializeComponent();

            if (this.userRole == "Менеджер")
            {
                btnOrders = new Button
                {
                    Anchor = AnchorStyles.None,
                    BackColor = Color.FromArgb(255, 152, 0),
                    FlatAppearance = {
                    BorderSize = 0,
                    MouseDownBackColor = Color.FromArgb(230, 126, 34),
                    MouseOverBackColor = Color.FromArgb(243, 156, 18)
                    },
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204),
                    ForeColor = Color.White,
                    Location = new Point(40, 30),
                    Name = "btnOrders",
                    Size = new Size(320, 150),
                    TabIndex = 1,
                    Text = "УПРАВЛІННЯ ЗАМОВЛЕННЯМИ",
                    TextAlign = ContentAlignment.MiddleCenter
                };


                tableLayoutPanel.Controls.Remove(btnManagers);

                tableLayoutPanel.Controls.Add(btnOrders, 0, 0);

                btnOrders.Click += btnOrders_Click;
            }
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

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
    }
}