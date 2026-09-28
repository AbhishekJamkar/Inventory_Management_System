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
using InventoryClientApp.UserServiceRef;

namespace InventoryClientApp
{
    public partial class ManageCategories : Form
    {
        private CategoryServiceRef.ICategoryService categoryServiceRef;
        public ManageCategories()
        {
            categoryServiceRef = new CategoryServiceRef.CategoryServiceClient("WSHttpBinding_ICategoryService");
            InitializeComponent();
            populate();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddCostomer_Click(object sender, EventArgs e)
        {
            
            string CategoryDesc = textBoxCategorydesc.Text;
            string categoryName = textBoxCategoryname.Text;
                
            CategoryServiceRef.Category category = new CategoryServiceRef.Category();
            category.Catname = categoryName;
            category.Description = CategoryDesc;


            //catClient.AddCategory(category);
            categoryServiceRef.AddCategory(category);

            MessageBox.Show("category added seccessfully 💚 ");


            textBoxCategorydesc.Clear();
            textBoxCategoryname.Clear();

            textBoxCategoryID.Focus();
            populate();

            
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCategoryID.Text);
            string CategoryDesc = textBoxCategorydesc.Text;
            string categoryName = textBoxCategoryname.Text;

            CategoryServiceRef.Category category = new CategoryServiceRef.Category();
            category.Catname = categoryName;
            category.Description = CategoryDesc;
            category.id = id;

            categoryServiceRef.UpdateCategory(category);


            MessageBox.Show("category updated seccessfully 💚 ");

            textBoxCategoryID.Clear();
            textBoxCategoryname.Clear();
            textBoxCategorydesc.Clear();


            //textBoxCategorydesc.Focus();
            populate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCategoryID.Clear();
            textBoxCategoryname.Clear();
            textBoxCategorydesc.Clear();
        }

        private void CategoriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CategoriesDataGridView.Rows.Count)
            {
                textBoxCategoryID.Text = CategoriesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCategoryname.Text = CategoriesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxCategorydesc.Text = CategoriesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCategoryID.Text);
            categoryServiceRef.DeleteCategory(id);

            MessageBox.Show("Category has been deleted successfully");

            populate();

        }
        void populate()
        {
            var dataset = new DataSet();
            dataset = categoryServiceRef.GetCategoryDataset();
            CategoriesDataGridView.DataSource = dataset.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
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
