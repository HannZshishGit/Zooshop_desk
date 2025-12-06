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
            pictureBoxLogo = new PictureBox();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(40, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(153, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Зоомагазин";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(tableLayoutPanel);
            panelMain.Controls.Add(pictureBoxLogo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(40);
            panelMain.Size = new Size(1000, 520);
            panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(btnCatalog, 1, 0);
            tableLayoutPanel.Controls.Add(btnManagers, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(40, 190);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(0, 20, 0, 0);
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(920, 290);
            tableLayoutPanel.TabIndex = 1;
            // 
            // btnCatalog
            // 
            btnCatalog.Anchor = AnchorStyles.None;
            btnCatalog.BackColor = Color.FromArgb(76, 175, 80);
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.FlatStyle = FlatStyle.Flat;
            btnCatalog.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCatalog.ForeColor = Color.White;
            btnCatalog.ImageAlign = ContentAlignment.TopCenter;
            btnCatalog.Location = new Point(540, 90);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Padding = new Padding(0, 10, 0, 10);
            btnCatalog.Size = new Size(300, 130);
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
            btnManagers.FlatStyle = FlatStyle.Flat;
            btnManagers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnManagers.ForeColor = Color.White;
            btnManagers.ImageAlign = ContentAlignment.TopCenter;
            btnManagers.Location = new Point(80, 90);
            btnManagers.Name = "btnManagers";
            btnManagers.Padding = new Padding(0, 10, 0, 10);
            btnManagers.Size = new Size(300, 130);
            btnManagers.TabIndex = 1;
            btnManagers.Text = "УПРАВЛІННЯ МЕНЕДЖЕРАМИ";
            btnManagers.TextAlign = ContentAlignment.BottomCenter;
            btnManagers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnManagers.UseVisualStyleBackColor = false;
            btnManagers.Click += btnManagers_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Location = new Point(40, 40);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(920, 150);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головна форма - Управління зоомагазином";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Timer timer;
    }
}