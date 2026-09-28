using InventoryService.UserTbl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Customer
{
    public class CustomerService : ICustomerService
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void AddCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO CustomerTbl (CustName, CustPhone) VALUES (@CustName, @CustPhone)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustName", customer.name);
                command.Parameters.AddWithValue("@CustPhone", customer.phone);
                command.ExecuteNonQuery();


            }
        }

        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "update CustomerTbl set CustName=@CustName, CustPhone=@CustPhone where CustId=@CustId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustName", customer.name);
                command.Parameters.AddWithValue("@CustPhone", customer.phone);
                command.Parameters.AddWithValue("@CustId", customer.Id);
                command.ExecuteNonQuery();

            }
        }

        public void DeleteCustomer(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from CustomerTbl where CustId=@CustId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CustId", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet GetCustomerDataset()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CustomerTbl WHERE CustId = @CustId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustId", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.Id = reader.GetInt32(reader.GetOrdinal("CustId"));
                        customer.name = reader.GetString(reader.GetOrdinal("CustName"));
                        customer.phone = reader.GetString(reader.GetOrdinal("CustPhone"));

                        return customer;
                    }
                }
            }

            return null; // Return null if no customer found with the given id
        }



    }
}
