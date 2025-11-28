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
            this.categoriesTabControl = new System.Windows.Forms.TabControl();
            this.catsTabPage = new System.Windows.Forms.TabPage();
            this.catsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dogsTabPage = new System.Windows.Forms.TabPage();
            this.dogsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.birdsTabPage = new System.Windows.Forms.TabPage();
            this.birdsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fishTabPage = new System.Windows.Forms.TabPage();
            this.fishFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            // 
            // categoriesTabControl
            // 
            this.categoriesTabControl.Controls.Add(this.catsTabPage);
            this.categoriesTabControl.Controls.Add(this.dogsTabPage);
            this.categoriesTabControl.Controls.Add(this.birdsTabPage);
            this.categoriesTabControl.Controls.Add(this.fishTabPage);
            this.categoriesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesTabControl.Location = new System.Drawing.Point(0, 0);
            this.categoriesTabControl.Name = "categoriesTabControl";
            this.categoriesTabControl.SelectedIndex = 0;
            this.categoriesTabControl.Size = new System.Drawing.Size(1000, 600);
            this.categoriesTabControl.TabIndex = 0;
            // 
            // catsTabPage
            // 
            this.catsTabPage.BackColor = System.Drawing.Color.White;
            this.catsTabPage.Controls.Add(this.catsFlowPanel);
            this.catsTabPage.Location = new System.Drawing.Point(4, 24);
            this.catsTabPage.Name = "catsTabPage";
            this.catsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.catsTabPage.Size = new System.Drawing.Size(992, 572);
            this.catsTabPage.TabIndex = 0;
            this.catsTabPage.Text = "Коти";
            // 
            // catsFlowPanel
            // 
            this.catsFlowPanel.AutoScroll = true;
            this.catsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.catsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catsFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.catsFlowPanel.Name = "catsFlowPanel";
            this.catsFlowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.catsFlowPanel.Size = new System.Drawing.Size(986, 566);
            this.catsFlowPanel.TabIndex = 0;
            // 
            // dogsTabPage
            // 
            this.dogsTabPage.BackColor = System.Drawing.Color.White;
            this.dogsTabPage.Controls.Add(this.dogsFlowPanel);
            this.dogsTabPage.Location = new System.Drawing.Point(4, 24);
            this.dogsTabPage.Name = "dogsTabPage";
            this.dogsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dogsTabPage.Size = new System.Drawing.Size(992, 572);
            this.dogsTabPage.TabIndex = 1;
            this.dogsTabPage.Text = "Собаки";
            // 
            // dogsFlowPanel
            // 
            this.dogsFlowPanel.AutoScroll = true;
            this.dogsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dogsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dogsFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.dogsFlowPanel.Name = "dogsFlowPanel";
            this.dogsFlowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.dogsFlowPanel.Size = new System.Drawing.Size(986, 566);
            this.dogsFlowPanel.TabIndex = 1;
            // 
            // birdsTabPage
            // 
            this.birdsTabPage.BackColor = System.Drawing.Color.White;
            this.birdsTabPage.Controls.Add(this.birdsFlowPanel);
            this.birdsTabPage.Location = new System.Drawing.Point(4, 24);
            this.birdsTabPage.Name = "birdsTabPage";
            this.birdsTabPage.Size = new System.Drawing.Size(992, 572);
            this.birdsTabPage.TabIndex = 2;
            this.birdsTabPage.Text = "Птахи";
            // 
            // birdsFlowPanel
            // 
            this.birdsFlowPanel.AutoScroll = true;
            this.birdsFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.birdsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birdsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.birdsFlowPanel.Name = "birdsFlowPanel";
            this.birdsFlowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.birdsFlowPanel.Size = new System.Drawing.Size(992, 572);
            this.birdsFlowPanel.TabIndex = 1;
            // 
            // fishTabPage
            // 
            this.fishTabPage.BackColor = System.Drawing.Color.White;
            this.fishTabPage.Controls.Add(this.fishFlowPanel);
            this.fishTabPage.Location = new System.Drawing.Point(4, 24);
            this.fishTabPage.Name = "fishTabPage";
            this.fishTabPage.Size = new System.Drawing.Size(992, 572);
            this.fishTabPage.TabIndex = 3;
            this.fishTabPage.Text = "Риби";
            // 
            // fishFlowPanel
            // 
            this.fishFlowPanel.AutoScroll = true;
            this.fishFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.fishFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fishFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.fishFlowPanel.Name = "fishFlowPanel";
            this.fishFlowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.fishFlowPanel.Size = new System.Drawing.Size(992, 572);
            this.fishFlowPanel.TabIndex = 1;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.categoriesTabControl);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог товарів";

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
    }
}