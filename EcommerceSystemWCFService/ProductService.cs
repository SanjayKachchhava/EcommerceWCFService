using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EcommerceSystemWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ProductService : IProductService
    {
        private const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EcommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string CreateProduct(Product product)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO product (name,category,price,quantity,sellerid) VALUES (@nm,@cat,@prc,@qty,@sid)";
                SqlParameter p0 = new SqlParameter("@nm", product.ProductName);
                SqlParameter p1 = new SqlParameter("@cat", product.Category);
                SqlParameter p2 = new SqlParameter("@prc", product.Price);
                SqlParameter p3 = new SqlParameter("@qty", product.Quantity);
                SqlParameter p4 = new SqlParameter("@sid", product.SellerId);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding product!!"));
                //return "Error on adding product!!";
            }
            finally
            {
                con.Close();
            }
            con.Close();
            return "Product Added Successfully!!";
        }

        public string DeleteProduct(int prodId)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sqlStatement = "DELETE FROM product WHERE productid= @id";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, con);
                cmd.Parameters.AddWithValue("@Id", prodId);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error on deleting product");
            }
            finally
            {
                con.Close();
            }
            return "Product Deleted Successfully";
        }

        public DataSet GetAllProducts()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductId, Name, Category, Price, Quantity,SellerId FROM product",
                CONNECTION_STRING);
            DataSet ds = new DataSet();
            da.Fill(ds, "products");
            return ds;
        }

        public Product GetProduct(int prodId)
        {
            SqlConnection cnn = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT productid, name, category, price, quantity,sellerid FROM product WHERE productid = @id";
            SqlParameter p = new SqlParameter("@id", prodId);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = new Product();
            while (reader.Read())
            {
                product.ProductId = reader.GetInt32(0);
                product.ProductName = reader.GetString(1);
                product.Category = reader.GetString(2);
                product.Price =reader.GetSqlMoney(3).ToInt32();
                
                product.Quantity = reader.GetInt32(4);
                product.SellerId = reader.GetInt32(5);
            }
            reader.Close();
            cnn.Close();
            return product;
        }

        public DataSet GetSellerProducts(int sellerId)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductId, Name, Category, Price, Quantity,SellerId FROM product WHERE sellerid="+sellerId.ToString(),
                CONNECTION_STRING);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "products");
            return ds;
        }

        public string UpdateProduct(Product product)
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sqlStatement = "UPDATE product SET Name=@nm,Category=@cat,Price=@prc,Quantity=@qty WHERE productid=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", product.ProductId);
                cmd.Parameters.AddWithValue("@nm", product.ProductName);
                cmd.Parameters.AddWithValue("@cat", product.Category);
                cmd.Parameters.AddWithValue("@prc", product.Price);
                cmd.Parameters.AddWithValue("@qty", product.Quantity);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
            return "Product Updated Successfully!!";
        }
    }
}
