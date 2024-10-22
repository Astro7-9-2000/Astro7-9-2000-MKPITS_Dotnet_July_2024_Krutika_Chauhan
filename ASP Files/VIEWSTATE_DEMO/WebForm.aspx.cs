/*
 * ViewState is a method to store the value of page and controls between round trips.It is a page level state - management technique.
1.HTTP Protocol is a stateless Protocol.
2.Web Application is Stateless.
3.Web Server does not have any idea about the requests from where they are coming.
4.On each Request web pages are created and destroyed.
5.ViewState is a client side state management.
6.We cannot transfer data from 1 page to other pages using ViewState. We need Session State for that.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm : System.Web.UI.Page
    {
        string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RestoreBtn_Click(object sender, EventArgs e)
        {
            if (ViewState["user"] != null)
            {
                Txt_User.Text = ViewState["user"].ToString();
            }

            if (ViewState["pass"] != null)
            {
                TxtPass.Text = ViewState["pass"].ToString();
            }
            Txt_User.Text = ViewState["user"].ToString();
            TxtPass.Text = ViewState["pass"].ToString();
        }

        protected void Submit_Btn_Click(object sender, EventArgs e)
        {
            ViewState["user"] = Txt_User.Text;
            ViewState["pass"] = TxtPass.Text;

            Txt_User.Text = string.Empty;
            TxtPass.Text = string.Empty;

            Response.Redirect("WebForm2.aspx");
        }
    }
}