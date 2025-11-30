namespace ZooShopDesktop.Forms
{
    partial class ProductPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProductName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblManufacturer = new Label();
            lblStock = new Label();
            lblWeight = new Label();
            lblAnimalAge = new Label();
            lblShelfLife = new Label();
            txtDescription = new TextBox();
            btnAddToCart = new Button();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProductName.Location = new Point(20, 20);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(158, 30);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Назва товару";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(0, 122, 204);
            lblPrice.Location = new Point(20, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 25);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "0 грн";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(20, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 19);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Категорія: ";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Segoe UI", 10F);
            lblManufacturer.Location = new Point(20, 130);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 19);
            lblManufacturer.TabIndex = 3;
            lblManufacturer.Text = "Виробник: ";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.Location = new Point(20, 160);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(75, 19);
            lblStock.TabIndex = 4;
            lblStock.Text = "На складі: ";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 10F);
            lblWeight.Location = new Point(20, 190);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(39, 19);
            lblWeight.TabIndex = 5;
            lblWeight.Text = "Вага:";
            // 
            // lblAnimalAge
            // 
            lblAnimalAge.AutoSize = true;
            lblAnimalAge.Font = new Font("Segoe UI", 10F);
            lblAnimalAge.Location = new Point(20, 220);
            lblAnimalAge.Name = "lblAnimalAge";
            lblAnimalAge.Size = new Size(34, 19);
            lblAnimalAge.TabIndex = 6;
            lblAnimalAge.Text = "Вік: ";
            // 
            // lblShelfLife
            // 
            lblShelfLife.AutoSize = true;
            lblShelfLife.Font = new Font("Segoe UI", 10F);
            lblShelfLife.Location = new Point(20, 250);
            lblShelfLife.Name = "lblShelfLife";
            lblShelfLife.Size = new Size(135, 19);
            lblShelfLife.TabIndex = 7;
            lblShelfLife.Text = "Термін придатності:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(20, 300);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(460, 120);
            txtDescription.TabIndex = 8;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(70, 130, 180);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(20, 440);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(460, 45);
            btnAddToCart.TabIndex = 9;
            btnAddToCart.Text = "Додати до кошика";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescription.Location = new Point(20, 275);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(49, 20);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Опис:";
            // 
            // ProductPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 500);
            Controls.Add(lblDescription);
            Controls.Add(btnAddToCart);
            Controls.Add(txtDescription);
            Controls.Add(lblShelfLife);
            Controls.Add(lblAnimalAge);
            Controls.Add(lblWeight);
            Controls.Add(lblStock);
            Controls.Add(lblManufacturer);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Деталі товару";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblManufacturer;
        private Label lblStock;
        private Label lblWeight;
        private Label lblAnimalAge;
        private Label lblShelfLife;
        private TextBox txtDescription;
        private Button btnAddToCart;
        private Label lblDescription;
    }
}