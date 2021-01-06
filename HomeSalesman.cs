using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopManagementSystemCSharp
{
    public partial class HomeSalesman : Form
    {
        public HomeSalesman()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj = new FlowerShopManagementSystemCSharp.Customer();
            obj.ShowDialog();
        }

        private void addFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flower obj = new FlowerShopManagementSystemCSharp.Flower();
            obj.ShowDialog();
        }

        private void saleFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new FlowerShopManagementSystemCSharp.Purchase();
            obj.ShowDialog();
        }

        private void searchFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchFlowers obj = new FlowerShopManagementSystemCSharp.SearchFlowers();
            obj.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new FlowerShopManagementSystemCSharp.ViewCustomer();
            obj.ShowDialog();
        }

        private void flowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchasedFlowers obj = new ViewPurchasedFlowers();
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
