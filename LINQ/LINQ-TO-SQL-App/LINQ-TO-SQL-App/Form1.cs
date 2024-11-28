using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_TO_SQL_App
{
    public partial class Form1 : Form
    {
        StudentDBDataContext db;
        List<Student> stdList;
        int index_no = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StudentDBDataContext db = new StudentDBDataContext();
            ////StudentGrid.DataSource = db.Students;
            //Table<Student> std_tbl = db.Students;
            //StudentGrid.DataSource = std_tbl;

            db = new StudentDBDataContext();
            stdList = db.Students.ToList();
            DisplayData();
        }
        private void DisplayData()
        {
            TxtID.Text = stdList[index_no].Id.ToString();
            TxtName.Text = stdList[index_no].name;
            TxtGender.Text = stdList[index_no].gender;
            TxtAge.Text = stdList[index_no].age.ToString();
            TxtClass.Text = stdList[index_no].standard.ToString();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {

            if(index_no < stdList.Count() - 1)
            {
                index_no += 1;
                DisplayData();
            }
            else
            {
                MessageBox.Show("This is the Last Record");
            }
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (index_no > 0)
            {
                index_no -= 1;
                DisplayData();
            }
            else
            {
                MessageBox.Show("This is the First Record");
            }
        }
    }
}