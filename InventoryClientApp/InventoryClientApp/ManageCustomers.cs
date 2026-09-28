using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryClientApp
{
    public partial class ManageCustomers : Form
    {
        private CustomerServiceRef.ICustomerService customerServiceRef;
        private OrderServiceRef.IOrderService orderServiceRef;

        private int userid;
        public ManageCustomers(int userid)
        {
            customerServiceRef = new CustomerServiceRef.CustomerServiceClient("WSHttpBinding_ICustomerService");
            orderServiceRef = new OrderServiceRef.OrderServiceClient("WSHttpBinding_IOrderService");
            this.userid = userid;
            InitializeComponent();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string custName = textBoxCustomerName.Text;
            string custPhone = textBoxCustomerPhoneNumber.Text;
            CustomerServiceRef.Customer cust = new CustomerServiceRef.Customer();
            cust.name = custName;
            cust.phone = custPhone;

            customerServiceRef.AddCustomer(cust);
            MessageBox.Show("redcord aded seccessfully 💚 ");
            textBoxCustomerName.Clear();
            textBoxCustomerPhoneNumber.Clear();


            textBoxCustomerName.Focus();
            populate();
        }
        void populate()
        {
            DataSet dataset = new DataSet();
            dataset = customerServiceRef.GetCustomerDataset();
            CustomersDataGridView.DataSource = dataset.Tables[0];
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCustomerID.Text);
            customerServiceRef.DeleteCustomer(id);
            MessageBox.Show("Customer has been deleted successfully");
            populate();
            
        }

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersDataGridView.Rows.Count)
            {
                textBoxCustomerID.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCustomerName.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCustomerPhoneNumber.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                int custid = int.Parse(textBoxCustomerID.Text);
                DataSet ds = orderServiceRef.GetOrdersByCust(custid);
                DataTable dt = ds.Tables[0];
                OrderLableCount.Text = dt.Rows[0][0].ToString();
                LableAmount.Text = dt.Rows[0][1].ToString();
                labelDate.Text = dt.Rows[0][2].ToString();

            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerPhoneNumber.Clear();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string CustomerId = textBoxCustomerID.Text;

            string customername = textBoxCustomerName.Text;

            string CustomerPhoneNumber = textBoxCustomerPhoneNumber.Text;

            CustomerServiceRef.Customer cust = new CustomerServiceRef.Customer();
            cust.Id = int.Parse(CustomerId);
            cust.name = customername;
            cust.phone = CustomerPhoneNumber;

            customerServiceRef.UpdateCustomer(cust);
            MessageBox.Show("Record updated seccessfully 💚 ");
            
            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerPhoneNumber.Clear();


            textBoxCustomerName.Focus();
            populate();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
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
    }

}
