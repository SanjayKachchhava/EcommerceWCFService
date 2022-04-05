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
    public partial class Home : Form
    {
        int _yourId;
        public Home(int yourId)
        {
            _yourId = yourId;
            InitializeComponent();
        }

        private void allProductsLink_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AllProductsForm form = new AllProductsForm();
            form.ShowDialog();
            //this.Close();
        }

        private void createProductLink_Click(object sender, EventArgs e)
        {
            CreateProduct form = new CreateProduct(_yourId);
            form.ShowDialog();
        }

        private void yourProductsLink_Click(object sender, EventArgs e)
        {
            YourProductsForm form = new YourProductsForm(_yourId);
            form.ShowDialog();
        }
        

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            //this.Close();
        }
    }
}
