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
            btnRefresh = new Button();
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
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 60);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(298, 30);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Управління менеджерами";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(splitContainer);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1000, 540);
            panelMain.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(20, 20);
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
            splitContainer.Size = new Size(960, 500);
            splitContainer.SplitterDistance = 320;
            splitContainer.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(groupBoxUserInfo);
            panelForm.Controls.Add(panelButtons);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(320, 500);
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
            groupBoxUserInfo.Name = "groupBoxUserInfo";
            groupBoxUserInfo.Size = new Size(320, 334);
            groupBoxUserInfo.TabIndex = 0;
            groupBoxUserInfo.TabStop = false;
            groupBoxUserInfo.Text = "Додати нового менеджера";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(20, 303);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(280, 25);
            textBoxPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(20, 283);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(59, 19);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(20, 243);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(280, 25);
            textBoxEmail.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(20, 223);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(20, 183);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(280, 25);
            textBoxPhone.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(20, 163);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(119, 19);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Номер телефону:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(20, 123);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(280, 25);
            textBoxFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(20, 103);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(113, 19);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "Повне ім'я (ПІБ):";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnRefresh);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 334);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(320, 166);
            panelButtons.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(189, 189, 189);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(170, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
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
            btnDelete.Location = new Point(20, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
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
            btnUpdate.Location = new Point(170, 20);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 40);
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
            btnAdd.Location = new Point(20, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(0, 150, 136);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 116);
            btnRefresh.Name = "refreshBtn";
            btnRefresh.Size = new Size(130, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Оновити список";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += refreshBtn_Click;
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridViewManagers);
            panelData.Dock = DockStyle.Fill;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Size = new Size(636, 500);
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
            dataGridViewManagers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewManagers.Size = new Size(636, 500);
            dataGridViewManagers.TabIndex = 1;
            // 
            // Fullname
            // 
            Fullname.DataPropertyName = "full_name";
            Fullname.FillWeight = 200F;
            Fullname.HeaderText = "ПІБ";
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "email_";
            Email.FillWeight = 250F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "phone";
            Phone.FillWeight = 150F;
            Phone.HeaderText = "Телефон";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Id
            // 
            Id.DataPropertyName = "user_id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // ManagersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(800, 600);
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
        private Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewManagers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}