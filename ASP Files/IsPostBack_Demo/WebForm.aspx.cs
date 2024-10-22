using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
1.PostBack is actually sending all the information from client to the web server , 
then web server process all those contents and returns back to the client.
2. When a page loads for the very first time then the IsPostBack Property is False.
3. When a page loads for the Second Time or more than second time then IsPostBack Property is True.
4. Whenever we click the button page loads and PostBack occurs.
*/

namespace IsPostBackproperty
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!IsPostBack)
            //  {
            //      Response.Write("THIS IS POST BACK REQUEST !!");
            //  }

            if (!IsPostBack)
            {
                AddListBoxItems();
            }
        }

        void AddListBoxItems()
        {
            ListBox1.Items.Add("Item 1");
            ListBox1.Items.Add("Item 2");
            ListBox1.Items.Add("Item 3");
        }
    }
}