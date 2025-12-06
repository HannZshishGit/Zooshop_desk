namespace ZooShopDesktop.Forms
{
    partial class UpdateManagerForm
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
            textBoxFullName = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            labelFullName = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 10F);
            textBoxFullName.Location = new Point(20, 40);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(340, 25);
            textBoxFullName.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 10F);
            textBoxPhone.Location = new Point(20, 100);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(340, 25);
            textBoxPhone.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 10F);
            textBoxEmail.Location = new Point(20, 160);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(340, 25);
            textBoxEmail.TabIndex = 2;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 10F);
            labelFullName.Location = new Point(20, 20);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(113, 19);
            labelFullName.TabIndex = 4;
            labelFullName.Text = "Повне ім'я (ПІБ):";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 10F);
            labelPhone.Location = new Point(20, 80);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(119, 19);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Номер телефону:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.Location = new Point(20, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(76, 175, 80);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(189, 189, 189);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(200, 191);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 244);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelFullName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxFullName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateManagerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редагування менеджера";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox textBoxFullName;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Label labelFullName;
        private Label labelPhone;
        private Label labelEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}