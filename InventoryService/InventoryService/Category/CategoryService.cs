using InventoryService.Customer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryService.Category
{
    public class CategoryService : ICategoryService
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void AddCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO CategoryTbl (CatName, CatDesc) VALUES (@CatName, @CatDesc)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CatName", category.Catname);
                command.Parameters.AddWithValue("@CatDesc", category.Description);
                command.ExecuteNonQuery();

            }
        }

        public void DeleteCategory(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from CategoryTbl where CatId=@CatId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CatId", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet GetCategoryDataset()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

        public void UpdateCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "update CategoryTbl set CatName=@CatName, CatDesc=@CatDesc where CatId=@CatId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CatName", category.Catname);
                command.Parameters.AddWithValue("@CatDesc", category.Description);
                command.Parameters.AddWithValue("@CatId", category.id);
                command.ExecuteNonQuery();

            }
        }

        public DataTable GetCategoryDataTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from CategoryTbl";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr); // This line loads data from the SqlDataReader into the DataTable

                return dt;
            }


        }

        public Category GetCategoryById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from CategoryTbl where CatId=@CatId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CatId", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Category category = new Category();
                        category.id = reader.GetInt32(reader.GetOrdinal("CatId"));
                        category.Catname = reader.GetString(reader.GetOrdinal("CatName"));
                        category.Description = reader.GetString(reader.GetOrdinal("CatDesc"));
                        return category;
                    }
                }
            }

            return null; // Return null if no category found with the given id
        }

    }
}
