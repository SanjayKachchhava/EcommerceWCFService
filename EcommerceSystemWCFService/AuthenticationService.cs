using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceSystemWCFService
{


    public class AuthenticationService : IAuthenticationService
    {
        private const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public LoginResult Login(string userName, string password)
        {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                LoginResult r = new LoginResult();
                r.success = false;
                r.message = "Invalid Input!!";
                return r;
            }
                

            SqlConnection cnn = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT userid,username FROM [user] WHERE username=@un and password=@pswd";
            SqlParameter p1 = new SqlParameter("@un", userName);
            SqlParameter p2 = new SqlParameter("@pswd", password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int userid = int.Parse(ds.Tables[0].Rows[0]["userid"].ToString());
                LoginResult res = new LoginResult();
                res.success = true;
                res.message = "Login Successfully!!";
                res._yourId = userid;
                return res;
            }

            LoginResult result = new LoginResult();
            result.success = false;
            result.message = "Invalid Credentials!!";
            return result;
        }

        public RegisterUserResult RegisterUser(User user)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO [user] (username,firstname,lastname,gender,mobile,address,password) VALUES " +
                    "(@nm,@fn,@ln,@g,@mo,@addr,@pswd)";
                SqlParameter p0 = new SqlParameter("@nm", user.Username);
                SqlParameter p1 = new SqlParameter("@fn", user.FirstName);
                SqlParameter p2 = new SqlParameter("@ln", user.LastName);
                SqlParameter p3 = new SqlParameter("@g",  user.Gender);
                SqlParameter p4 = new SqlParameter("@mo", user.MobileNumber);
                SqlParameter p5 = new SqlParameter("@addr", user.Address);
                SqlParameter p6 = new SqlParameter("@pswd", user.Password);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RegisterUserResult res = new RegisterUserResult();
                res.success = false;
                res.message = "Error while registing the user!!\n"+ex.Message.ToString();

                return res;
                //throw (new Exception("Error on adding product!!"));
                //return "Error on adding product!!";
            }
            finally
            {
                con.Close();
            }

            RegisterUserResult result = new RegisterUserResult();
            result.success = true;
            result.message = "User Registered Successfully!!";

            return result; 
        }
    }
}
