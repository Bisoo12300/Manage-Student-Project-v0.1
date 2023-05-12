using Microsoft.Office.Interop.Word;
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
    public partial class add_course_form : Form
    {
        public add_course_form()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        
        void reload()
        {
            string semes = comboBoxSemester.Text;
            
            listBoxAvai.DataSource = course.getCoursebySemester(semes);
            listBoxAvai.ValueMember = "id";
            listBoxAvai.DisplayMember = "label";
            listBoxAvai.SelectedItem = null;
            
            //listBoxAvai.Text = ("Total Courses: " + course.totalCourse());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!student.checkId(comboBoxStu.Text))
                {
                    MessageBox.Show("STUDENT DOES NOT EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (listBoxAvai.SelectedItem == null)
                {
                    MessageBox.Show("Select Course Before Add", "Course Choose Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checkCourseInListBoxSelected())
                {
                    MessageBox.Show("COURSE DOES EXIST IN LIST SELECT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (listBoxAvai.SelectedItem != null)
                    {
                        listBoxSelect.Items.Add(listBoxAvai.SelectedItem);
                    }
                    listBoxSelect.ValueMember = "id";
                    listBoxSelect.DisplayMember = "label";
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool checkCourseInListBoxSelected()
        {
            if (listBoxSelect.Items.Contains(listBoxAvai.SelectedItem))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string studentid = comboBoxStu.Text;
                if (!student.checkId(studentid))
                {
                    MessageBox.Show("Student ID is Empty", "Empty Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (listBoxSelect.Items.Count == 0)
                {
                    MessageBox.Show("Do not have Course in ListBox", "Empty Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var item in listBoxSelect.Items)
                    {
                        DataRowView Rowview = (DataRowView)item;
                        DataRow Row = Rowview.Row;
                        string courseid = Row["id"].ToString();
                        if (score.AddCourseForStudent(studentid, courseid))
                        {
                            MessageBox.Show("Add Course Successful", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Do you want to continue ?", "Error Add Course for Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                MessageBox.Show("Process Register Break", "Break", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                    MessageBox.Show("Process Register Complete", "Complete Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSelect.SelectedItem == null)
            {
                MessageBox.Show("Select Course Before Remove", "Course Choose Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBoxSelect.Items.Remove(listBoxSelect.SelectedItem);
            }
        }

        private void listBoxSelect_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSelect.SelectedItem != null)
            {
                buttonRemove_Click(sender, e);
            }
        }

        private void listBoxAvai_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAvai.SelectedItem != null)
            {
                buttonAdd_Click(sender, e);

            }
        }

        private void add_course_form_Load(object sender, EventArgs e)
        {
            comboBoxStu.DataSource = ((IListSource)student.getStudentID()).GetList(); ;
            comboBoxStu.ValueMember = "id";
            comboBoxStu.DisplayMember = "id";
            comboBoxSemester.DataSource = course.getAllSemesters();
            comboBoxSemester.ValueMember = "semester";
            comboBoxSemester.DisplayMember = "semester"; reload();
        }
    }
}
