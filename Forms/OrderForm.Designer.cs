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

        private void InitializeComponent()
        {
            dataGridViewOrder = new DataGridView();
            lblCustomerInfo = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            lblFullName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblTotal = new Label();
            lblItemsCount = new Label();
            btnConfirmOrder = new Button();
            btnCancel = new Button();
            groupBoxCustomer = new GroupBox();
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
            dataGridViewOrder.Location = new Point(15, 25);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.RowHeadersVisible = false;
            dataGridViewOrder.Size = new Size(650, 200);
            dataGridViewOrder.TabIndex = 0;
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
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(120, 95);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 25);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(120, 130);
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
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.Location = new Point(20, 97);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 19);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Телефон:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(20, 132);
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
            lblTotal.Location = new Point(15, 240);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(128, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Загальна сума:";
            // 
            // lblItemsCount
            // 
            lblItemsCount.AutoSize = true;
            lblItemsCount.Font = new Font("Segoe UI", 10F);
            lblItemsCount.Location = new Point(15, 265);
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
            btnConfirmOrder.Location = new Point(400, 240);
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
            btnCancel.Location = new Point(540, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(lblCustomerInfo);
            groupBoxCustomer.Controls.Add(txtFullName);
            groupBoxCustomer.Controls.Add(lblFullName);
            groupBoxCustomer.Controls.Add(txtPhone);
            groupBoxCustomer.Controls.Add(lblEmail);
            groupBoxCustomer.Controls.Add(txtEmail);
            groupBoxCustomer.Controls.Add(lblPhone);
            groupBoxCustomer.Location = new Point(20, 20);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(400, 170);
            groupBoxCustomer.TabIndex = 12;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Дані клієнта";
            // 
            // groupBoxOrder
            // 
            groupBoxOrder.Controls.Add(dataGridViewOrder);
            groupBoxOrder.Controls.Add(lblTotal);
            groupBoxOrder.Controls.Add(btnCancel);
            groupBoxOrder.Controls.Add(lblItemsCount);
            groupBoxOrder.Controls.Add(btnConfirmOrder);
            groupBoxOrder.Location = new Point(20, 200);
            groupBoxOrder.Name = "groupBoxOrder";
            groupBoxOrder.Size = new Size(680, 300);
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

        private DataGridView dataGridViewOrder;
        private Label lblCustomerInfo;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label lblFullName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblTotal;
        private Label lblItemsCount;
        private Button btnConfirmOrder;
        private Button btnCancel;
        private GroupBox groupBoxCustomer;
        private GroupBox groupBoxOrder;

    }
}