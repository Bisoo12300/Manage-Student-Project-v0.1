using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.score;

namespace QLSV
{
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void student_MenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }



        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm StatisticForm = new StatisticForm();
            StatisticForm.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            updateDeleteStudentForm.Show(this);
        }



        private void managestudent_Click(object sender, EventArgs e)
        {
            find_Form ff = new find_Form();
            ff.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm pf = new PrintForm();
            pf.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourseForm = new RemoveCourseForm();
            removeCourseForm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm ManageCF = new ManageCourseForm();
            ManageCF.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourse printCourse = new PrintCourse();
            printCourse.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgFormcs avgFormcs = new AvgFormcs();
            avgFormcs.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScore printScore = new PrintScore();
            printScore.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScore removeScore = new RemoveScore();
            removeScore.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScore managescore = new ManageScore();
            managescore.Show(this);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            MainForm01.ActiveForm.Close();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.Show(this);
        }

        private void staticResearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGScorebyCourse aVGScorebyCourse = new AVGScorebyCourse();
            aVGScorebyCourse.Show(this);
        }
    }
}
