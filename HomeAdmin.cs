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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj = new FlowerShopManagementSystemCSharp.Customer();
            obj.ShowDialog();
        }

        private void addSalesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salesman obj = new Salesman();
            obj.ShowDialog();
        }

        private void addFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flower obj = new Flower();
            obj.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomer obj = new ViewCustomer();
            obj.ShowDialog();
        }

        private void flowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchasedFlowers obj = new ViewPurchasedFlowers();
            obj.ShowDialog();
        }

        private void salesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSalesman obj = new ViewSalesman();
            obj.ShowDialog();
        }

        private void searchFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchFlowers obj = new SearchFlowers();
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
    }
}
