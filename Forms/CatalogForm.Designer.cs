namespace ZooShopDesktop.Forms
{
    partial class CatalogForm
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
            categoriesTabControl = new TabControl();
            catsTabPage = new TabPage();
            catsFlowPanel = new FlowLayoutPanel();
            dogsTabPage = new TabPage();
            dogsFlowPanel = new FlowLayoutPanel();
            birdsTabPage = new TabPage();
            birdsFlowPanel = new FlowLayoutPanel();
            fishTabPage = new TabPage();
            fishFlowPanel = new FlowLayoutPanel();
            filtersPanel = new Panel();
            resetFiltersButton = new Button();
            applyFiltersButton = new Button();
            groupAge = new GroupBox();
            chkAgeSenior = new CheckBox();
            chkAgeAdult = new CheckBox();
            chkAgeYoung = new CheckBox();
            chkAgeAllAges = new CheckBox();
            groupWeight = new GroupBox();
            chkWeightLarge = new CheckBox();
            chkWeightMedium = new CheckBox();
            chkWeightSmall = new CheckBox();
            chkWeightAllWeights = new CheckBox();
            groupPrice = new GroupBox();
            txtMaxPrice = new TextBox();
            txtMinPrice = new TextBox();
            lblMaxPrice = new Label();
            lblMinPrice = new Label();
            groupShelfLife = new GroupBox();
            chkShelfLifeLong = new CheckBox();
            chkShelfLifeMedium = new CheckBox();
            chkShelfLifeShort = new CheckBox();
            chkShelfLifeAll = new CheckBox();
            filtersTitleLabel = new Label();
            btnCart = new Button();
            lblCartBadge = new Label();
            categoriesTabControl.SuspendLayout();
            catsTabPage.SuspendLayout();
            dogsTabPage.SuspendLayout();
            birdsTabPage.SuspendLayout();
            fishTabPage.SuspendLayout();
            filtersPanel.SuspendLayout();
            groupAge.SuspendLayout();
            groupWeight.SuspendLayout();
            groupPrice.SuspendLayout();
            groupShelfLife.SuspendLayout();
            SuspendLayout();
            // 
            // categoriesTabControl
            // 
            categoriesTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesTabControl.Controls.Add(catsTabPage);
            categoriesTabControl.Controls.Add(dogsTabPage);
            categoriesTabControl.Controls.Add(birdsTabPage);
            categoriesTabControl.Controls.Add(fishTabPage);
            categoriesTabControl.Location = new Point(250, 50);
            categoriesTabControl.Name = "categoriesTabControl";
            categoriesTabControl.SelectedIndex = 0;
            categoriesTabControl.Size = new Size(750, 550);
            categoriesTabControl.TabIndex = 0;
            // 
            // catsTabPage
            // 
            catsTabPage.BackColor = Color.White;
            catsTabPage.Controls.Add(catsFlowPanel);
            catsTabPage.Location = new Point(4, 24);
            catsTabPage.Name = "catsTabPage";
            catsTabPage.Padding = new Padding(3);
            catsTabPage.Size = new Size(742, 522);
            catsTabPage.TabIndex = 0;
            catsTabPage.Text = "Коти";
            // 
            // catsFlowPanel
            // 
            catsFlowPanel.AutoScroll = true;
            catsFlowPanel.BackColor = Color.FromArgb(245, 245, 245);
            catsFlowPanel.Dock = DockStyle.Fill;
            catsFlowPanel.Location = new Point(3, 3);
            catsFlowPanel.Name = "catsFlowPanel";
            catsFlowPanel.Padding = new Padding(15);
            catsFlowPanel.Size = new Size(736, 516);
            catsFlowPanel.TabIndex = 0;
            // 
            // dogsTabPage
            // 
            dogsTabPage.BackColor = Color.White;
            dogsTabPage.Controls.Add(dogsFlowPanel);
            dogsTabPage.Location = new Point(4, 24);
            dogsTabPage.Name = "dogsTabPage";
            dogsTabPage.Padding = new Padding(3);
            dogsTabPage.Size = new Size(742, 522);
            dogsTabPage.TabIndex = 1;
            dogsTabPage.Text = "Собаки";
            // 
            // dogsFlowPanel
            // 
            dogsFlowPanel.AutoScroll = true;
            dogsFlowPanel.BackColor = Color.FromArgb(245, 245, 245);
            dogsFlowPanel.Dock = DockStyle.Fill;
            dogsFlowPanel.Location = new Point(3, 3);
            dogsFlowPanel.Name = "dogsFlowPanel";
            dogsFlowPanel.Padding = new Padding(15);
            dogsFlowPanel.Size = new Size(736, 516);
            dogsFlowPanel.TabIndex = 1;
            // 
            // birdsTabPage
            // 
            birdsTabPage.BackColor = Color.White;
            birdsTabPage.Controls.Add(birdsFlowPanel);
            birdsTabPage.Location = new Point(4, 24);
            birdsTabPage.Name = "birdsTabPage";
            birdsTabPage.Size = new Size(742, 522);
            birdsTabPage.TabIndex = 2;
            birdsTabPage.Text = "Птахи";
            // 
            // birdsFlowPanel
            // 
            birdsFlowPanel.AutoScroll = true;
            birdsFlowPanel.BackColor = Color.FromArgb(245, 245, 245);
            birdsFlowPanel.Dock = DockStyle.Fill;
            birdsFlowPanel.Location = new Point(0, 0);
            birdsFlowPanel.Name = "birdsFlowPanel";
            birdsFlowPanel.Padding = new Padding(15);
            birdsFlowPanel.Size = new Size(742, 522);
            birdsFlowPanel.TabIndex = 1;
            // 
            // fishTabPage
            // 
            fishTabPage.BackColor = Color.White;
            fishTabPage.Controls.Add(fishFlowPanel);
            fishTabPage.Location = new Point(4, 24);
            fishTabPage.Name = "fishTabPage";
            fishTabPage.Size = new Size(742, 522);
            fishTabPage.TabIndex = 3;
            fishTabPage.Text = "Риби";
            // 
            // fishFlowPanel
            // 
            fishFlowPanel.AutoScroll = true;
            fishFlowPanel.BackColor = Color.FromArgb(245, 245, 245);
            fishFlowPanel.Dock = DockStyle.Fill;
            fishFlowPanel.Location = new Point(0, 0);
            fishFlowPanel.Name = "fishFlowPanel";
            fishFlowPanel.Padding = new Padding(15);
            fishFlowPanel.Size = new Size(742, 522);
            fishFlowPanel.TabIndex = 1;
            // 
            // filtersPanel
            // 
            filtersPanel.BackColor = Color.FromArgb(248, 250, 252);
            filtersPanel.BorderStyle = BorderStyle.FixedSingle;
            filtersPanel.Controls.Add(resetFiltersButton);
            filtersPanel.Controls.Add(applyFiltersButton);
            filtersPanel.Controls.Add(groupAge);
            filtersPanel.Controls.Add(groupWeight);
            filtersPanel.Controls.Add(groupPrice);
            filtersPanel.Controls.Add(groupShelfLife);
            filtersPanel.Controls.Add(filtersTitleLabel);
            filtersPanel.Dock = DockStyle.Left;
            filtersPanel.Location = new Point(0, 0);
            filtersPanel.Name = "filtersPanel";
            filtersPanel.Size = new Size(250, 600);
            filtersPanel.TabIndex = 1;
            // 
            // resetFiltersButton
            // 
            resetFiltersButton.BackColor = Color.FromArgb(108, 117, 125);
            resetFiltersButton.FlatAppearance.BorderSize = 0;
            resetFiltersButton.FlatStyle = FlatStyle.Flat;
            resetFiltersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resetFiltersButton.ForeColor = Color.White;
            resetFiltersButton.Location = new Point(130, 560);
            resetFiltersButton.Name = "resetFiltersButton";
            resetFiltersButton.Size = new Size(100, 30);
            resetFiltersButton.TabIndex = 10;
            resetFiltersButton.Text = "Скинути";
            resetFiltersButton.UseVisualStyleBackColor = false;
            resetFiltersButton.Click += resetFiltersButton_Click;
            // 
            // applyFiltersButton
            // 
            applyFiltersButton.BackColor = Color.FromArgb(40, 167, 69);
            applyFiltersButton.FlatAppearance.BorderSize = 0;
            applyFiltersButton.FlatStyle = FlatStyle.Flat;
            applyFiltersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            applyFiltersButton.ForeColor = Color.White;
            applyFiltersButton.Location = new Point(20, 560);
            applyFiltersButton.Name = "applyFiltersButton";
            applyFiltersButton.Size = new Size(100, 30);
            applyFiltersButton.TabIndex = 9;
            applyFiltersButton.Text = "Застосувати";
            applyFiltersButton.UseVisualStyleBackColor = false;
            applyFiltersButton.Click += applyFiltersButton_Click;
            // 
            // groupAge
            // 
            groupAge.BackColor = Color.Transparent;
            groupAge.Controls.Add(chkAgeSenior);
            groupAge.Controls.Add(chkAgeAdult);
            groupAge.Controls.Add(chkAgeYoung);
            groupAge.Controls.Add(chkAgeAllAges);
            groupAge.FlatStyle = FlatStyle.Flat;
            groupAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupAge.ForeColor = Color.FromArgb(33, 37, 41);
            groupAge.Location = new Point(15, 50);
            groupAge.Name = "groupAge";
            groupAge.Size = new Size(220, 120);
            groupAge.TabIndex = 8;
            groupAge.TabStop = false;
            groupAge.Text = "Вік тварини";
            // 
            // chkAgeSenior
            // 
            chkAgeSenior.AutoSize = true;
            chkAgeSenior.FlatStyle = FlatStyle.Flat;
            chkAgeSenior.Font = new Font("Segoe UI", 9F);
            chkAgeSenior.ForeColor = Color.FromArgb(73, 80, 87);
            chkAgeSenior.Location = new Point(10, 95);
            chkAgeSenior.Name = "chkAgeSenior";
            chkAgeSenior.Size = new Size(74, 19);
            chkAgeSenior.TabIndex = 3;
            chkAgeSenior.Text = "Старший";
            chkAgeSenior.UseVisualStyleBackColor = true;
            // 
            // chkAgeAdult
            // 
            chkAgeAdult.AutoSize = true;
            chkAgeAdult.FlatStyle = FlatStyle.Flat;
            chkAgeAdult.Font = new Font("Segoe UI", 9F);
            chkAgeAdult.ForeColor = Color.FromArgb(73, 80, 87);
            chkAgeAdult.Location = new Point(10, 70);
            chkAgeAdult.Name = "chkAgeAdult";
            chkAgeAdult.Size = new Size(79, 19);
            chkAgeAdult.TabIndex = 2;
            chkAgeAdult.Text = "Дорослий";
            chkAgeAdult.UseVisualStyleBackColor = true;
            // 
            // chkAgeYoung
            // 
            chkAgeYoung.AutoSize = true;
            chkAgeYoung.FlatStyle = FlatStyle.Flat;
            chkAgeYoung.Font = new Font("Segoe UI", 9F);
            chkAgeYoung.ForeColor = Color.FromArgb(73, 80, 87);
            chkAgeYoung.Location = new Point(10, 45);
            chkAgeYoung.Name = "chkAgeYoung";
            chkAgeYoung.Size = new Size(75, 19);
            chkAgeYoung.TabIndex = 1;
            chkAgeYoung.Text = "Молодий";
            chkAgeYoung.UseVisualStyleBackColor = true;
            // 
            // chkAgeAllAges
            // 
            chkAgeAllAges.AutoSize = true;
            chkAgeAllAges.Checked = true;
            chkAgeAllAges.CheckState = CheckState.Checked;
            chkAgeAllAges.FlatStyle = FlatStyle.Flat;
            chkAgeAllAges.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAgeAllAges.ForeColor = Color.FromArgb(13, 110, 253);
            chkAgeAllAges.Location = new Point(10, 20);
            chkAgeAllAges.Name = "chkAgeAllAges";
            chkAgeAllAges.Size = new Size(39, 19);
            chkAgeAllAges.TabIndex = 0;
            chkAgeAllAges.Text = "Всі";
            chkAgeAllAges.UseVisualStyleBackColor = true;
            // 
            // groupWeight
            // 
            groupWeight.BackColor = Color.Transparent;
            groupWeight.Controls.Add(chkWeightLarge);
            groupWeight.Controls.Add(chkWeightMedium);
            groupWeight.Controls.Add(chkWeightSmall);
            groupWeight.Controls.Add(chkWeightAllWeights);
            groupWeight.FlatStyle = FlatStyle.Flat;
            groupWeight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupWeight.ForeColor = Color.FromArgb(33, 37, 41);
            groupWeight.Location = new Point(15, 180);
            groupWeight.Name = "groupWeight";
            groupWeight.Size = new Size(220, 120);
            groupWeight.TabIndex = 7;
            groupWeight.TabStop = false;
            groupWeight.Text = "Вага";
            // 
            // chkWeightLarge
            // 
            chkWeightLarge.AutoSize = true;
            chkWeightLarge.FlatStyle = FlatStyle.Flat;
            chkWeightLarge.Font = new Font("Segoe UI", 9F);
            chkWeightLarge.ForeColor = Color.FromArgb(73, 80, 87);
            chkWeightLarge.Location = new Point(10, 95);
            chkWeightLarge.Name = "chkWeightLarge";
            chkWeightLarge.Size = new Size(62, 19);
            chkWeightLarge.TabIndex = 3;
            chkWeightLarge.Text = "Велика";
            chkWeightLarge.UseVisualStyleBackColor = true;
            // 
            // chkWeightMedium
            // 
            chkWeightMedium.AutoSize = true;
            chkWeightMedium.FlatStyle = FlatStyle.Flat;
            chkWeightMedium.Font = new Font("Segoe UI", 9F);
            chkWeightMedium.ForeColor = Color.FromArgb(73, 80, 87);
            chkWeightMedium.Location = new Point(10, 70);
            chkWeightMedium.Name = "chkWeightMedium";
            chkWeightMedium.Size = new Size(69, 19);
            chkWeightMedium.TabIndex = 2;
            chkWeightMedium.Text = "Середня";
            chkWeightMedium.UseVisualStyleBackColor = true;
            // 
            // chkWeightSmall
            // 
            chkWeightSmall.AutoSize = true;
            chkWeightSmall.FlatStyle = FlatStyle.Flat;
            chkWeightSmall.Font = new Font("Segoe UI", 9F);
            chkWeightSmall.ForeColor = Color.FromArgb(73, 80, 87);
            chkWeightSmall.Location = new Point(10, 45);
            chkWeightSmall.Name = "chkWeightSmall";
            chkWeightSmall.Size = new Size(53, 19);
            chkWeightSmall.TabIndex = 1;
            chkWeightSmall.Text = "Мала";
            chkWeightSmall.UseVisualStyleBackColor = true;
            // 
            // chkWeightAllWeights
            // 
            chkWeightAllWeights.AutoSize = true;
            chkWeightAllWeights.Checked = true;
            chkWeightAllWeights.CheckState = CheckState.Checked;
            chkWeightAllWeights.FlatStyle = FlatStyle.Flat;
            chkWeightAllWeights.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkWeightAllWeights.ForeColor = Color.FromArgb(13, 110, 253);
            chkWeightAllWeights.Location = new Point(10, 20);
            chkWeightAllWeights.Name = "chkWeightAllWeights";
            chkWeightAllWeights.Size = new Size(39, 19);
            chkWeightAllWeights.TabIndex = 0;
            chkWeightAllWeights.Text = "Всі";
            chkWeightAllWeights.UseVisualStyleBackColor = true;
            // 
            // groupPrice
            // 
            groupPrice.BackColor = Color.Transparent;
            groupPrice.Controls.Add(txtMaxPrice);
            groupPrice.Controls.Add(txtMinPrice);
            groupPrice.Controls.Add(lblMaxPrice);
            groupPrice.Controls.Add(lblMinPrice);
            groupPrice.FlatStyle = FlatStyle.Flat;
            groupPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupPrice.ForeColor = Color.FromArgb(33, 37, 41);
            groupPrice.Location = new Point(15, 310);
            groupPrice.Name = "groupPrice";
            groupPrice.Size = new Size(220, 80);
            groupPrice.TabIndex = 6;
            groupPrice.TabStop = false;
            groupPrice.Text = "Ціна (грн)";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMaxPrice.Font = new Font("Segoe UI", 9F);
            txtMaxPrice.Location = new Point(50, 47);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(100, 23);
            txtMaxPrice.TabIndex = 3;
            // 
            // txtMinPrice
            // 
            txtMinPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMinPrice.Font = new Font("Segoe UI", 9F);
            txtMinPrice.Location = new Point(50, 22);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(100, 23);
            txtMinPrice.TabIndex = 2;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Font = new Font("Segoe UI", 9F);
            lblMaxPrice.ForeColor = Color.FromArgb(73, 80, 87);
            lblMaxPrice.Location = new Point(10, 50);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(25, 15);
            lblMaxPrice.TabIndex = 1;
            lblMaxPrice.Text = "До:";
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Font = new Font("Segoe UI", 9F);
            lblMinPrice.ForeColor = Color.FromArgb(73, 80, 87);
            lblMinPrice.Location = new Point(10, 25);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(26, 15);
            lblMinPrice.TabIndex = 0;
            lblMinPrice.Text = "Від:";
            // 
            // groupShelfLife
            // 
            groupShelfLife.BackColor = Color.Transparent;
            groupShelfLife.Controls.Add(chkShelfLifeLong);
            groupShelfLife.Controls.Add(chkShelfLifeMedium);
            groupShelfLife.Controls.Add(chkShelfLifeShort);
            groupShelfLife.Controls.Add(chkShelfLifeAll);
            groupShelfLife.FlatStyle = FlatStyle.Flat;
            groupShelfLife.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupShelfLife.ForeColor = Color.FromArgb(33, 37, 41);
            groupShelfLife.Location = new Point(15, 400);
            groupShelfLife.Name = "groupShelfLife";
            groupShelfLife.Size = new Size(220, 120);
            groupShelfLife.TabIndex = 9;
            groupShelfLife.TabStop = false;
            groupShelfLife.Text = "Термін придатності";
            // 
            // chkShelfLifeLong
            // 
            chkShelfLifeLong.AutoSize = true;
            chkShelfLifeLong.FlatStyle = FlatStyle.Flat;
            chkShelfLifeLong.Font = new Font("Segoe UI", 9F);
            chkShelfLifeLong.ForeColor = Color.FromArgb(73, 80, 87);
            chkShelfLifeLong.Location = new Point(10, 95);
            chkShelfLifeLong.Name = "chkShelfLifeLong";
            chkShelfLifeLong.Size = new Size(63, 19);
            chkShelfLifeLong.TabIndex = 3;
            chkShelfLifeLong.Text = "Довгий";
            chkShelfLifeLong.UseVisualStyleBackColor = true;
            // 
            // chkShelfLifeMedium
            // 
            chkShelfLifeMedium.AutoSize = true;
            chkShelfLifeMedium.FlatStyle = FlatStyle.Flat;
            chkShelfLifeMedium.Font = new Font("Segoe UI", 9F);
            chkShelfLifeMedium.ForeColor = Color.FromArgb(73, 80, 87);
            chkShelfLifeMedium.Location = new Point(10, 70);
            chkShelfLifeMedium.Name = "chkShelfLifeMedium";
            chkShelfLifeMedium.Size = new Size(73, 19);
            chkShelfLifeMedium.TabIndex = 2;
            chkShelfLifeMedium.Text = "Середній";
            chkShelfLifeMedium.UseVisualStyleBackColor = true;
            // 
            // chkShelfLifeShort
            // 
            chkShelfLifeShort.AutoSize = true;
            chkShelfLifeShort.FlatStyle = FlatStyle.Flat;
            chkShelfLifeShort.Font = new Font("Segoe UI", 9F);
            chkShelfLifeShort.ForeColor = Color.FromArgb(73, 80, 87);
            chkShelfLifeShort.Location = new Point(10, 45);
            chkShelfLifeShort.Name = "chkShelfLifeShort";
            chkShelfLifeShort.Size = new Size(76, 19);
            chkShelfLifeShort.TabIndex = 1;
            chkShelfLifeShort.Text = "Короткий";
            chkShelfLifeShort.UseVisualStyleBackColor = true;
            // 
            // chkShelfLifeAll
            // 
            chkShelfLifeAll.AutoSize = true;
            chkShelfLifeAll.Checked = true;
            chkShelfLifeAll.CheckState = CheckState.Checked;
            chkShelfLifeAll.FlatStyle = FlatStyle.Flat;
            chkShelfLifeAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkShelfLifeAll.ForeColor = Color.FromArgb(13, 110, 253);
            chkShelfLifeAll.Location = new Point(10, 20);
            chkShelfLifeAll.Name = "chkShelfLifeAll";
            chkShelfLifeAll.Size = new Size(39, 19);
            chkShelfLifeAll.TabIndex = 0;
            chkShelfLifeAll.Text = "Всі";
            chkShelfLifeAll.UseVisualStyleBackColor = true;
            // 
            // filtersTitleLabel
            // 
            filtersTitleLabel.AutoSize = true;
            filtersTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            filtersTitleLabel.ForeColor = Color.FromArgb(33, 37, 41);
            filtersTitleLabel.Location = new Point(15, 20);
            filtersTitleLabel.Name = "filtersTitleLabel";
            filtersTitleLabel.Size = new Size(73, 21);
            filtersTitleLabel.TabIndex = 0;
            filtersTitleLabel.Text = "Фільтри";
            // 
            // btnCart
            // 
            btnCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCart.BackColor = Color.FromArgb(70, 130, 180);
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCart.ForeColor = Color.White;
            btnCart.Location = new Point(850, 10);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(120, 35);
            btnCart.TabIndex = 2;
            btnCart.Text = "Кошик";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // lblCartBadge
            // 
            lblCartBadge.Location = new Point(0, 0);
            lblCartBadge.Name = "lblCartBadge";
            lblCartBadge.Size = new Size(100, 23);
            lblCartBadge.TabIndex = 0;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(lblCartBadge);
            Controls.Add(btnCart);
            Controls.Add(filtersPanel);
            Controls.Add(categoriesTabControl);
            Name = "CatalogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог товарів";
            categoriesTabControl.ResumeLayout(false);
            catsTabPage.ResumeLayout(false);
            dogsTabPage.ResumeLayout(false);
            birdsTabPage.ResumeLayout(false);
            fishTabPage.ResumeLayout(false);
            filtersPanel.ResumeLayout(false);
            filtersPanel.PerformLayout();
            groupAge.ResumeLayout(false);
            groupAge.PerformLayout();
            groupWeight.ResumeLayout(false);
            groupWeight.PerformLayout();
            groupPrice.ResumeLayout(false);
            groupPrice.PerformLayout();
            groupShelfLife.ResumeLayout(false);
            groupShelfLife.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl categoriesTabControl;
        private System.Windows.Forms.TabPage catsTabPage;
        private System.Windows.Forms.FlowLayoutPanel catsFlowPanel;
        private System.Windows.Forms.TabPage dogsTabPage;
        private System.Windows.Forms.FlowLayoutPanel dogsFlowPanel;
        private System.Windows.Forms.TabPage birdsTabPage;
        private System.Windows.Forms.FlowLayoutPanel birdsFlowPanel;
        private System.Windows.Forms.TabPage fishTabPage;
        private System.Windows.Forms.FlowLayoutPanel fishFlowPanel;
        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.Button resetFiltersButton;
        private System.Windows.Forms.Button applyFiltersButton;
        private System.Windows.Forms.Label filtersTitleLabel;
        private GroupBox groupAge;
        private CheckBox chkAgeSenior;
        private CheckBox chkAgeAdult;
        private CheckBox chkAgeYoung;
        private CheckBox chkAgeAllAges;
        private GroupBox groupWeight;
        private CheckBox chkWeightLarge;
        private CheckBox chkWeightMedium;
        private CheckBox chkWeightSmall;
        private CheckBox chkWeightAllWeights;
        private GroupBox groupPrice;
        private TextBox txtMaxPrice;
        private TextBox txtMinPrice;
        private Label lblMaxPrice;
        private Label lblMinPrice;
        private GroupBox groupShelfLife;
        private CheckBox chkShelfLifeLong;
        private CheckBox chkShelfLifeMedium;
        private CheckBox chkShelfLifeShort;
        private CheckBox chkShelfLifeAll;
        private Button btnCart;
        private Label lblCartBadge;
    }
}