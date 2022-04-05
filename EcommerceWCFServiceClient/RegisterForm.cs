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
    public partial class RegisterForm : Form
    {
        private int GenderValue = 0;
        public RegisterForm()
        {
            InitializeComponent();
        }

       

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            GenderValue = 0;
        }

        private void female_checkedChanged(object sender, EventArgs e)
        {
            GenderValue = 1;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Username and Password field cannot be Empty!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthServiceReference.User user = new AuthServiceReference.User();
                user.Username = username.Text;
                user.Password = password.Text;
                user.FirstName = firstName.Text;
                user.LastName = lastName.Text;
                user.Gender = GenderValue;
                user.Address = address.Text;
                user.MobileNumber = mobileNumber.Text;


                AuthServiceReference.AuthenticationServiceClient client = new AuthServiceReference.AuthenticationServiceClient();
                AuthServiceReference.RegisterUserResult result = client.RegisterUser(user);

                if (result.success)
                {
                    MessageBox.Show(result.message, "Acknowledgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm form = new LoginForm();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   

        }

        private void LoginLink_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
