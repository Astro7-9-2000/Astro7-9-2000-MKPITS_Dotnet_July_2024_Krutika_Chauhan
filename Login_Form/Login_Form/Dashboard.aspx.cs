﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Form
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Write("Welcome to My Site Mr/Mrs " + Session["user"].ToString());
            }
            else
            {
                Response.Redirect("LOGINFORM.aspx");
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session["user"] = null;
                Response.Redirect("LOGINFORM.aspx");
            }
        }
    }
}