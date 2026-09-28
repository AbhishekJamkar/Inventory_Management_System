using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using InventoryService;
using InventoryService.UserTbl;
using InventoryService.Category;
using InventoryService.Customer;
using InventoryService.Product;
using InventoryService.Order;
using InventoryService.OrderDetails;

namespace InventoryHost
{
    public partial class Form1 : Form
    {
        //ServiceHost serviceHost = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri baseUri = new Uri("http://localhost:8733/Design_Time_Addresses/InventoryService/");
            WSHttpBinding httpb = new WSHttpBinding();
            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();

            //UserServiceHost
            Uri userServiceuri = new Uri(baseUri, "UserTbl/UserService/");
            ServiceHost userHost = new ServiceHost(typeof(UserService), userServiceuri);

            userHost.Description.Behaviors.Add(mBehave);
            userHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            userHost.AddServiceEndpoint(typeof(IUserService), httpb, userServiceuri);
            userHost.Open();
            label1.Text = "UserService is Running...";

            //CategoryServiceHost
            Uri catServiceuri = new Uri(baseUri, "Category/CategoryService/");
            ServiceHost categoryHost = new ServiceHost(typeof(CategoryService), catServiceuri);

            categoryHost.Description.Behaviors.Add(mBehave);
            categoryHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            categoryHost.AddServiceEndpoint(typeof(ICategoryService), httpb, catServiceuri);
            categoryHost.Open();
            label2.Text = "CategoryService is Running...";

            //CustomerServiceHost
            Uri custUri = new Uri(baseUri, "Customer/CustomerService/");
            ServiceHost customerHost = new ServiceHost(typeof(CustomerService), custUri);

            customerHost.Description.Behaviors.Add(mBehave);
            customerHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            customerHost.AddServiceEndpoint(typeof(ICustomerService), httpb, custUri);
            customerHost.Open();
            label3.Text = "CustomerService is Running...";

            //ProductServiceHost
            Uri productUri = new Uri(baseUri, "Product/ProductService/");
            ServiceHost productHost = new ServiceHost(typeof(ProductService), productUri);

            productHost.Description.Behaviors.Add(mBehave);
            productHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            productHost.AddServiceEndpoint(typeof(IProductService), httpb, productUri);
            productHost.Open();
            label4.Text = "ProductService is Running...";

            //OrderServiceHost
            Uri orderUri = new Uri(baseUri, "Order/OrderService/");
            ServiceHost orderHost = new ServiceHost(typeof(OrderService), orderUri);

            orderHost.Description.Behaviors.Add(mBehave);
            orderHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            orderHost.AddServiceEndpoint(typeof(IOrderService), httpb, orderUri);
            orderHost.Open();
            label5.Text = "OrderService is Running...";

            Uri orderDetaislUri = new Uri(baseUri, "OrderDetails/OrderDetailsService/");
            ServiceHost orderDetailsHost = new ServiceHost(typeof(OrderDetailsService), orderDetaislUri);

            orderDetailsHost.Description.Behaviors.Add(mBehave);
            orderDetailsHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            orderDetailsHost.AddServiceEndpoint(typeof(IOrderDetails), httpb, orderDetaislUri);
            orderDetailsHost.Open();
            label6.Text = "OrderDetailsService is Running...";

        }
    }
}
