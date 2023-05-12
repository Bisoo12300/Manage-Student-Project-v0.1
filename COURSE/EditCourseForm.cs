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
using  QLSV;

namespace QLSV
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from course");
            comboBox_course.DataSource = course.getAllCourses();
            comboBox_course.DisplayMember = "id";
            comboBox_course.ValueMember = "id";
            comboBox_course.SelectedItem = null;

            // load course details only if an item is selected
            if (comboBox_course.SelectedItem != null)
            {
                loadCourseDetails();
            }
        }
        private void loadCourseDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                string id= comboBox_course.SelectedValue.ToString(); // gets the ID of the selected course
                dt = course.getCoursesByID(id); // queries the database to retrieve the course details
                label_txt.Text = dt.Rows[0][1].ToString();
                numericUpDown_period.Value = Int32.Parse(dt.Rows[0][2].ToString());
                comboBox_semester.Text = dt.Rows[0][3].ToString();
                textBox_descrip.Text = dt.Rows[0][4].ToString();
            }
            catch { }
        }

        public void fillCombo(int index)
        {
            SqlCommand cmd = new SqlCommand("Select * from course ");
            comboBox_course.DataSource = course.getAllCourses();
            comboBox_course.ValueMember = "id";
            comboBox_course.SelectedIndex = index;
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string id = comboBox_course.SelectedValue.ToString(); // gets the ID of the selected course
                dt = course.getCoursesByID(id); // queries the database to retrieve the course details
                label_txt.Text = dt.Rows[0][1].ToString();
                numericUpDown_period.Value = int.Parse(dt.Rows[0][2].ToString());
                comboBox_semester.Text = dt.Rows[0][3].ToString();
                textBox_descrip.Text = dt.Rows[0][4].ToString();
            }
            catch
            {
                MessageBox.Show("Hop ngu", "Ngu vcl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            string id = comboBox_course.SelectedValue.ToString();
            string label = label_txt.Text;
            int period = (int)numericUpDown_period.Value;
            string semester = comboBox_semester.Text;
            string description = textBox_descrip.Text; 
            

            if (!course.checkCourseName(label, Convert.ToInt32(comboBox_course.SelectedValue)))
            {
                MessageBox.Show("This Course label Already Exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (course.updateCourse(id, label, period, semester, description))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillCombo(comboBox_course.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_course_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string id = comboBox_course.SelectedValue.ToString(); // gets the ID of the selected course
                dt = course.getCoursesByID(id); // queries the database to retrieve the course details
                label_txt.Text = dt.Rows[0][1].ToString();
                numericUpDown_period.Value = int.Parse(dt.Rows[0][2].ToString());
                comboBox_semester.Text = dt.Rows[0][3].ToString();
                textBox_descrip.Text = dt.Rows[0][4].ToString();
            }
            catch { }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
