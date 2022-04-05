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
    public partial class CreateProduct : Form
    {
        private int _sellerId;
        public CreateProduct(int sellerId)
        {
            _sellerId = sellerId;
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productName.Text) || string.IsNullOrEmpty(quantity.Text) ||
                string.IsNullOrEmpty(price.Text) || string.IsNullOrEmpty(category.Text))
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ProductServiceReference.Product p = new ProductServiceReference.Product();
                    p.SellerId = _sellerId;
                    p.ProductName = productName.Text;
                    p.Category = category.Text;
                    p.Price = int.Parse(price.Text);
                    p.Quantity = int.Parse(quantity.Text);

                    ProductServiceReference.ProductServiceClient client = new ProductServiceReference.ProductServiceClient();
                    string msg = client.CreateProduct(p);

                    MessageBox.Show(msg, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
