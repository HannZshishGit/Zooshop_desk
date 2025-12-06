namespace ZooShopDesktop.Forms
{
    partial class ManagersForm
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
            panelHeader = new Panel();
            labelTitle = new Label();
            panelMain = new Panel();
            splitContainer = new SplitContainer();
            panelForm = new Panel();
            groupBoxUserInfo = new GroupBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            panelButtons = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panelData = new Panel();
            dataGridViewManagers = new DataGridView();
            Fullname = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelForm.SuspendLayout();
            groupBoxUserInfo.SuspendLayout();
            panelButtons.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManagers).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 150, 243);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1143, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(23, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(371, 37);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Управління менеджерами";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(splitContainer);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(23, 27, 23, 27);
            panelMain.Size = new Size(1143, 720);
            panelMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(23, 27);
            splitContainer.Margin = new Padding(3, 4, 3, 4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(panelForm);
            splitContainer.Panel1MinSize = 300;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelData);
            splitContainer.Size = new Size(1097, 666);
            splitContainer.SplitterDistance = 365;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(groupBoxUserInfo);
            panelForm.Controls.Add(panelButtons);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Margin = new Padding(3, 4, 3, 4);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(365, 666);
            panelForm.TabIndex = 0;
            // 
            // groupBoxUserInfo
            // 
            groupBoxUserInfo.Controls.Add(textBoxPassword);
            groupBoxUserInfo.Controls.Add(labelPassword);
            groupBoxUserInfo.Controls.Add(textBoxEmail);
            groupBoxUserInfo.Controls.Add(labelEmail);
            groupBoxUserInfo.Controls.Add(textBoxPhone);
            groupBoxUserInfo.Controls.Add(labelPhone);
            groupBoxUserInfo.Controls.Add(textBoxFullName);
            groupBoxUserInfo.Controls.Add(labelFullName);
            groupBoxUserInfo.Dock = DockStyle.Fill;
            groupBoxUserInfo.Font = new Font("Segoe UI", 10F);
            groupBoxUserInfo.Location = new Point(0, 0);
            groupBoxUserInfo.Margin = new Padding(3, 4, 3, 4);
            groupBoxUserInfo.Name = "groupBoxUserInfo";
            groupBoxUserInfo.Padding = new Padding(3, 4, 3, 4);
            groupBoxUserInfo.Size = new Size(365, 506);
            groupBoxUserInfo.TabIndex = 0;
            groupBoxUserInfo.TabStop = false;
            groupBoxUserInfo.Text = "Додати нового менеджера";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(23, 404);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(319, 30);
            textBoxPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(23, 377);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 23);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(23, 324);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(319, 30);
            textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(23, 297);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 23);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(23, 244);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(319, 30);
            textBoxPhone.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(23, 217);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(146, 23);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Номер телефону:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(23, 164);
            textBoxFullName.Margin = new Padding(3, 4, 3, 4);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(319, 30);
            textBoxFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(23, 137);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(140, 23);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "Повне ім'я (ПІБ):";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnClear);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 506);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(365, 160);
            panelButtons.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(189, 189, 189);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(194, 93);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 53);
            btnClear.TabIndex = 3;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(23, 93);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 53);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 152, 0);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(194, 27);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 53);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Оновити";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(23, 27);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 53);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridViewManagers);
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(0, 0);
            panelData.Margin = new Padding(3, 4, 3, 4);
            panelData.Name = "panelData";
            panelData.Size = new Size(727, 666);
            panelData.TabIndex = 0;
            // 
            // dataGridViewManagers
            // 
            dataGridViewManagers.AllowUserToAddRows = false;
            dataGridViewManagers.AllowUserToDeleteRows = false;
            dataGridViewManagers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewManagers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewManagers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManagers.Columns.AddRange(new DataGridViewColumn[] { Fullname, Email, Phone, Id });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewManagers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewManagers.Dock = DockStyle.Fill;
            dataGridViewManagers.Location = new Point(0, 0);
            dataGridViewManagers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewManagers.MultiSelect = false;
            dataGridViewManagers.Name = "dataGridViewManagers";
            dataGridViewManagers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewManagers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewManagers.RowHeadersVisible = false;
            dataGridViewManagers.RowHeadersWidth = 51;
            dataGridViewManagers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewManagers.Size = new Size(727, 666);
            dataGridViewManagers.TabIndex = 1;
            // 
            // Fullname
            // 
            Fullname.DataPropertyName = "full_name";
            Fullname.FillWeight = 200F;
            Fullname.HeaderText = "ПІБ";
            Fullname.MinimumWidth = 6;
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "email_";
            Email.FillWeight = 250F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "phone";
            Phone.FillWeight = 150F;
            Phone.HeaderText = "Телефон";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "user_id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // ManagersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 784);
            Name = "ManagersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управління менеджерами";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            groupBoxUserInfo.ResumeLayout(false);
            groupBoxUserInfo.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewManagers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridViewManagers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}