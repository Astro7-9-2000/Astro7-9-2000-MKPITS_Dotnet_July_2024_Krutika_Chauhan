using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class Webform2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RestoreBtn_Click(object sender, EventArgs e)
        {
            if (ViewState["user"] != null)
            {
                TxtUser.Text = ViewState["user"].ToString();
            }
            if (ViewState["pass"] != null)
            {
                TxtPass.Text = ViewState["pass"].ToString();
            }
        }
    }
}