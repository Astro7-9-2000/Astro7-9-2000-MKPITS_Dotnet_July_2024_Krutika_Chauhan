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
            errorProvider1 = new ErrorProvider();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JPGVJHJI\\SQLEXPRESS;Initial Catalog=CRUDDemoForm;Integrated Security=True;");
        private ErrorProvider errorProvider1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text) ||
                string.IsNullOrEmpty(txtDesign.Text)  ||
                string.IsNullOrEmpty(txtProductId.Text) ||
                CmbColor.SelectedItem == null ||
                DateTimePicker.Value < DateTime.Today
                )
            {
                MessageBox.Show("Please fill all the required fields. ");
                return;
            }

            int productId;
            if (!int.TryParse(txtProductId.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("Invalid Product ID. Please enter a positive integer.");
                return;
            }

            if (txtItemName.Text.Length > 50)
            {
                MessageBox.Show("Item Name cannot Exceed 50 characters.");
                return;
            }

            if (txtDesign.Text.Length > 50)
            {
                MessageBox.Show("Design cannot exceed 50 characters.");
                return;
            }

            try
            {
                // Insertion of Data
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

        // Update Operation
        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtItemName.Text) ||
                string.IsNullOrEmpty(txtDesign.Text) ||
                string.IsNullOrEmpty(txtProductId.Text) ||
                CmbColor.SelectedItem == null ||
                DateTimePicker.Value < DateTime.Today)
            {
                MessageBox.Show("Please fill all the required fields.");
                return;
            }
            int productId;
            if (!int.TryParse(txtProductId.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("Invalid Product ID. Please enter a positive integer.");
                return;
            }

            con.Open();
            SqlCommand command = new SqlCommand("Update tbl_PracticeForm1 set ItemName = @ItemName, Design = @Design, Colour = @Colour, UpdateDate = '" + DateTime.Parse(DateTimePicker.Text) + "' where ProductID = @ProductId", con);
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

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePicker.Value < DateTime.Today)
            {
                errorProvider1.SetError(DateTimePicker, "Update date cannot be in the past");
            }
            else
            {
                errorProvider1.SetError(DateTimePicker, string.Empty);
            }
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(txtProductId.Text, out productId))
            {
                errorProvider1.SetError(txtProductId, "Invalid Product Id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

    }
}
