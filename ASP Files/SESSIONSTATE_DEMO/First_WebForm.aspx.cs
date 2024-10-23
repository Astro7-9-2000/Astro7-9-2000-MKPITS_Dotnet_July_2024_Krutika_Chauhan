using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_State
{
    public partial class First_WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Btn_Click(object sender, EventArgs e)
        {

            //Session.Add("user" , TxtUser.Text); // First way
            /*
             This line stores the value from a text box control (presumably named TxtUser ) into the session state under the key "user". 
             This allows the application to retain this value across different web pages.
             */
            Session["user"] = TxtUser.Text;     // Second way

            // After storing the user input in the session, this line redirects the user to Second_WebForm.aspx.
            Response.Redirect("Second_WebForm.aspx");
        }
    }
}