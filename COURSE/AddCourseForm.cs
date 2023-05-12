using QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string Cid = textBox_CourseID.Text;
            string Cname = textBox_Label.Text;
            int Cperiod = Convert.ToInt32(numericUpDown_period.Text);
            string Csemester = comboBox_semester.SelectedItem.ToString();
            string Cdescription = textBox_Description.Text;

            COURSE course = new COURSE();

            if (Cname.Trim() == "")
            {
                MessageBox.Show("Enter Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (course.checkCourseName(Cname))
            {
                if (course.insertCourse(Cid, Cname, Cperiod, Csemester, Cdescription))
                {
                    MessageBox.Show("New Course Inserted", "AddCourse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CourseID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Label_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_period_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
