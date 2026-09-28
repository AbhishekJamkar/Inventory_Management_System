using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryClientApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            checkBox1.Checked = false;
            textBoxPassword.UseSystemPasswordChar = true;
        }
        string role = "";

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role == "")
            {
                MessageBox.Show("Select the role Admin or User");
            }
            else if (role == "admin")
            {
                if (textBoxUsername.Text == "Admin")
                {
                    if (textBoxPassword.Text == "admin123")
                    {
                        ManageCategories manageCategories = new ManageCategories();
                        MessageBox.Show("Admin Logged in Successfully...");
                        manageCategories.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Password...");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Admin Username...");
                }
            }
            else if (role == "user")
            {
                UserServiceRef.UserServiceClient client = new UserServiceRef.UserServiceClient("WSHttpBinding_IUserService");
                string uname = textBoxUsername.Text;
                string pass = textBoxPassword.Text;
                bool isVerified = client.verifyUser(uname, pass);
                int userid = client.getUserIdByUsername(uname);
                if (isVerified)
                {
                    ManageCustomers manageCustomers = new ManageCustomers(userid);
                    MessageBox.Show("User Logged in Successfully...");
                    manageCustomers.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!!!");
                }

            }
        }

        private void userRole_CheckedChanged(object sender, EventArgs e)
        {
            role = "user";
            //adminRole.Checked = false;
        }

        private void adminRole_CheckedChanged(object sender, EventArgs e)
        {
            role = "admin";
            //userRole.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }
    }
}
