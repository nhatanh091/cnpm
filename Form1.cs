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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text == "admin" || textBox2.Text == "admin")
                {
                    MessageBox.Show("You are logged in successfully..");
                    this.Visible = false;
                    HomeAdmin obj1 = new HomeAdmin();
                    obj1.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GT7B837G\SQLEXPRESS;Initial Catalog=FLOWER;Integrated Security=True");
                con.Open();
                string str = "SELECT id FROM salesman WHERE name = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    HomeSalesman obj2 = new HomeSalesman();
                    obj2.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
            }
        }
    }
}
