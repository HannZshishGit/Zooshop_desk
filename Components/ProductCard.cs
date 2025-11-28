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

namespace ZooShopDesktop.Components
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public ProductCard(Product product) : this()
        {
            SetLabelText("nameLabel", product.Name);
            SetLabelText("priceLabel", $"{product.Price} ₴");
            SetLabelText("stockLabel", $"В наявності: {product.StockQuantity} шт.");
            SetLabelText("weightLabel", $"Вага: {product.Weight}");
            SetLabelText("ageLabel", $"Для: {(product.AnimalAge)}");
            SetLabelText("shelfLifeLabel", $"Термін: {product.ShelfLifeMonths} міс.");
        }

        private void SetLabelText(string labelName, string text)
        {
            var field = this.GetType().GetField(labelName,
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (field?.GetValue(this) is Label label)
            {
                label.Text = text;
            }
        }
    }
}
