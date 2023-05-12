using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakingPhoto;

namespace QLSV
{
    //open python file


    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                //thu tu cua cac cot id, fname, mname, lname, bdate, gender, phone, email, address, year, falcuty, picture
                int id = int.Parse(TextBoxStudentID_Update.Text);
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    TextBoxFirstName_Update.Text = table.Rows[0]["fname"].ToString();
                    TextBoxMiddleName_Update.Text = table.Rows[0]["mname"].ToString();
                    TextBoxLastName_Update.Text = table.Rows[0]["lname"].ToString();
                    dateTimePicker_Update.Value = (DateTime)table.Rows[0]["bdate"];
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale_Update.Checked = true;
                    }
                    else
                    {
                        radioButtonMale_Update.Checked = true;
                    }
                    TextBoxPhone_Update.Text = table.Rows[0]["phone"].ToString();
                    TextBoxEmail_Update.Text = table.Rows[0]["email"].ToString();
                    TextBoxAddress_Update.Text = table.Rows[0]["address"].ToString();
                    ComboBoxYear_Update.Text = table.Rows[0]["year"].ToString();
                    ComboBoxFalcuty_Update.Text = table.Rows[0]["falcuty"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PicturePicker_Update.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found !!!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id;
            string fname = TextBoxFirstName_Update.Text;
            string mname = TextBoxMiddleName_Update.Text;
            string lname = TextBoxLastName_Update.Text;
            DateTime bdate = dateTimePicker_Update.Value;
            string gender = "Male";
            string phone = TextBoxPhone_Update.Text;
            string email = TextBoxEmail_Update.Text;
            string adrs = TextBoxAddress_Update.Text;
            string year = ComboBoxYear_Update.Text;
            string falcuty = ComboBoxFalcuty_Update.Text;


            if (radioButtonFemale_Update.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker_Update.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 18 and 100 year", "Invalide Birth Date ", MessageBoxButtons.OK);
            }
            else if (!checkName(fname))
            {
                MessageBox.Show("Wrong First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkName(lname))
            {
                MessageBox.Show("Wrong Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkPhone(phone))
            {
                MessageBox.Show("Wrong Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (verif())
            {
                try
                {
                    id = TextBoxStudentID_Update.Text;
                    PicturePicker_Update.Image.Save(pic, PicturePicker_Update.Image.RawFormat);
                    if (student.updateStudent(id, fname, mname, lname, bdate, gender, phone, email, adrs, year, falcuty, pic))
                        MessageBox.Show("Student Information Changed Successful !!!", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something Wrong !!!", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        bool verif()
        {
            if (TextBoxFirstName_Update.Text.Trim() == ""
                || TextBoxMiddleName_Update.Text.Trim() == ""
                || TextBoxLastName_Update.Text.Trim() == ""
                || TextBoxPhone_Update.Text.Trim() == ""
                || PicturePicker_Update.Image == null)
                return false;
            else
                return true;
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        public bool checkPhone(string x)
        {
            return Regex.IsMatch(x, "^[0-9]{9,12}$");
        }

        private void buttonUpload_Update_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|S *.jpg;*.png;*.gif)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicturePicker_Update.SizeMode = PictureBoxSizeMode.Zoom;
                PicturePicker_Update.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = TextBoxStudentID_Update.Text;
                if (MessageBox.Show("Are You Sure About This Delete Action ???", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Student Delete !!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextBoxStudentID_Update.Text = "";
                        TextBoxFirstName_Update.Text = "";
                        TextBoxMiddleName_Update.Text = "";
                        TextBoxLastName_Update.Text = "";
                        dateTimePicker_Update.Text = "";
                        TextBoxPhone_Update.Text = "";
                        TextBoxEmail_Update.Text = "";
                        TextBoxAddress_Update.Text = "";
                        ComboBoxYear_Update.Text = "";
                        ComboBoxFalcuty_Update.Text = "";
                        PicturePicker_Update.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted !!!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void advance_Button_Click(object sender, EventArgs e)
        {
            MY_DB mY_DB = new MY_DB();
            find_Form findDatagridview = new find_Form();
            SqlCommand command = new SqlCommand("Select * from std ", mY_DB.getConnection);
            findDatagridview.dataGridViewFF.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            findDatagridview.dataGridViewFF.RowTemplate.Height = 80;
            findDatagridview.dataGridViewFF.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)findDatagridview.dataGridViewFF.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            findDatagridview.dataGridViewFF.AllowUserToAddRows = false;
            //FindDatagridview findDatagridview = new FindDatagridview();
            findDatagridview.Show(this);
        }

        private void TakePhoto_button_Click(object sender, EventArgs e)
        {
            Bitmap photo = Camera.TakePhoto();
            if (photo != null)
            {
                // Display the photo in a picture box on the UI
                PicturePicker_Update.Image = photo;
            }
        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {
            add_course_form add_Course_Form = new add_course_form();
            add_Course_Form.ShowDialog();
        }
    }
}
