using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_State
{
    public partial class Second_WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Write("Welcome " + Session["user"].ToString());
            }
            else
            {
                // If Session is null then Redirected to first Webform
                Response.Redirect("First_WebForm.aspx");
            }
        }
    }
}