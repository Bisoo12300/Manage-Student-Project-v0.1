
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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            try
            {
                string Cid = CourseID_Txt.Text;
                if (MessageBox.Show("Are you sure to delete this course ?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(Cid))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A valid Number ID", " Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttoncc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
