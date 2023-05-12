using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_demo_Student.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSV_demo_Student.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            //Xu li anh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            //Xu li anh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDelFrom = new UpdateDeleteStudentForm();
            // thu tu cua cac cot id,fname,mname,lname,bdate,gender,phone,email,address,year,falcuty, picture
            updateDelFrom.TextBoxStudentID_Update.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDelFrom.TextBoxFirstName_Update.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDelFrom.TextBoxMiddleName_Update.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDelFrom.TextBoxLastName_Update.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateDelFrom.dateTimePicker_Update.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Female")
            {
                updateDelFrom.radioButtonFemale_Update.Checked = true;
            }
            else
            {
                updateDelFrom.radioButtonMale_Update.Checked = true;
            }
            updateDelFrom.TextBoxPhone_Update.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateDelFrom.TextBoxAddress_Update.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            updateDelFrom.TextBoxEmail_Update.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDelFrom.ComboBoxYear_Update.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            updateDelFrom.ComboBoxFalcuty_Update.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDelFrom.PicturePicker_Update.Image = Image.FromStream(picture);
            this.Show();
            updateDelFrom.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDelFrom = new UpdateDeleteStudentForm();
            // thu tu cua cac cot id,fname,mname,lname,bdate,gender,phone,email,address,year,falcuty, picture
            updateDelFrom.TextBoxStudentID_Update.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDelFrom.TextBoxFirstName_Update.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDelFrom.TextBoxMiddleName_Update.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDelFrom.TextBoxLastName_Update.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateDelFrom.dateTimePicker_Update.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim() == "Female")
            {
                updateDelFrom.radioButtonFemale_Update.Checked = true;
            }
            else
            {
                updateDelFrom.radioButtonMale_Update.Checked = true;
            }
            updateDelFrom.TextBoxPhone_Update.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateDelFrom.TextBoxAddress_Update.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            updateDelFrom.TextBoxEmail_Update.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDelFrom.ComboBoxYear_Update.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            updateDelFrom.ComboBoxFalcuty_Update.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDelFrom.PicturePicker_Update.Image = Image.FromStream(picture);
            this.Show();
            updateDelFrom.Show();


        }
    }
}
