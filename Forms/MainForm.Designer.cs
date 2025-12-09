namespace ZooShopDesktop.Forms
{
    partial class MainForm
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
            panelHeader = new Panel();
            labelTitle = new Label();
            panelMain = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            btnCatalog = new Button();
            btnManagers = new Button();
            backgroundPictureBox = new PictureBox();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 100);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(50, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(213, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Зоомагазин";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(tableLayoutPanel);
            panelMain.Controls.Add(backgroundPictureBox);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1200, 700);
            panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(btnCatalog, 1, 0);
            tableLayoutPanel.Controls.Add(btnManagers, 0, 0);
            tableLayoutPanel.Location = new Point(200, 400);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(800, 200);
            tableLayoutPanel.TabIndex = 1;
            // 
            // btnCatalog
            // 
            btnCatalog.Anchor = AnchorStyles.None;
            btnCatalog.BackColor = Color.FromArgb(76, 175, 80);
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 142, 60);
            btnCatalog.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 160, 71);
            btnCatalog.FlatStyle = FlatStyle.Flat;
            btnCatalog.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCatalog.ForeColor = Color.White;
            btnCatalog.Image = Image.FromFile(@"C:\Users\Artur\Downloads\ZooShopDesktop\ZooShopDesktop\Images\cart.png");
            btnCatalog.ImageAlign = ContentAlignment.TopCenter;
            btnCatalog.Location = new Point(440, 30);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Padding = new Padding(0, 20, 0, 10);
            btnCatalog.Size = new Size(320, 140);
            btnCatalog.TabIndex = 2;
            btnCatalog.Text = "КАТАЛОГ ТОВАРІВ";
            btnCatalog.TextAlign = ContentAlignment.BottomCenter;
            btnCatalog.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCatalog.UseVisualStyleBackColor = false;
            btnCatalog.Click += btnCatalog_Click;
            // 
            // btnManagers
            // 
            btnManagers.Anchor = AnchorStyles.None;
            btnManagers.BackColor = Color.FromArgb(33, 150, 243);
            btnManagers.FlatAppearance.BorderSize = 0;
            btnManagers.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 118, 210);
            btnManagers.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 136, 229);
            btnManagers.FlatStyle = FlatStyle.Flat;
            btnManagers.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnManagers.ForeColor = Color.White;
            btnManagers.Image = Image.FromFile(@"C:\Users\Artur\Downloads\ZooShopDesktop\ZooShopDesktop\Images\manager.png");
            btnManagers.ImageAlign = ContentAlignment.TopCenter;
            btnManagers.Location = new Point(40, 30);
            btnManagers.Name = "btnManagers";
            btnManagers.Padding = new Padding(0, 20, 0, 10);
            btnManagers.Size = new Size(320, 140);
            btnManagers.TabIndex = 1;
            btnManagers.Text = "УПРАВЛІННЯ МЕНЕДЖЕРАМИ";
            btnManagers.TextAlign = ContentAlignment.BottomCenter;
            btnManagers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnManagers.UseVisualStyleBackColor = false;
            btnManagers.Click += btnManagers_Click;
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.Dock = DockStyle.Fill;
            backgroundPictureBox.Image = Image.FromFile(@"C:\Users\Artur\Downloads\ZooShopDesktop\ZooShopDesktop\Images\bg1.png");
            backgroundPictureBox.Location = new Point(0, 0);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(1200, 700);
            backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            backgroundPictureBox.TabIndex = 2;
            backgroundPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(1000, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головна форма - Управління зоомагазином";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
    }
}