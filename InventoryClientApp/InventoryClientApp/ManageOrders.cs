using InventoryClientApp.OrderDetailsServiceRef;
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
    public partial class ManageOrders : Form
    {
        private OrderServiceRef.IOrderService orderServiceRef;
        private CustomerServiceRef.ICustomerService customerServiceRef;
        private ProductServiceRef.IProductService productServiceRef;
        private CategoryServiceRef.ICategoryService categoryServiceRef;
        private OrderDetailsServiceRef.IOrderDetails orderDetailsRef;
        private int userid;
        public ManageOrders(int userid)
        {
            orderServiceRef = new OrderServiceRef.OrderServiceClient("WSHttpBinding_IOrderService");
            customerServiceRef = new CustomerServiceRef.CustomerServiceClient("WSHttpBinding_ICustomerService");
            productServiceRef = new ProductServiceRef.ProductServiceClient("WSHttpBinding_IProductService");
            categoryServiceRef = new CategoryServiceRef.CategoryServiceClient("WSHttpBinding_ICategoryService");
            orderDetailsRef = new OrderDetailsServiceRef.OrderDetailsClient("WSHttpBinding_IOrderDetails");
            InitializeComponent();
            this.userid = userid;

        }
        DataSet ds = new DataSet();
        string product, paymentMode;
        int num = 0;
        int uprice, totalprice, qty, idselected;
        int flag = 0;
        int sum = 0;
        int stock;
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            fillCategory();
            populateProducts();

            ds.Tables.Add("Products");
            ds.Tables[0].Columns.Add("Num", typeof(int));
            ds.Tables[0].Columns.Add("Product", typeof(string));
            ds.Tables[0].Columns.Add("Quantity", typeof(int));
            ds.Tables[0].Columns.Add("Uprice", typeof(int));
            ds.Tables[0].Columns.Add("TotalPrice", typeof(int));

            
            OrderdataGridView1.DataSource = ds.Tables[0];

        }

        // Customers table GridView
        void populate()
        {
            var dataset = new DataSet();
            dataset = customerServiceRef.GetCustomerDataset();
            CustomersDataGridView.DataSource = dataset.Tables[0];
        }
        // Product table GridView
        void populateProducts()
        {
            int catid = int.Parse(comboBoxSearch.SelectedValue.ToString());
            DataSet dataset = new DataSet();
            dataset = productServiceRef.GetProductCatDataSet(catid);
            ProductsDataGridView.DataSource = dataset.Tables[0];
        }
        // Get all Categories friom catergory table GridView
        void fillCategory()
        {
            DataSet dataset = categoryServiceRef.GetCategoryDataset();
            comboBoxSearch.ValueMember = "CatId";
            comboBoxSearch.DisplayMember = "CatName";
            comboBoxSearch.DataSource = dataset.Tables[0];
        }
        // ComboBox selection and Trie 
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int catid = int.Parse(comboBoxSearch.SelectedValue.ToString());
            DataSet dataset = new DataSet();
            dataset = productServiceRef.GetProductCatDataSet(catid);
            ProductsDataGridView.DataSource = dataset.Tables[0];
            
        }


        //Exit button 

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //select from the Customers gridview 
        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersDataGridView.Rows.Count)
            {
                textBoxCustomerId.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCustomerName.Text = CustomersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        //select from the product gridview 

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsDataGridView.Rows.Count)
            {
                idselected = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                product = ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                stock = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                uprice = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

                flag = 1; // Set the flag to 1 to indicate that a product has been selected
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders(userid);
            viewOrders.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            paymentMode = "CASH";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            paymentMode = "CARD";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            paymentMode = "ONLINE PAYMENT";
        }

        // ADD an order 
        private void buttonAddCostomer_Click(object sender, EventArgs e)
        {
            if (textBoxProductQty.Text == "")
            {
                MessageBox.Show("Enter the Quantity of the Products first");
            }
            else if (flag == 0) // Check if the flag is still 0, meaning no product has been selected
            {
                MessageBox.Show("Select the product");
            }
            else if (Convert.ToInt32(textBoxProductQty.Text) > stock)
            {
                MessageBox.Show("Not Enough stock available");
            }
            else
            {
                // Add the product to the order
                num = num + 1;
                qty = Convert.ToInt32(textBoxProductQty.Text);
                totalprice = qty * uprice;
                DataRow newRow = ds.Tables[0].NewRow();
                newRow["Num"] = num;
                newRow["Product"] = product;
                newRow["Quantity"] = qty;
                newRow["Uprice"] = uprice;
                newRow["TotalPrice"] = totalprice;
                ds.Tables[0].Rows.Add(newRow);

                OrderdataGridView1.DataSource = ds.Tables[0];
                sum = sum + totalprice;
                resultTotalAmount.Text = "" + sum.ToString();
                updateproduct();
            }
        }

        // UPDATE product Quantity after making an order
        void updateproduct()
        {
            if (Convert.ToInt32(textBoxProductQty.Text) == 0)
            {
                MessageBox.Show("you cannot make any other order is from this product");
            }
            else
            {
                int proId = idselected;
                ProductServiceRef.Product product = productServiceRef.GetProductById(proId);
                product.quantity = product.quantity - Convert.ToInt32(textBoxProductQty.Text);
                productServiceRef.UpdateProduct(product);

                populateProducts();

            }

        }
        // INSERT order function on click 
        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text == "" || textBoxCustomerName.Text == "" || resultTotalAmount.Text == "")
            {
                MessageBox.Show("Fill the data Correctly");
            }
            else
            {
                OrderServiceRef.Order order = new OrderServiceRef.Order();

                int customerid = int.Parse(textBoxCustomerId.Text);
                CustomerServiceRef.Customer cust = customerServiceRef.GetCustomerById(customerid);

                OrderServiceRef.Customer customer = new OrderServiceRef.Customer();
                customer.Id = cust.Id;
                customer.name = cust.name;
                customer.phone = cust.phone;

                
                string customername = textBoxCustomerName.Text;
                // Convert the date from the DateTimePicker to DateTime object
                DateTime orderDate = dateTimePicker1.Value;
                string resultattoalamount = resultTotalAmount.Text;

                order.amount = int.Parse(resultattoalamount);
                order.orderDate = orderDate;
                order.paymentMode = paymentMode;
                order.customer = customer;
                order.userid = userid;
                orderServiceRef.AddOrder(order);

                //Adding Orders (products) in database....
                List<OrderDetailsServiceRef.OrderDetails> orderDetailsList = new List<OrderDetailsServiceRef.OrderDetails>();

                // Iterate through the rows of the DataGridView
                foreach (DataGridViewRow row in OrderdataGridView1.Rows)
                {
                    // Skip the last row which is the new row for adding data
                    if (!row.IsNewRow)
                    {
                        // Create an object with the row data and add it to the list

                        OrderDetailsServiceRef.OrderDetails orderDetail = new OrderDetailsServiceRef.OrderDetails();
                        OrderServiceRef.Order or = orderServiceRef.GetLastInsertedOrder();
                        orderDetail.ord_id = or.orderid;
                        ProductServiceRef.Product product = productServiceRef.GetProductByName(row.Cells["Product"].Value.ToString());
                        orderDetail.pro_id = product.id;
                        orderDetail.prod_amount = Convert.ToInt32(row.Cells["TotalPrice"].Value);
                        orderDetail.prod_qty = Convert.ToInt32(row.Cells["Quantity"].Value);


                        orderDetailsList.Add(orderDetail);
                    }
                }

                OrderDetailsServiceRef.OrderDetails[] orderDetailsArray = orderDetailsList.ToArray();
                orderDetailsRef.AddOrderDetails(orderDetailsArray);



                MessageBox.Show("Order added seccessfully 💚 ");


                textBoxOrderId.Clear();
                textBoxCustomerId.Clear();
                textBoxCustomerName.Clear();
                OrderdataGridView1.DataSource = null;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                textBoxProductQty.Text = "";



            }
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders(userid);
            view.Show();
            this.Hide();
        }

    }
}
