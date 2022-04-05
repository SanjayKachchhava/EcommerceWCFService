using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceWCFServiceHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost sh1 = null, sh2 = null;

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            sh1.Close();
            sh2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sh1 = new ServiceHost(typeof(EcommerceSystemWCFService.ProductService));
            sh1.Open();

            sh2 = new ServiceHost(typeof(EcommerceSystemWCFService.AuthenticationService));
            sh2.Open();

            productServiceLabel.Text = "Product Service is Running";
            authenticationLabel.Text = "Authentication Service is Running";

        }


    }
}
