using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService.UserTbl
{
    public class UserService : IUserService
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM UserTbl WHERE Uname = @Username";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@Username", user.username);
                int existingUserCount = (int)checkCommand.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    return "Username already exists. Cannot Add User.";
                }

                //adding admin
                string query = "INSERT INTO UserTbl (Uname, UfullName, Upasswrd, Uphone) VALUES (@Uname, @UfullName, @Upasswrd, @Uphone)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Uname", user.username);
                command.Parameters.AddWithValue("@UfullName", user.fullName);
                command.Parameters.AddWithValue("@Upasswrd", user.password);
                command.Parameters.AddWithValue("@Uphone", user.phone);
                command.ExecuteNonQuery();
                return "Successfully added User...";

            }

        }

        public DataSet GetUserDataSet()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

        public void DeleteUser(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from UserTbl where userid = @userid";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userid", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "update UserTbl set Uname=@Uname, UfullName=@UfullName, Upasswrd=@Upasswrd, Uphone=@Uphone where userid = @userid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Uname", user.username);
                command.Parameters.AddWithValue("@UfullName", user.fullName);
                command.Parameters.AddWithValue("@Upasswrd", user.password);
                command.Parameters.AddWithValue("@Uphone", user.phone);
                command.Parameters.AddWithValue("@userid", user.Id);
                command.ExecuteNonQuery();

            }
        }

        public bool verifyUser(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM UserTbl WHERE Uname = @username AND Upasswrd = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();

                isValid = count > 0;
            }

            return isValid;
        }

        public int getUserIdByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UserTbl WHERE Uname = @Uname";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Uname", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        
                        int userid = reader.GetInt32(reader.GetOrdinal("userid"));
                        
                        return userid;
                    }
                }
            }

            return -1; // Return null if no customer found with the given id
        }
    }
}
