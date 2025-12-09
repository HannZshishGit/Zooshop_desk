namespace ZooShopDesktop.Forms
{
    partial class AuthForm
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
        private void InitializeComponent()
        {
            loginButton = new Button();
            emailLabel = new Label();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginPanel = new Panel();
            titleLabel = new Label();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(0, 122, 204);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(25, 175);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(250, 38);
            loginButton.TabIndex = 5;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(25, 60);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(42, 17);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9.5F);
            passwordLabel.Location = new Point(25, 115);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(58, 17);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 9.5F);
            emailTextBox.Location = new Point(25, 80);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(250, 24);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 9.5F);
            passwordTextBox.Location = new Point(25, 135);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 24);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(titleLabel);
            loginPanel.Controls.Add(emailLabel);
            loginPanel.Controls.Add(emailTextBox);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Location = new Point(242, 105);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(300, 250);
            loginPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(0, 122, 204);
            titleLabel.Location = new Point(75, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(150, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Авторизація";
            // 
            // AuthForm
            // 
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(784, 461);
            Controls.Add(loginPanel);
            Name = "AuthForm";
            Text = "Авторизація";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Panel loginPanel;
        private Label titleLabel;
    }
}