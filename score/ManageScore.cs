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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        string data="score";

        private void button_student_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("Select id,fname,mname,lname,bdate From std");
            dataGridViewStudentScore.DataSource=student.getStudents(command);
        }

        private void ManageScore_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            dataGridViewStudentScore.DataSource=score.getStudentsScore();
            
            comboBox_Course.DataSource=course.getAllCourses();
            comboBox_Course.DisplayMember = "id";
            comboBox_Course.ValueMember = "id";
        }

        private void button_show_score_Click(object sender, EventArgs e)
        {
            try
            {
                data = "score";
                dataGridViewStudentScore.AutoGenerateColumns = true;
                dataGridViewStudentScore.DataSource = score.getStudentsScore();

                // Check if any rows were returned
                if (dataGridViewStudentScore.Rows.Count == 0)
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getDataFromDataGridView()
        {
            if (data == "std")
            {
                textBox_Student.Text= dataGridViewStudentScore.CurrentRow.Cells[0].Value.ToString();
                comboBox_Course.SelectedValue= dataGridViewStudentScore.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewStudentScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDataGridView();
        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            AvgFormcs avg = new AvgFormcs();
            avg.Show(this);
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            try
            {
                string studentID = (textBox_Student.Text);
                string courseID = (comboBox_Course.Text);
                float scoreValue = float.Parse(textBox_Score.Text.Trim());
                string description = textBox_des.Text;

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

        private void button_remove_Click(object sender, EventArgs e)
        {
            string studentid = dataGridViewStudentScore.CurrentRow.Cells[0].Value.ToString();
            string courseid = dataGridViewStudentScore.CurrentRow.Cells[4].Value.ToString();

            if (MessageBox.Show("Are You Sure You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentid, courseid))
                {
                    MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
