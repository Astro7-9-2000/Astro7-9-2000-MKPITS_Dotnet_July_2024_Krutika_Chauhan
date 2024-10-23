using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Contains classes for server-side web applications.
using System.Web.UI;
using System.Web.UI.WebControls;

// Defines a namespace to organize related classes.
namespace Session_State
{
    public partial class Third_WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Checks if the session variable "user" is not null, indicating that a user is logged in.
            if (Session["user"] != null)
            {
                // If the session variable exists, it writes a welcome message to the response, displaying the user's name.
                Response.Write("Welcome" + Session["user"].ToString());
            }
            else
            {
                /*
                 * If the session variable is null, indicating no user is logged in
                 Redirects the user back to the First_WebForm.aspx, prompting them to log in.
                 */
                Response.Redirect("First_WebForm.aspx");
            }
        }

        protected void Logout_Btn_Click(object sender, EventArgs e)
        {
            // Checks if the user is logged in by verifying the session variable.
            if (Session["user"] != null)
            
            {
                // Clears the session variable, effectively logging the user out.
                Session["user"] = null;

                // Redirects the user to the login page after logging out.
                Response.Redirect("First_WebForm.aspx");
            }
        }
    }
}