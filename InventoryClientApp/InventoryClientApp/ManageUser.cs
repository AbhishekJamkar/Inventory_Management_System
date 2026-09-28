using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryClientApp
{
    public partial class ManageUser : Form
    {
        private UserServiceRef.IUserService userServiceRef;
        public ManageUser()
        {
            userServiceRef = new UserServiceRef.UserServiceClient("WSHttpBinding_IUserService");
            
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            DataSet dataset = new DataSet();
            dataset = userServiceRef.GetUserDataSet();
            UserDataGridView.DataSource = dataset.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string fullname = textBoxLastname.Text;
            string password = textBoxPassword.Text;
            string phonenumber = textBoxPhonenumber.Text;

            UserServiceRef.User user = new UserServiceRef.User();
            user.username = username;
            user.password = password;
            user.fullName = fullname;
            user.phone = phonenumber;

            userServiceRef.AddUser(user);
            MessageBox.Show("User added seccessfully 💚 ");
            textBoxUsername.Clear();
            textBoxLastname.Clear();
            textBoxPassword.Clear();
            textBoxPhonenumber.Clear();

            textBoxUsername.Focus();
            populate();
            
        }



        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(textBoxUserID.Text);
            userServiceRef.DeleteUser(userid);
            MessageBox.Show("User has been deleted successfully");
            populate();
            
        }


        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UserDataGridView.Rows.Count)
            {
                textBoxUserID.Text = UserDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxUsername.Text = UserDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxLastname.Text = UserDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxPassword.Text = UserDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxPhonenumber.Text = UserDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserID.Clear();
            textBoxUsername.Clear();
            textBoxLastname.Clear();
            textBoxPassword.Clear();
            textBoxPhonenumber.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(textBoxUserID.Text);
            string username = textBoxUsername.Text;
            string fullname = textBoxLastname.Text;
            string password = textBoxPassword.Text;
            string phonenumber = textBoxPhonenumber.Text;

            UserServiceRef.User user = new UserServiceRef.User();
            user.Id = userid;
            user.username = username;
            user.password = password;
            user.fullName = fullname;
            user.phone = phonenumber;

            userServiceRef.UpdateUser(user);
            MessageBox.Show("redcord updated seccessfully 💚 ");
            textBoxUserID.Clear();
            textBoxUsername.Clear();
            textBoxLastname.Clear();
            textBoxPassword.Clear();
            textBoxPhonenumber.Clear();

            textBoxUsername.Focus();
            populate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCategories manageCategories = new ManageCategories();
            manageCategories.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.Show();
            this.Hide();
        }
    }
}
