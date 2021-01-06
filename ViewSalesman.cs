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
    public partial class ViewSalesman : Form
    {
        public ViewSalesman()
        {
            InitializeComponent();
        }

        private void ViewSalesman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flowerDataSet4.salesman' table. You can move, or remove it, as needed.
            this.salesmanTableAdapter.Fill(this.flowerDataSet4.salesman);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-GT7B837G\SQLEXPRESS;Initial Catalog=FLOWER;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM salesman";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
