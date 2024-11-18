using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace TMS_PROJECT
{
    public partial class Student_Signup : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountryDDL();
            }
        }
        void BindCountryDDL()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from country";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            CountryDropDownList.DataSource = data;
            CountryDropDownList.DataTextField = "country_name";
            CountryDropDownList.DataValueField = "country_id";
            CountryDropDownList.DataBind();
            
        }

        void BindCityDDL(int country_id)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from city where c_id = @country_id";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@country_id", country_id);
            DataTable data = new DataTable();
            sda.Fill(data);
            CityDropDownList.DataSource = data;
            CityDropDownList.DataTextField = "city_name";
            CityDropDownList.DataValueField = "c_id";
            CityDropDownList.DataBind();
        }
        void ResetControls()
        {
            TxtName.Text = "";
            TxtFatherName.Text = "";
            TxtSurName.Text = "";
            GenderDropDownList.ClearSelection();
            TxtAge.Text = "";
            CountryDropDownList.ClearSelection(); 
            CityDropDownList.ClearSelection();
            TxtAddress.Text = "";
            TxtClass.Text = "";
            GoingToDropDownList.ClearSelection();
            TxtSubject.Text = "";
            TxtContact.Text = "";
            TutionTypeDropDownList.ClearSelection();
            TutionPreferredDropDownList.ClearSelection();
            TxtUserName.Text = "";
            TxtPassword.Text = "";
            TxtConfirmPassword.Text = "";

        }

        protected void StudentSignUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            try
            {
            string query = "insert into Student_SignUp values(@Name , @FName , @Surname , @gender , @age , @Country , @City ,@Address , @Standard , @GoingTo , @Subject , @ContactNo , @Tution_Type , @Tution_Prefer , @UserName ,@Password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", TxtName.Text);
            cmd.Parameters.AddWithValue("@FName", TxtFatherName.Text);
            cmd.Parameters.AddWithValue("@Surname", TxtSurName.Text);
            cmd.Parameters.AddWithValue("@gender", GenderDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(TxtAge.Text));
            cmd.Parameters.AddWithValue("@Country", CountryDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@City", CityDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
            cmd.Parameters.AddWithValue("@Standard", TxtClass.Text);
            cmd.Parameters.AddWithValue("@GoingTo" , GoingToDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Subject", TxtSubject.Text);
            cmd.Parameters.AddWithValue("@ContactNo", TxtContact.Text);
            cmd.Parameters.AddWithValue("@Tution_Type" , TutionTypeDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Tution_Prefer" , TutionPreferredDropDownList.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@UserName", TxtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if(a > 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Swal.fire('Success' , 'You have Registered Successfully' , 'success');", true);
                ResetControls();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "Swal.fire('Failure' , 'Registeration Failed.Try Another Username' , 'error');", true);
            }
            }
            catch(SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE KEY constraint"))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup",
                        "Swal.fire('Failure', 'Registration Failed... " + TxtUserName.Text+ " already exists.', 'error');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup",
                        "Swal.fire('Failure', 'Registration Failed...', 'error');", true);
                }
            }
            finally
            {
                con.Close();
            }
            
        }

        protected void CountryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int country_id = Convert.ToInt32(CountryDropDownList.SelectedValue);
            BindCityDDL(country_id);
        }
    }
}