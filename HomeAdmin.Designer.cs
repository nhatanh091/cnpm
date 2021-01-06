namespace FlowerShopManagementSystemCSharp
{
    partial class HomeAdmin
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
            this.addSalesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.addSalesmanToolStripMenuItem,
            this.addFlowersToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.searchFlowersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 30);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // addSalesmanToolStripMenuItem
            // 
            this.addSalesmanToolStripMenuItem.Name = "addSalesmanToolStripMenuItem";
            this.addSalesmanToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.addSalesmanToolStripMenuItem.Text = "Add Salesman";
            this.addSalesmanToolStripMenuItem.Click += new System.EventHandler(this.addSalesmanToolStripMenuItem_Click);
            // 
            // addFlowersToolStripMenuItem
            // 
            this.addFlowersToolStripMenuItem.Name = "addFlowersToolStripMenuItem";
            this.addFlowersToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.addFlowersToolStripMenuItem.Text = "Add Flowers";
            this.addFlowersToolStripMenuItem.Click += new System.EventHandler(this.addFlowersToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.flowerToolStripMenuItem,
            this.salesmanToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // flowerToolStripMenuItem
            // 
            this.flowerToolStripMenuItem.Name = "flowerToolStripMenuItem";
            this.flowerToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.flowerToolStripMenuItem.Text = "Flower";
            this.flowerToolStripMenuItem.Click += new System.EventHandler(this.flowerToolStripMenuItem_Click);
            // 
            // salesmanToolStripMenuItem
            // 
            this.salesmanToolStripMenuItem.Name = "salesmanToolStripMenuItem";
            this.salesmanToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.salesmanToolStripMenuItem.Text = "Salesman";
            this.salesmanToolStripMenuItem.Click += new System.EventHandler(this.salesmanToolStripMenuItem_Click);
            // 
            // searchFlowersToolStripMenuItem
            // 
            this.searchFlowersToolStripMenuItem.Name = "searchFlowersToolStripMenuItem";
            this.searchFlowersToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.searchFlowersToolStripMenuItem.Text = "Search Flowers";
            this.searchFlowersToolStripMenuItem.Click += new System.EventHandler(this.searchFlowersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 583);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSalesmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}