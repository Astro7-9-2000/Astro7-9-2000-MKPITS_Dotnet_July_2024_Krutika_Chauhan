﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VALIDATION_CONTROLS
{
    public partial class VALIDATION_FORM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "Scripts", "<script>alert('YOUR FORM HAS BEEN SUBMITTED !!')</script>");
        }
    }
}