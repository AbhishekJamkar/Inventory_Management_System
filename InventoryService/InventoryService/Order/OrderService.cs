using InventoryService.Category;
using InventoryService.Customer;
using InventoryService.Product;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Order
{
    public class OrderService : IOrderService
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void AddOrder(Order order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO OrderTbl (CustomerId, OrderDate, totalAmt, PaymentMode, userId) VALUES (@CustomerId, @OrderDate, @totalAmt, @PaymentMode, @userId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OrderDate", order.orderDate);
                command.Parameters.AddWithValue("@totalAmt", order.amount);
                command.Parameters.AddWithValue("@PaymentMode", order.paymentMode);
                command.Parameters.AddWithValue("@CustomerId", order.customer.Id);
                command.Parameters.AddWithValue("@userId", order.userid);
                command.ExecuteNonQuery();

            }
        }

        public DataSet GetAllOrder()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT ot.orderId, 
                   ct.CustName, 
                   ct.CustPhone, 
                   ot.totalAmt, 
                   ot.PaymentMode, 
                   ot.OrderDate, 
                   ut.UfullName
              FROM OrderTbl ot 
                   JOIN CustomerTbl ct ON ot.CustomerId = ct.CustId
                   JOIN UserTbl ut ON ot.userId = ut.userid";

                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }


        public Order GetLastInsertedOrder()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT TOP 1 orderId, totalAmt, OrderDate, PaymentMode, CustomerId
                         FROM OrderTbl
                         ORDER BY orderId DESC";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Order order = new Order();

                    order.orderid = Convert.ToInt32(reader["orderId"]);
                    order.amount = Convert.ToInt32(reader["totalAmt"]);
                    order.orderDate = Convert.ToDateTime(reader["OrderDate"]);
                    order.paymentMode = reader["PaymentMode"].ToString();
                    int custid = Convert.ToInt32(reader["CustomerId"]);
                    CustomerService customerService = new CustomerService();
                    order.customer = customerService.GetCustomerById(custid);


                    return order;
                }

                return null;
            }
        }

        public Order GetOrderById(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select * from OrderTbl where orderId=@orderId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@orderId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Order order = new Order();
                            order.orderid = reader.GetInt32(reader.GetOrdinal("orderId"));
                            order.orderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                            order.amount = reader.GetInt32(reader.GetOrdinal("totalAmt"));
                            order.paymentMode = reader.GetString(reader.GetOrdinal("PaymentMode"));
                            int custid = reader.GetInt32(reader.GetOrdinal("CustomerId"));

                            CustomerService customerService = new CustomerService();
                            order.customer = customerService.GetCustomerById(custid);
                            order.userid = reader.GetInt32(reader.GetOrdinal("userId"));

                            return order;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return null; // Return null if no order found with the given id or an error occurred
        }

        public DataSet GetOrdersByCust(int custId)
        {
            DataSet orders = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select count(*), SUM(totalAmt), Max(OrderDate) from OrderTbl where CustomerId = " + custId;

                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }

        }


    }
}
