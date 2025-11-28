namespace ZooShopDesktop.Components
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        private Label nameLabel;
        private Label priceLabel;
        private Label stockLabel;
        private Label weightLabel;
        private Label ageLabel;
        private Label shelfLifeLabel;
        private void InitializeComponent()
        {
            nameLabel = new Label();
            priceLabel = new Label();
            stockLabel = new Label();
            weightLabel = new Label();
            ageLabel = new Label();
            shelfLifeLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nameLabel.Location = new Point(10, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(220, 40);
            nameLabel.TabIndex = 0;
            // 
            // priceLabel
            // 
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            priceLabel.ForeColor = Color.FromArgb(0, 120, 215);
            priceLabel.Location = new Point(10, 55);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(100, 20);
            priceLabel.TabIndex = 1;
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // stockLabel
            // 
            stockLabel.Font = new Font("Segoe UI", 8F);
            stockLabel.Location = new Point(10, 80);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(220, 15);
            stockLabel.TabIndex = 2;
            stockLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // weightLabel
            // 
            weightLabel.Font = new Font("Segoe UI", 8F);
            weightLabel.Location = new Point(10, 100);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(220, 15);
            weightLabel.TabIndex = 3;
            weightLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ageLabel
            // 
            ageLabel.Font = new Font("Segoe UI", 8F);
            ageLabel.Location = new Point(10, 120);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(220, 15);
            ageLabel.TabIndex = 4;
            ageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // shelfLifeLabel
            // 
            shelfLifeLabel.Font = new Font("Segoe UI", 8F);
            shelfLifeLabel.Location = new Point(10, 140);
            shelfLifeLabel.Name = "shelfLifeLabel";
            shelfLifeLabel.Size = new Size(220, 15);
            shelfLifeLabel.TabIndex = 5;
            shelfLifeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductCard
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(nameLabel);
            Controls.Add(priceLabel);
            Controls.Add(stockLabel);
            Controls.Add(weightLabel);
            Controls.Add(ageLabel);
            Controls.Add(shelfLifeLabel);
            Margin = new Padding(10);
            Name = "ProductCard";
            Padding = new Padding(10);
            Size = new Size(248, 168);
            ResumeLayout(false);
        }

        #endregion
    }
}