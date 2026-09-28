using InventoryService.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.OrderDetails
{
    public class OrderDetailsService : IOrderDetails
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void AddOrderDetails(List<OrderDetails> orderDetails)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (OrderDetails orderDetail in orderDetails)
                {
                    string query = "INSERT INTO OrderDetailsTbl (ord_id, prod_id, qty, totAmt) VALUES (@ord_id, @prod_id, @qty, @totAmt)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters
                    command.Parameters.AddWithValue("@ord_id", orderDetail.ord_id);
                    command.Parameters.AddWithValue("@prod_id", orderDetail.pro_id);
                    command.Parameters.AddWithValue("@qty", orderDetail.prod_qty);
                    command.Parameters.AddWithValue("@totAmt", orderDetail.prod_amount);

                    command.ExecuteNonQuery();
                }
            }
        }


        public DataSet GetProdutsByOrdId(int ordId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT p.ProductId, p.ProductName, c.CatName AS CategoryName, p.ProductPrice, od.qty AS Order_Qty, od.totAmt AS total_Amount
                 FROM ProductTbl p
                 JOIN OrderDetailsTbl od ON p.ProductId = od.prod_id
                 JOIN CategoryTbl c ON p.ProdCat = c.CatId
                 WHERE od.ord_id = @ordId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ordId", ordId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                return dataset;
            }
        }


    }
}
