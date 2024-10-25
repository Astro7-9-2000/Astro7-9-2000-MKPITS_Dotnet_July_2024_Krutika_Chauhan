using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.SelectedIndex = 1;
            
                //ListItem l1 = new ListItem("Kanpur", "1");
                //ListItem l2 = new ListItem("Raipur", "2");
                //ListItem l3 = new ListItem("Nagpur", "3");
                // false property hides the Solapur item in the dropdown.
                //ListItem l4 = new ListItem("Solapur", "4", false);

                //DropDownList1.Items.Add(l1);
                //DropDownList1.Items.Add(l2);
                //DropDownList1.Items.Add(l3);
                //DropDownList1.Items.Add(l4);

                // Automatically Pre-selects the Property in the dropdown index 1 when page loads. 
                //DropDownList1.Items[1].Selected = true;
            }
        }

        protected void Submit_Btn_Click(object sender, EventArgs e)
        {
           if(DropDownList1.SelectedValue == "-1")
            {
                Response.Write("Please select a city");
            }
            else
            {
                /* This code checks the selected value of DropDownList1.
                If the selected value is "-1" (indicating that no valid city is selected), it prompts the user to select a city.
                If a valid city is selected, it outputs the selected item's text, value, and index to the response. 
                This information is displayed on the web page.*/

                Response.Write("Selected Item Text is: " + DropDownList1.SelectedItem.Text + "<br>");
                Response.Write("Selected Item Value is: " + DropDownList1.SelectedItem.Value + "<br>");
                Response.Write("Selected Item Index is: " + DropDownList1.SelectedIndex + "<br>");
            }
        }
    }
}