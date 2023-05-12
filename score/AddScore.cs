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

namespace QLSV
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();

        private void AddScore_Load(object sender, EventArgs e)
        {
            SqlCommand command=new SqlCommand("SELECT id,label FROM course");
            comboBox_Course.DataSource=course.getAllCourses();
            comboBox_Course.DisplayMember = "label";
            comboBox_Course.ValueMember = "id";

            SqlCommand cmd = new SqlCommand("Select id,fname,mname,lname from std");
            dataGridView1.DataSource=student.getStudents(cmd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_StudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = (textBox_StudentID.Text);
                string courseID = (comboBox_Course.Text);
                float scoreValue = float.Parse(textBox_score.Text.Trim());
                string description =textBox_Description.Text;

                if (!score.studentScoreExist(studentID, courseID))
                {
                    MessageBox.Show("Not Found ID Student", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (score.studentScoreExist(studentID, courseID))
                {
                    if (score.UpdateScore(studentID, courseID, scoreValue, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("SELECT id,label FROM course");
                        comboBox_Course.DataSource = course.getAllCourses();
                        comboBox_Course.DisplayMember = "label";
                        comboBox_Course.ValueMember = "id";

                        SqlCommand cmd = new SqlCommand("Select id,fname,mname,lname from std");
                        dataGridView1.DataSource = student.getStudents(cmd);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
           
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

