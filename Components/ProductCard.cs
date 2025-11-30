using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooShopDesktop.Forms;
using ZooShopDesktop.Models;

namespace ZooShopDesktop.Components
{
    public partial class ProductCard : UserControl
    {
        private readonly Product _product;

        public ProductCard(Product product)
        {
            InitializeComponent();

            _product = product;

            SetLabelText("nameLabel", product.Name);
            SetLabelText("priceLabel", $"{product.Price} ₴");
            SetLabelText("stockLabel", $"В наявності: {product.StockQuantity} шт.");
            SetLabelText("weightLabel", $"Вага: {product.Weight}");
            SetLabelText("ageLabel", $"Для: {(product.AnimalAge)}");
            SetLabelText("shelfLifeLabel", $"Термін: {product.ShelfLifeMonths} міс.");

            this.Click += ProductCard_Click;
            SubscribeAllControls(this);
        }

        private void SetLabelText(string labelName, string text)
        {
            var field = this.GetType().GetField(labelName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (field?.GetValue(this) is Label label)
            {
                label.Text = text;
            }
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                ProductPageForm productPageForm = new ProductPageForm(_product);
                productPageForm.ShowDialog();
            }
        }

        private void SubscribeAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += ProductCard_Click;
                SubscribeAllControls(control);
            }
        }
    }
}
