using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDPractice1
{
    public partial class PracticeForm1 : Form
    {
        public PracticeForm1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JPGVJHJI\\SQLEXPRESS;Initial Catalog=CRUDDemoForm;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Insert into tbl_PracticeForm1 (ProductId, ItemName, Design, Colour, UpdateDate) values (@ProductId, @ItemName, @Design, @Colour, @UpdateDate)", con);
                command.Parameters.AddWithValue("@ProductId", int.Parse(txtProductId.Text));
                command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                command.Parameters.AddWithValue("@Design", txtDesign.Text);
                command.Parameters.AddWithValue("@Colour", CmbColor.Text);
                command.Parameters.AddWithValue("@UpdateDate", DateTime.Parse(DateTimePicker.Text));
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Inserted");
                Binddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void Binddata()
        {
            SqlCommand command = new SqlCommand("Select * from tbl_PracticeForm1", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Binddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Update tbl_PracticeForm1 set ItemName = @ItemName, Design = @Design, Colour = @Colour, UpdateDate = '"+DateTime.Parse(DateTimePicker.Text)+"' where ProductID = @ProductId", con);
            command.Parameters.AddWithValue("@ProductId", int.Parse(txtProductId.Text));
            command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            command.Parameters.AddWithValue("@Design", txtDesign.Text);
            command.Parameters.AddWithValue("@Colour", CmbColor.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            Binddata();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text != "")
            {
                if (MessageBox.Show("Are you sure to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete from tbl_PracticeForm1 where ProductID = '" + int.Parse(txtProductId.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted");
                    Binddata();
                }
            }
            else
            {
                MessageBox.Show("Put Product ID");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from tbl_PracticeForm1 where ProductID = '" + int.Parse(txtProductId.Text) + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
