/*Login.aspx.cs*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {

        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserPasswordDBConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
          
            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                Response.Write("*!$%&#*ERROR: "+ err.Message);
            }
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserPasswordDBConnectionString"].ConnectionString);
            conn.Open();
            string validateUser = "select count(*) from UserPasswordDB where UserName= '" + Login1.UserName + "'";
            SqlCommand com = new SqlCommand(validateUser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();

            if (temp == 1)
            {
               
                conn.Open();
                string checkPasswordQuery = "select UserPassword from UserPasswordDB where UserName= '" + Login1.UserName + "'";
                SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                string password = passComm.ExecuteScalar().ToString().Replace(" ","");
                if (password == Login1.Password)
                {
                    Session["New"] = Login1.UserName;
                    Response.Write("Password is correct");
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Response.Write("password is not correct");
                }

            }
            else
            {
                Response.Write("password is not correct");
            }


        }

      
    }
}