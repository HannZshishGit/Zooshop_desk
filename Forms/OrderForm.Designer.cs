namespace ZooShopDesktop.Forms
{
    partial class OrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewOrder = new DataGridView();
            columnName = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnWeight = new DataGridViewTextBoxColumn();
            columnAnimalAge = new DataGridViewTextBoxColumn();
            lblCustomerInfo = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            lblFullName = new Label();
            lblEmail = new Label();
            lblTotal = new Label();
            lblItemsCount = new Label();
            btnConfirmOrder = new Button();
            btnCancel = new Button();
            groupBoxCustomer = new GroupBox();
            btnAddCustomer = new Button();
            groupBoxOrder = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            groupBoxCustomer.SuspendLayout();
            groupBoxOrder.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.AllowUserToDeleteRows = false;
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrder.BackgroundColor = Color.White;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Columns.AddRange(new DataGridViewColumn[] { columnName, columnPrice, columnWeight, columnAnimalAge });
            dataGridViewOrder.Location = new Point(15, 22);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.RowHeadersVisible = false;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewOrder.Size = new Size(650, 237);
            dataGridViewOrder.TabIndex = 0;
            // 
            // columnName
            // 
            columnName.DataPropertyName = "Name";
            columnName.FillWeight = 200F;
            columnName.HeaderText = "Назва товару";
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            // 
            // columnPrice
            // 
            columnPrice.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            columnPrice.DefaultCellStyle = dataGridViewCellStyle3;
            columnPrice.HeaderText = "Ціна (грн)";
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            // 
            // columnWeight
            // 
            columnWeight.DataPropertyName = "Weight";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            columnWeight.DefaultCellStyle = dataGridViewCellStyle4;
            columnWeight.HeaderText = "Вага (кг)";
            columnWeight.Name = "columnWeight";
            columnWeight.ReadOnly = true;
            // 
            // columnAnimalAge
            // 
            columnAnimalAge.DataPropertyName = "AnimalAge";
            columnAnimalAge.FillWeight = 120F;
            columnAnimalAge.HeaderText = "Вік тварини";
            columnAnimalAge.Name = "columnAnimalAge";
            columnAnimalAge.ReadOnly = true;
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerInfo.Location = new Point(20, 20);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(199, 21);
            lblCustomerInfo.TabIndex = 1;
            lblCustomerInfo.Text = "Інформація про клієнта";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(120, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 25);
            txtFullName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(120, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 25);
            txtEmail.TabIndex = 4;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.Location = new Point(20, 62);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(34, 19);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "ПІБ:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(20, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 122, 204);
            lblTotal.Location = new Point(15, 265);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(128, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Загальна сума:";
            // 
            // lblItemsCount
            // 
            lblItemsCount.AutoSize = true;
            lblItemsCount.Font = new Font("Segoe UI", 10F);
            lblItemsCount.Location = new Point(15, 286);
            lblItemsCount.Name = "lblItemsCount";
            lblItemsCount.Size = new Size(116, 19);
            lblItemsCount.TabIndex = 9;
            lblItemsCount.Text = "Кількість товарів:";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.FromArgb(40, 167, 69);
            btnConfirmOrder.FlatAppearance.BorderSize = 0;
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(399, 265);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(130, 40);
            btnConfirmOrder.TabIndex = 10;
            btnConfirmOrder.Text = "Підтвердити";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(108, 117, 125);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(535, 265);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(btnAddCustomer);
            groupBoxCustomer.Controls.Add(lblCustomerInfo);
            groupBoxCustomer.Controls.Add(txtFullName);
            groupBoxCustomer.Controls.Add(lblFullName);
            groupBoxCustomer.Controls.Add(lblEmail);
            groupBoxCustomer.Controls.Add(txtEmail);
            groupBoxCustomer.Location = new Point(20, 20);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(400, 171);
            groupBoxCustomer.TabIndex = 12;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Дані клієнта";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(0, 123, 255);
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(20, 130);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(350, 30);
            btnAddCustomer.TabIndex = 8;
            btnAddCustomer.Text = "Додати клієнта";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // groupBoxOrder
            // 
            groupBoxOrder.Controls.Add(dataGridViewOrder);
            groupBoxOrder.Controls.Add(lblTotal);
            groupBoxOrder.Controls.Add(btnCancel);
            groupBoxOrder.Controls.Add(lblItemsCount);
            groupBoxOrder.Controls.Add(btnConfirmOrder);
            groupBoxOrder.Location = new Point(20, 197);
            groupBoxOrder.Name = "groupBoxOrder";
            groupBoxOrder.Size = new Size(680, 311);
            groupBoxOrder.TabIndex = 13;
            groupBoxOrder.TabStop = false;
            groupBoxOrder.Text = "Замовлення";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(720, 520);
            Controls.Add(groupBoxOrder);
            Controls.Add(groupBoxCustomer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформлення замовлення";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            groupBoxOrder.ResumeLayout(false);
            groupBoxOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrder;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnWeight;
        private DataGridViewTextBoxColumn columnAnimalAge;
        private Label lblCustomerInfo;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblTotal;
        private Label lblItemsCount;
        private Button btnConfirmOrder;
        private Button btnCancel;
        private GroupBox groupBoxCustomer;
        private GroupBox groupBoxOrder;
        private Button btnAddCustomer;
    }
}