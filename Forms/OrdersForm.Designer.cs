using Mysqlx.Crud;
using Org.BouncyCastle.Cms;

namespace ZooShopDesktop.Forms
{
    partial class OrdersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblOrders = new Label();
            dgvOrders = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            StoreAddress = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Recipient = new DataGridViewTextBoxColumn();
            OrderId = new DataGridViewTextBoxColumn();
            gbOrderInfo = new GroupBox();
            txtRecipient = new TextBox();
            lblRecipient = new Label();
            btnCompleteOrder = new Button();
            btnProcessOrder = new Button();
            btnCancelOrder = new Button();
            btnUpdateOrder = new Button();
            txtStoreAddress = new TextBox();
            lblStoreAddress = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            gbOrderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrders.Location = new Point(12, 15);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(95, 19);
            lblOrders.TabIndex = 0;
            lblOrders.Text = "Замовлення";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { CustomerName, OrderDate, Status, StoreAddress, TotalAmount, Recipient, OrderId });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.Location = new Point(12, 40);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(682, 385);
            dgvOrders.TabIndex = 1;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "customer_name";
            CustomerName.FillWeight = 150F;
            CustomerName.HeaderText = "Клієнт";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.DataPropertyName = "order_date";
            OrderDate.HeaderText = "Дата";
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "status";
            Status.FillWeight = 120F;
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // StoreAddress
            // 
            StoreAddress.DataPropertyName = "store_address";
            StoreAddress.FillWeight = 200F;
            StoreAddress.HeaderText = "Адреса магазину";
            StoreAddress.Name = "StoreAddress";
            StoreAddress.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "total_amount";
            TotalAmount.HeaderText = "Сума (грн)";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // Recipient
            // 
            Recipient.HeaderText = "Отримувач";
            Recipient.Name = "Recipient";
            Recipient.ReadOnly = true;
            // 
            // OrderId
            // 
            OrderId.DataPropertyName = "order_id";
            OrderId.HeaderText = "OrderId";
            OrderId.Name = "OrderId";
            OrderId.ReadOnly = true;
            OrderId.Visible = false;
            // 
            // gbOrderInfo
            // 
            gbOrderInfo.Controls.Add(txtRecipient);
            gbOrderInfo.Controls.Add(lblRecipient);
            gbOrderInfo.Controls.Add(btnCompleteOrder);
            gbOrderInfo.Controls.Add(btnProcessOrder);
            gbOrderInfo.Controls.Add(btnCancelOrder);
            gbOrderInfo.Controls.Add(btnUpdateOrder);
            gbOrderInfo.Controls.Add(txtStoreAddress);
            gbOrderInfo.Controls.Add(lblStoreAddress);
            gbOrderInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbOrderInfo.Location = new Point(710, 40);
            gbOrderInfo.Name = "gbOrderInfo";
            gbOrderInfo.Size = new Size(350, 385);
            gbOrderInfo.TabIndex = 4;
            gbOrderInfo.TabStop = false;
            gbOrderInfo.Text = "Інформація про замовлення";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(150, 93);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(180, 23);
            txtRecipient.TabIndex = 17;
            txtRecipient.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Font = new Font("Segoe UI", 9F);
            lblRecipient.Location = new Point(20, 96);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(69, 15);
            lblRecipient.TabIndex = 16;
            lblRecipient.Text = "Отримувач";
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.BackColor = Color.FromArgb(76, 175, 80);
            btnCompleteOrder.FlatAppearance.BorderSize = 0;
            btnCompleteOrder.FlatStyle = FlatStyle.Flat;
            btnCompleteOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCompleteOrder.ForeColor = Color.White;
            btnCompleteOrder.Location = new Point(170, 270);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(160, 30);
            btnCompleteOrder.TabIndex = 13;
            btnCompleteOrder.Text = "Завершити";
            btnCompleteOrder.UseVisualStyleBackColor = false;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.BackColor = Color.FromArgb(33, 150, 243);
            btnProcessOrder.FlatAppearance.BorderSize = 0;
            btnProcessOrder.FlatStyle = FlatStyle.Flat;
            btnProcessOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProcessOrder.ForeColor = Color.White;
            btnProcessOrder.Location = new Point(20, 270);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(140, 30);
            btnProcessOrder.TabIndex = 12;
            btnProcessOrder.Text = "Обробити";
            btnProcessOrder.UseVisualStyleBackColor = false;
            btnProcessOrder.Click += btnProcessOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.BackColor = Color.FromArgb(244, 67, 54);
            btnCancelOrder.FlatAppearance.BorderSize = 0;
            btnCancelOrder.FlatStyle = FlatStyle.Flat;
            btnCancelOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelOrder.ForeColor = Color.White;
            btnCancelOrder.Location = new Point(170, 310);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(160, 30);
            btnCancelOrder.TabIndex = 11;
            btnCancelOrder.Text = "Скасувати";
            btnCancelOrder.UseVisualStyleBackColor = false;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnUpdateOrder
            // 
            btnUpdateOrder.BackColor = Color.FromArgb(255, 152, 0);
            btnUpdateOrder.FlatAppearance.BorderSize = 0;
            btnUpdateOrder.FlatStyle = FlatStyle.Flat;
            btnUpdateOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateOrder.ForeColor = Color.White;
            btnUpdateOrder.Location = new Point(20, 310);
            btnUpdateOrder.Name = "btnUpdateOrder";
            btnUpdateOrder.Size = new Size(140, 30);
            btnUpdateOrder.TabIndex = 10;
            btnUpdateOrder.Text = "Оновити";
            btnUpdateOrder.UseVisualStyleBackColor = false;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            // 
            // txtStoreAddress
            // 
            txtStoreAddress.Location = new Point(150, 26);
            txtStoreAddress.Multiline = true;
            txtStoreAddress.Name = "txtStoreAddress";
            txtStoreAddress.Size = new Size(180, 60);
            txtStoreAddress.TabIndex = 9;
            // 
            // lblStoreAddress
            // 
            lblStoreAddress.AutoSize = true;
            lblStoreAddress.Font = new Font("Segoe UI", 9F);
            lblStoreAddress.Location = new Point(20, 29);
            lblStoreAddress.Name = "lblStoreAddress";
            lblStoreAddress.Size = new Size(103, 15);
            lblStoreAddress.TabIndex = 8;
            lblStoreAddress.Text = "Адреса магазину:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(33, 150, 243);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(582, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 30);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Оновити";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 441);
            Controls.Add(btnRefresh);
            Controls.Add(gbOrderInfo);
            Controls.Add(dgvOrders);
            Controls.Add(lblOrders);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управління замовленнями";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            gbOrderInfo.ResumeLayout(false);
            gbOrderInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrders;
        private DataGridView dgvOrders;
        private GroupBox gbOrderInfo;
        private TextBox txtStoreAddress;
        private Label lblStoreAddress;
        private Button btnUpdateOrder;
        private Button btnCancelOrder;
        private Button btnProcessOrder;
        private Button btnCompleteOrder;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn StoreAddress;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Recipient;
        private DataGridViewTextBoxColumn OrderId;
        private TextBox txtRecipient;
        private Label lblRecipient;
    }
}