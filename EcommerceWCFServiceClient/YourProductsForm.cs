using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceWCFServiceClient
{
    public partial class YourProductsForm : Form
    {
        private int _sellerId;
        public YourProductsForm(int sellerId)
        {
            _sellerId = sellerId;
            InitializeComponent();
        }

        private void YourProductsForm_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        

        private void refresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }


        private void loadProducts()
        {
            ProductServiceReference.ProductServiceClient client = new ProductServiceReference.ProductServiceClient();
            DataSet ds = client.GetSellerProducts(_sellerId);
            dataGridView1.DataSource = ds.Tables[0];

            productid.Text = "none";
            productName.Text = "";
            category.Text = "";
            price.Text = "";
            quantity.Text = "";

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(productName.Text) || string.IsNullOrEmpty(quantity.Text) ||
                string.IsNullOrEmpty(price.Text) || string.IsNullOrEmpty(category.Text))
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ("none".Equals(productid.Text))
            {
                MessageBox.Show("Please Select the product first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ProductServiceReference.Product p = new ProductServiceReference.Product();
                    p.ProductId = int.Parse(productid.Text);
                    p.ProductName = productName.Text;
                    p.Category = category.Text;
                    p.Price = double.Parse(price.Text);
                    p.Quantity = int.Parse(quantity.Text);

                    ProductServiceReference.ProductServiceClient client = new ProductServiceReference.ProductServiceClient();
                    string msg = client.UpdateProduct(p);

                    MessageBox.Show(msg, "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dataGridView1_CellClicked(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string pId = row.Cells["ProductId"].Value.ToString();
                productid.Text = string.IsNullOrEmpty(pId) ? "none" : pId;
                productName.Text = row.Cells["Name"].Value.ToString();
                category.Text = row.Cells["Category"].Value.ToString();
                price.Text = row.Cells["Price"].Value.ToString();
                quantity.Text = row.Cells["Quantity"].Value.ToString();
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if ("none".Equals(productid.Text))
            {
                MessageBox.Show("Please Select the product first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProductServiceReference.ProductServiceClient client = new ProductServiceReference.ProductServiceClient();
                string msg =  client.DeleteProduct(int.Parse(productid.Text));

                MessageBox.Show(msg, "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                loadProducts();
            }
        }

        private void CreateFormLink_Clicked(object sender, EventArgs e)
        {
            CreateProduct form = new CreateProduct(_sellerId);
            form.ShowDialog();

            loadProducts();
        }
    }
}
