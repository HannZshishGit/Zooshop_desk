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
using ZooShopDesktop.Components;
using ZooShopDesktop.Models;

namespace ZooShopDesktop.Forms
{
    public partial class CatalogForm : Form
    {
        private Dictionary<string, Product> catsProducts = new Dictionary<string, Product>();
        private Dictionary<string, Product> dogsProducts = new Dictionary<string, Product>();
        private Dictionary<string, Product> birdsProducts = new Dictionary<string, Product>();
        private Dictionary<string, Product> fishProducts = new Dictionary<string, Product>();

        private bool isProgrammaticChange = false;

        public CatalogForm()
        {
            InitializeComponent();
            LoadProductsData();
            RenderProducts();
        }

        private void LoadProductsData()
        {
            catsProducts = Product.GetProductsByCategory(1);
            dogsProducts = Product.GetProductsByCategory(2);
            birdsProducts = Product.GetProductsByCategory(3);
            fishProducts = Product.GetProductsByCategory(4);
        }

        private void RenderProducts()
        {
            RenderCategoryProducts(catsProducts, catsFlowPanel);
            RenderCategoryProducts(dogsProducts, dogsFlowPanel);
            RenderCategoryProducts(birdsProducts, birdsFlowPanel);
            RenderCategoryProducts(fishProducts, fishFlowPanel);
        }

        private void RenderCategoryProducts(Dictionary<string, Product> products, FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();

            foreach (var product in products.Values)
            {
                var productCard = new ProductCard(product);
                flowPanel.Controls.Add(productCard);
            }
        }

        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            // Фільтр віку
            var selectedAges = new List<string>();
            if (chkAgeYoung.Checked) selectedAges.Add("Молодий");
            if (chkAgeAdult.Checked) selectedAges.Add("Дорослий");
            if (chkAgeSenior.Checked) selectedAges.Add("Старший");

            // Фільтр ваги
            var selectedWeights = new List<string>();
            if (chkWeightSmall.Checked) selectedWeights.AddRange(new[] { "0.2 kg", "0.25 kg", "0.3 kg", "0.35 kg", "0.38 kg", "0.4 kg", "0.45 kg", "0.5 kg" });
            if (chkWeightMedium.Checked) selectedWeights.AddRange(new[] { "1.5 kg", "1.8 kg", "2 kg", "2.5 kg", "2.8 kg", "3 kg" });

            // Фільтр сроку придатності
            var selectedShelfLives = new List<int>();
            if (chkShelfLifeShort.Checked) selectedShelfLives.AddRange(new[] { 3, 6, 7, 8, 10, 12 });
            if (chkShelfLifeMedium.Checked) selectedShelfLives.AddRange(new[] { 18, 20 });
            if (chkShelfLifeLong.Checked) selectedShelfLives.AddRange(new[] { 24, 36 });

            decimal? minPrice = null;
            decimal? maxPrice = null;

            if (!string.IsNullOrWhiteSpace(txtMinPrice.Text) && decimal.TryParse(txtMinPrice.Text, out decimal min))
            {
                minPrice = min;
            }

            if (!string.IsNullOrWhiteSpace(txtMaxPrice.Text) && decimal.TryParse(txtMaxPrice.Text, out decimal max))
            {
                maxPrice = max;
            }

            FilterAndRenderCategory(catsProducts, catsFlowPanel, selectedAges, selectedWeights, selectedShelfLives, minPrice, maxPrice);
            FilterAndRenderCategory(dogsProducts, dogsFlowPanel, selectedAges, selectedWeights, selectedShelfLives, minPrice, maxPrice);
            FilterAndRenderCategory(birdsProducts, birdsFlowPanel, selectedAges, selectedWeights, selectedShelfLives, minPrice, maxPrice);
            FilterAndRenderCategory(fishProducts, fishFlowPanel, selectedAges, selectedWeights, selectedShelfLives, minPrice, maxPrice);
        }

        private void FilterAndRenderCategory(Dictionary<string, Product> products, FlowLayoutPanel flowPanel, List<string> selectedAges, List<string> selectedWeights, List<int> selectedShelfLives, decimal? minPrice, decimal? maxPrice)
        {
            flowPanel.Controls.Clear();

            var filteredProducts = products.Values.Where(product =>
            {
                if (selectedAges.Any() && !selectedAges.Contains(product.AnimalAge))
                {
                    return false;
                }


                if (selectedWeights.Any() && !selectedWeights.Contains(product.Weight))
                {
                    return false;
                }

                if (selectedShelfLives.Any() && !selectedShelfLives.Contains(product.ShelfLifeMonths))
                {
                    return false;
                }

                if (minPrice.HasValue && product.Price < minPrice.Value)
                {
                    return false;
                }

                if (maxPrice.HasValue && product.Price > maxPrice.Value)
                {
                    return false;
                }

                return true;
            });

            if (!filteredProducts.Any())
            {
                var label = new Label
                {
                    Text = "Товари не знайдено",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Margin = new Padding(10)
                };
                flowPanel.Controls.Add(label);
                return;
            }

            foreach (var product in filteredProducts)
            {
                var productCard = new ProductCard(product);
                flowPanel.Controls.Add(productCard);
            }
        }

        private void resetFiltersButton_Click(object sender, EventArgs e)
        {
            isProgrammaticChange = true;

            chkAgeAllAges.Checked = true;
            chkAgeYoung.Checked = false;
            chkAgeAdult.Checked = false;
            chkAgeSenior.Checked = false;

            chkWeightAllWeights.Checked = true;
            chkWeightSmall.Checked = false;
            chkWeightMedium.Checked = false;
            chkWeightLarge.Checked = false;

            chkShelfLifeAll.Checked = true;
            chkShelfLifeShort.Checked = false;
            chkShelfLifeMedium.Checked = false;
            chkShelfLifeLong.Checked = false;

            txtMinPrice.Text = "";
            txtMaxPrice.Text = "";

            isProgrammaticChange = false;

            RenderProducts();
        }

        private void chkAgeAllAges_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkAgeAllAges.Checked)
            {
                chkAgeYoung.Checked = false;
                chkAgeAdult.Checked = false;
                chkAgeSenior.Checked = false;
            }
        }

        private void chkAgeYoung_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkAgeYoung.Checked)
            {
                chkAgeAllAges.Checked = false;
            }
        }

        private void chkAgeAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkAgeAdult.Checked)
            {
                chkAgeAllAges.Checked = false;
            }
        }

        private void chkAgeSenior_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkAgeSenior.Checked)
            {
                chkAgeAllAges.Checked = false;
            }
        }

        private void chkWeightAllWeights_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkWeightAllWeights.Checked)
            {
                chkWeightSmall.Checked = false;
                chkWeightMedium.Checked = false;
                chkWeightLarge.Checked = false;
            }
        }

        private void chkWeightSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkWeightSmall.Checked)
            {
                chkWeightAllWeights.Checked = false;
            }
        }

        private void chkWeightMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkWeightMedium.Checked)
            {
                chkWeightAllWeights.Checked = false;
            }
        }

        private void chkWeightLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkWeightLarge.Checked)
            {
                chkWeightAllWeights.Checked = false;
            }
        }

        private void chkShelfLifeAll_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkShelfLifeAll.Checked)
            {
                chkShelfLifeShort.Checked = false;
                chkShelfLifeMedium.Checked = false;
                chkShelfLifeLong.Checked = false;
            }
        }

        private void chkShelfLifeShort_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkShelfLifeShort.Checked)
            {
                chkShelfLifeAll.Checked = false;
            }
        }

        private void chkShelfLifeMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkShelfLifeMedium.Checked)
            {
                chkShelfLifeAll.Checked = false;
            }
        }

        private void chkShelfLifeLong_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
            {
                return;
            }

            if (chkShelfLifeLong.Checked)
            {
                chkShelfLifeAll.Checked = false;
            }
        }

        private void txtMinPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMaxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OrderForm cartForm = new OrderForm();
            cartForm.ShowDialog();
        }
    }
}