using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class LOGINFORM : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from Login where username = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user" , UserTextBox.Text);
            cmd.Parameters.AddWithValue("@pass", PassTextBox.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["user"] = UserTextBox.Text;
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Successfull !!')</script>");
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Failed !!')</script>");
            }
            
            con.Close();
        }
    }
}