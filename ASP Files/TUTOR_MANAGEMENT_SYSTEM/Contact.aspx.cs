using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TMS_PROJECT
{
    public partial class Contact : System.Web.UI.Page
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        // This is the Page_Load event handler, which is executed when the page is loaded.
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         This method resets the values of the form controls (text boxes and drop-down list) to their default states (empty or unselected). 
         It is called after the form is successfully submitted to clear the input fields for the next entry.
         */
        void ResetContact()
        {
            TxtName.Text = "";
            TxtEmail.Text = "";
            SubjectDropDownList.ClearSelection();
            TxtMsg.Text = "";
        }

        void ErrorContact()
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sp = "spContact_Insert";
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Student_Name", TxtName.Text);
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@Student_Subject", SubjectDropDownList.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Message_box", TxtMsg.Text);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        //Response.Write("<script>alert('Form has ben submitted successfully')</script>");
                        //Response.Write("<script> SuccessContact(); </script>");
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "SuccessContact();", true);

                        // If the form gets submitted then the form resets.
                        ResetContact();
                    }
                    else
                    {
                        //Response.Write("<script>alert('Form Insertion Failed')</script>");
                        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "ErrorContact();", true);
                        ErrorContact();
                    }
                    con.Close();
                }
            }
        }
    }
}