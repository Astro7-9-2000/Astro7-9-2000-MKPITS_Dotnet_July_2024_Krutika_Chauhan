using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_LINQ_TO_SQL
{
    public partial class Form1 : Form
    {
        StudentDBDataContext db;
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGridView()
        {
            db = new StudentDBDataContext();
            DGV_Show.DataSource = db.students;

        }

        private void CleartextBoxes()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;
                    txt.Clear();
                }
            }
            TxtName.Focus();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            db = new StudentDBDataContext();
            student std = new student();
            std.name = TxtName.Text;
            std.gender = TxtGender.Text;
            std.age = int.Parse(TxtAge.Text);
            std.standard = int.Parse(TxtClass.Text);
            db.students.InsertOnSubmit(std);
            db.SubmitChanges();
            MessageBox.Show("Data has been Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleartextBoxes();
            BindGridView();
        }



        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CleartextBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void DGV_Show_MouseClick(object sender, MouseEventArgs e)
        {
            TxtName.Text = DGV_Show.SelectedRows[0].Cells[1].Value.ToString();
            TxtGender.Text = DGV_Show.SelectedRows[0].Cells[2].Value.ToString();
            TxtAge.Text = DGV_Show.SelectedRows[0].Cells[3].Value.ToString();
            TxtClass.Text = DGV_Show.SelectedRows[0].Cells[4].Value.ToString();


        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (DGV_Show.SelectedRows.Count > 0)
            {
                db = new StudentDBDataContext();
                int id = Convert.ToInt32(DGV_Show.SelectedRows[0].Cells[0].Value);
                student std = db.students.FirstOrDefault(s => s.Id == id);
                std.name = TxtName.Text;
                std.gender = TxtGender.Text;
                std.age = int.Parse(TxtAge.Text);
                std.standard = int.Parse(TxtClass.Text);
                db.SubmitChanges();
                MessageBox.Show("Data has been Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleartextBoxes();
                BindGridView();
            }
            else
            {
                MessageBox.Show("Please select any Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
