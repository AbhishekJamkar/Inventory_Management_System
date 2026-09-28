using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryClientApp
{
    public partial class ViewOrderDetails : Form
    {
        private OrderDetailsServiceRef.IOrderDetails orderDetailsRef;
        private OrderServiceRef.IOrderService orderServiceRef;
        private int ord_id;
        private int userid;
        public ViewOrderDetails(int ord_id, int userid)
        {
            orderDetailsRef = new OrderDetailsServiceRef.OrderDetailsClient("WSHttpBinding_IOrderDetails");
            orderServiceRef = new OrderServiceRef.OrderServiceClient("WSHttpBinding_IOrderService");
            this.ord_id = ord_id;
            InitializeComponent();
            this.userid = userid;
        }

        private void ViewOrderDetails_Load(object sender, EventArgs e)
        {
            DataSet dataset = orderDetailsRef.GetProdutsByOrdId(this.ord_id);
            OrderdataGridView2.DataSource = dataset.Tables[0];

            OrderServiceRef.Order order = orderServiceRef.GetOrderById(this.ord_id);
            LableAmount.Text = order.amount.ToString();
            label4.Text = order.orderDate.ToString();

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

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders(userid);
            viewOrders.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
