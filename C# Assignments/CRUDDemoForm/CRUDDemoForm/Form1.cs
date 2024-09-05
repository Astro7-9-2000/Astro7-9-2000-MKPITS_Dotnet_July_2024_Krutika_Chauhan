using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDemoForm
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-JPGVJHJI\\SQLEXPRESS;Initial Catalog=CRUDDemoForm;Integrated Security=True;");
            con.Open();
            string query = "SET IDENTITY_INSERT tbl_CRUD ON; INSERT INTO tbl_CRUD(ID , Name , Age) Values (@id , @name , @age); SET IDENTITY_INSERT tbl_CRUD OFF";
            SqlCommand cmd = new SqlCommand(query , con);
            cmd.Parameters.AddWithValue("@id" , int.Parse(TxtId.Text));
            cmd.Parameters.AddWithValue("@name", TxtName.Text);
            cmd.Parameters.AddWithValue("@age" , double.Parse(TxtAge.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully saved");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-JPGVJHJI\\SQLEXPRESS; Initial Catalog=CRUDDemoForm; Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tbl_CRUD set name = @name , age = @age where id = @id" , con);
            cmd.Parameters.AddWithValue("@id" , int.Parse(TxtId.Text));
            cmd.Parameters.AddWithValue("@name", TxtName.Text);
            cmd.Parameters.AddWithValue("@age" , double.Parse (TxtAge.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated");

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data Source=LAPTOP-JPGVJHJI\\SQLEXPRESS; Initial Catalog=CRUDDemoForm; Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tbl_CRUD where id = @id" , con);
            cmd.Parameters.AddWithValue("@id", int.Parse(TxtId.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully deleted");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data Source = LAPTOP-JPGVJHJI\\SQLEXPRESS; Initial Catalog=CRUDDemoForm; Integrated Security = True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_CRUD", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataGridView.DataSource = dt;
        }
    }
}
