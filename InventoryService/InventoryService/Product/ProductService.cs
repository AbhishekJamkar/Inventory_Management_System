using InventoryService.Category;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.Product
{
    public class ProductService : IProductService
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO ProductTbl (ProductName, ProductQty, ProductPrice, ProductDesc, ProdCat) VALUES (@ProductName, @ProductQty, @ProductPrice, @ProductDesc, @ProdCat)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", product.ProdName);
                command.Parameters.AddWithValue("@ProductQty", product.quantity);
                command.Parameters.AddWithValue("@ProductPrice", product.price);
                command.Parameters.AddWithValue("@ProductDesc", product.ProdDesc);
                command.Parameters.AddWithValue("@ProdCat", product.prodCategory.id);
                command.ExecuteNonQuery();

            }
        }

        public void DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from ProductTbl where ProductId=@ProductId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProductId", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataSet GetProductDataSet()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT pt.ProductId,pt.ProductName, pt.ProductQty, pt.ProductPrice, pt.ProductDesc, ct.CatName FROM ProductTbl pt JOIN CategoryTbl ct ON pt.ProdCat = ct.CatId;";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "update ProductTbl set ProductName=@ProductName, ProductQty=@ProductQty, ProductPrice=@ProductPrice, ProductDesc=@ProductDesc, ProdCat=@ProdCat where ProductId=@ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", product.ProdName);
                command.Parameters.AddWithValue("@ProductQty", product.quantity);
                command.Parameters.AddWithValue("@ProductPrice", product.price);
                command.Parameters.AddWithValue("@ProductDesc", product.ProdDesc);
                command.Parameters.AddWithValue("@ProdCat", product.prodCategory.id);
                command.Parameters.AddWithValue("@ProductId", product.id);
                command.ExecuteNonQuery();

            }
        }

        public DataSet GetProductCatDataSet(int catid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT pt.ProductId,pt.ProductName, pt.ProductQty, pt.ProductPrice, pt.ProductDesc, ct.CatName FROM ProductTbl pt JOIN CategoryTbl ct ON pt.ProdCat = ct.CatId where ct.CatId=" + catid;
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

        public Product GetProductById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from ProductTbl where ProductId=@ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Product product = new Product();
                        product.id = reader.GetInt32(reader.GetOrdinal("ProductId"));
                        product.ProdName = reader.GetString(reader.GetOrdinal("ProductName"));
                        product.quantity = reader.GetInt32(reader.GetOrdinal("ProductQty"));
                        product.price = reader.GetInt32(reader.GetOrdinal("ProductPrice"));
                        product.ProdDesc = reader.GetString(reader.GetOrdinal("ProductDesc"));
                        // Assuming ProdCat is the foreign key referencing CatId
                        int catId = reader.GetInt32(reader.GetOrdinal("ProdCat"));

                        CategoryService categoryService = new CategoryService();
                        product.prodCategory = categoryService.GetCategoryById(catId); // Implement GetCategoryById method to fetch category details
                        return product;
                    }
                }
            }

            return null; // Return null if no product found with the given id
        }

        public Product GetProductByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from ProductTbl where ProductName=@ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", name);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Product product = new Product();
                        product.id = reader.GetInt32(reader.GetOrdinal("ProductId"));
                        product.ProdName = reader.GetString(reader.GetOrdinal("ProductName"));
                        product.quantity = reader.GetInt32(reader.GetOrdinal("ProductQty"));
                        product.price = reader.GetInt32(reader.GetOrdinal("ProductPrice"));
                        product.ProdDesc = reader.GetString(reader.GetOrdinal("ProductDesc"));
                        // Assuming ProdCat is the foreign key referencing CatId
                        int catId = reader.GetInt32(reader.GetOrdinal("ProdCat"));

                        CategoryService categoryService = new CategoryService();
                        product.prodCategory = categoryService.GetCategoryById(catId); // Implement GetCategoryById method to fetch category details
                        return product;
                    }
                }
            }

            return null;
        }
    }
}
