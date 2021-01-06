using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlowerShopManagementSystemCSharp
{
    public partial class ViewPurchasedFlowers : Form
    {
        public ViewPurchasedFlowers()
        {
            InitializeComponent();
        }

        private void ViewPurchasedFlowers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flowerDataSet3.purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.flowerDataSet3.purchase);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-GT7B837G\SQLEXPRESS;Initial Catalog=FLOWER;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM purchase";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
