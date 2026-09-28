using InventoryClientApp;
using InventoryClientApp.ProductServiceRef;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryClientApp
{
    public partial class ViewOrders : Form
    {
        private OrderServiceRef.IOrderService orderServiceRef;
        int flag = 0;
        int ordId;
        private int userid;
        public ViewOrders(int userid)
        {
            orderServiceRef = new OrderServiceRef.OrderServiceClient("WSHttpBinding_IOrderService");
            InitializeComponent();
            this.userid = userid;

        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void populateOrders()
        {
            DataSet datset = orderServiceRef.GetAllOrder();
            OrderdataGridView2.DataSource = datset.Tables[0];
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {

            ManageOrders manageOrders = new ManageOrders(userid);
            manageOrders.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers(userid);
            manageCustomers.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders(userid);
            manageOrders.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders(userid);
            viewOrders.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void OrderdataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ordId = Convert.ToInt32(OrderdataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());

            flag = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                MessageBox.Show("Select The Order");
            }
            else
            {
                ViewOrderDetails viewOrderDetails = new ViewOrderDetails(ordId, userid);
                viewOrderDetails.Show();
                this.Hide();
            }
        }
    }
}
