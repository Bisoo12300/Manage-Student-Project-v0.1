
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLSV
{
    public partial class ManageCourseForm : Form
    {

        public ManageCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        int pos;
        private void  ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            SqlCommand cmd = new SqlCommand("Select * from course");
            listBoxCourse.DataSource = course.getAllCourses();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = null;
            total_label.Text = ("Total Course: " + course.totalCourse());
        }
        void showData(int index)
        {
            SqlCommand cmd = new SqlCommand("Select * from course");
            DataRow dr = course.getAllCourses().Rows[index];
            listBoxCourse.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxLabel.Text = dr.ItemArray[1].ToString();

            numericUpDown1.Value = int.Parse(dr.ItemArray[2].ToString());
            comboBox_semes.Text = dr.ItemArray[3].ToString();
            textbox_desc.Text = dr.ItemArray[4].ToString();

        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            if (drv != null)
            {
                pos = listBoxCourse.SelectedIndex;
                showData(pos);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string label = textBoxLabel.Text;
            int period = Convert.ToInt32(numericUpDown1.Value);
            string seme = comboBox_semes.SelectedText.ToString();
            string desc = textbox_desc.Text;

            if (label.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (course.checkCourseName(label))
            {
                if (course.insertCourse(id, label, period, seme, desc))
                {
                                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            string label = textBoxLabel.Text;
            int period = Convert.ToInt32(numericUpDown1.Value);
            string seme = comboBox_semes.Text.ToString();
            string desc = textbox_desc.Text;
            string id = textBoxID.Text;

            if (!course.checkCourseName(label, Convert.ToInt32(textBoxID.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            }
            else if (course.updateCourse(id,label,period,seme,desc))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Couse Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                string courseID = textBoxID.Text;
                if (MessageBox.Show("Are You Sure You Want To Delete This Course", "Delete Course",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxLabel.Text = "";
                        numericUpDown1.Value = 10;
                        comboBox_semes.SelectedText = "";
                        textbox_desc.Text = "";
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }

            pos = 0;
        }

        private void First_button_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            SqlCommand command=new SqlCommand("Select * from course");
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos=pos - 1;
                showData(pos);
            }
        }

        private void Last_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from course");
            pos =course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void listBoxCourse_DoubleClick(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            int index = listBoxCourse.SelectedIndex;
            DataRow dr = course.getAllCourses().Rows[index];
            listBoxCourse.SelectedIndex = index;

            string courid = (dr.ItemArray[0].ToString());
            string label = dr.ItemArray[1].ToString();
            StudentList studentOfCourse = new StudentList(courid, label);
            studentOfCourse.ShowDialog();
        }
    }
}
