namespace FlowerShopManagementSystemCSharp
{
    partial class HomeSalesman
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.addFlowersToolStripMenuItem,
            this.saleFlowersToolStripMenuItem,
            this.searchFlowersToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 30);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // addFlowersToolStripMenuItem
            // 
            this.addFlowersToolStripMenuItem.Name = "addFlowersToolStripMenuItem";
            this.addFlowersToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.addFlowersToolStripMenuItem.Text = "Add Flowers";
            this.addFlowersToolStripMenuItem.Click += new System.EventHandler(this.addFlowersToolStripMenuItem_Click);
            // 
            // saleFlowersToolStripMenuItem
            // 
            this.saleFlowersToolStripMenuItem.Name = "saleFlowersToolStripMenuItem";
            this.saleFlowersToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.saleFlowersToolStripMenuItem.Text = "Sale Flowers";
            this.saleFlowersToolStripMenuItem.Click += new System.EventHandler(this.saleFlowersToolStripMenuItem_Click);
            // 
            // searchFlowersToolStripMenuItem
            // 
            this.searchFlowersToolStripMenuItem.Name = "searchFlowersToolStripMenuItem";
            this.searchFlowersToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.searchFlowersToolStripMenuItem.Text = "Search Flowers";
            this.searchFlowersToolStripMenuItem.Click += new System.EventHandler(this.searchFlowersToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.flowersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // flowersToolStripMenuItem
            // 
            this.flowersToolStripMenuItem.Name = "flowersToolStripMenuItem";
            this.flowersToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.flowersToolStripMenuItem.Text = "Flowers";
            this.flowersToolStripMenuItem.Click += new System.EventHandler(this.flowersToolStripMenuItem_Click);
            // 
            // HomeSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 533);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeSalesman";
            this.Text = "HomeSalesman";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowersToolStripMenuItem;
    }
}