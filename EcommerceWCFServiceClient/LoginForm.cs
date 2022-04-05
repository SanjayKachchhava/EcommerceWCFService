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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthServiceReference.AuthenticationServiceClient client = new AuthServiceReference.AuthenticationServiceClient();

                AuthServiceReference.LoginResult result = client.Login(username.Text, password.Text);
                if(result.success)
                {
                    //MessageBox.Show(result.message, "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Hide();
                    Home form = new Home(result._yourId);
                    form.ShowDialog();
                    //this.Close();

                }
                else
                {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerFormLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            //this.Close();
        }
    }
}
