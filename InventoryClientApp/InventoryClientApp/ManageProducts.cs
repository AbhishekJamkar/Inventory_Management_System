using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryClientApp
{
    public partial class ManageProducts : Form
    {
        private ProductServiceRef.IProductService productServiceRef;
        private CategoryServiceRef.ICategoryService categoryServiceRef;
        public ManageProducts()
        {
            productServiceRef = new ProductServiceRef.ProductServiceClient("WSHttpBinding_IProductService");
            categoryServiceRef = new CategoryServiceRef.CategoryServiceClient("WSHttpBinding_ICategoryService");
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void fillCategory()
        {
            DataSet ds = categoryServiceRef.GetCategoryDataset();

            comboBoxCategory.ValueMember = "CatId";
            comboBoxCategory.DisplayMember = "CatName";
            comboBoxCategory.DataSource = ds.Tables[0];

            DataSet ds1 = categoryServiceRef.GetCategoryDataset();
            comboBoxSearch.ValueMember = "CatId";
            comboBoxSearch.DisplayMember = "CatName";
            comboBoxSearch.DataSource = ds1.Tables[0];

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }
        void populate()
        {
            DataSet dataset = new DataSet();
            dataset = productServiceRef.GetProductDataSet();
            ProductsDataGridView.DataSource = dataset.Tables[0];
            
        }
        void filtrerbycategory()
        {
            int catid = int.Parse(comboBoxSearch.SelectedValue.ToString());
            DataSet dataset = new DataSet();
            dataset = productServiceRef.GetProductCatDataSet(catid);
            ProductsDataGridView.DataSource = dataset.Tables[0];
            
        }
        private void buttonAddCostomer_Click(object sender, EventArgs e)
        {
            int catid = int.Parse(comboBoxCategory.SelectedValue.ToString());
            CategoryServiceRef.Category cat = categoryServiceRef.GetCategoryById(catid);

            ProductServiceRef.Category newCat = new ProductServiceRef.Category();
            newCat.id = cat.id;
            newCat.Catname = cat.Catname;
            newCat.Description = cat.Description;

            ProductServiceRef.Product product = new ProductServiceRef.Product();
            //product.id = int.Parse(textBoxProductID.Text);
            product.ProdName = textBoxProductName.Text;
            product.price = int.Parse(textBoxProductPrice.Text);
            product.quantity = int.Parse(textBoxProductQty.Text);
            product.ProdDesc = textBoxProductDescription.Text;
            product.prodCategory = newCat;

            productServiceRef.AddProduct(product);
            MessageBox.Show("Product added seccessfully 💚 ");

            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxProductQty.Clear();
            textBoxProductPrice.Clear();
            textBoxProductDescription.Clear();

            textBoxProductName.Focus();
            populate();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int catid = int.Parse(comboBoxCategory.SelectedValue.ToString());
            CategoryServiceRef.Category cat = categoryServiceRef.GetCategoryById(catid);

            ProductServiceRef.Category newCat = new ProductServiceRef.Category();
            newCat.id = cat.id;
            newCat.Catname = cat.Catname;
            newCat.Description = cat.Description;

            ProductServiceRef.Product product = new ProductServiceRef.Product();
            product.id = int.Parse(textBoxProductID.Text);
            product.ProdName = textBoxProductName.Text;
            product.price = int.Parse(textBoxProductPrice.Text);
            product.quantity = int.Parse(textBoxProductQty.Text);
            product.ProdDesc = textBoxProductDescription.Text;
            product.prodCategory = newCat;

            productServiceRef.UpdateProduct(product);
            MessageBox.Show("Product updated seccessfully 💚 ");

            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxProductQty.Clear();
            textBoxProductPrice.Clear();
            textBoxProductDescription.Clear();

            textBoxProductName.Focus();
            populate();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxProductID.Text);
            productServiceRef.DeleteProduct(id);
            MessageBox.Show("Product has been deleted successfully");
            populate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxProductQty.Clear();
            textBoxProductPrice.Clear();
            textBoxProductDescription.Clear();
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsDataGridView.Rows.Count)
            {
                textBoxProductID.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxProductName.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxProductQty.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxProductPrice.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxProductDescription.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxCategory.Text = ProductsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtrerbycategory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageCategories manageCategories = new ManageCategories();
            manageCategories.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
