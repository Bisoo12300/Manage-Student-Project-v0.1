using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class AddStudentForm : Form
    {
        Camera camera = new Camera();
        public AddStudentForm()
        {
            InitializeComponent();
        }
        bool verif()
        {
            if (txtFirstName.Text.Trim() == ""
                || txtLastName.Text.Trim() == ""
                || TextBoxAddress.Text.Trim() == ""
                || TextBoxPhone.Text.Trim() == ""
                || pictureBox1.Image == null)
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

        private void buttonUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void takePhotoadd_Button_Click(object sender, EventArgs e)
        {
            Bitmap photo = Camera.TakePhoto();
            if (photo != null)
            {
                // Save the photo to a temporary file
                string tempFile = Path.GetTempFileName();
                photo.Save(tempFile);

                // Display the photo in the picture box
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.ImageLocation = tempFile;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            string id = txtStudentID.Text;
            string fname = txtFirstName.Text;
            string mname = txtMidName.Text;
            string lname = txtLastName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string gender = "Male";
            string phone = TextBoxPhone.Text;
            string email = TextBoxEmail.Text;
            string adrs = TextBoxAddress.Text;
            string year = ComboBoxYear.Text;
            string falcuty = ComboBoxFaculty.Text;


            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
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
            if (verif())
            {
                // save the picture to the memory stream
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                try
                {
                    // fix: check if the picture is not empty before inserting the data
                    if (pic.Length == 0)
                    {
                        throw new Exception("Empty picture!");
                    }
                    else if (student.insertStudent(id, fname, mname, lname, bdate, gender, phone, email, adrs, year, falcuty, pic))
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        throw new Exception("Unable to add student!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
