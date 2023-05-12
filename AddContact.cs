using Microsoft.Office.Interop.Word;
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
using static System.Windows.Forms.AxHost;

namespace QLSV
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }
        Camera camera = new Camera();
        bool verif()
        {
            if (textboxFirstName.Text.Trim() == ""
                || txtLastName.Text.Trim() == ""
                || textBoxAddress.Text.Trim() == ""
                || textBoxPhone.Text.Trim() == ""
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
            CONTACT contact=new CONTACT();
            int id = Convert.ToInt32(textBoxContactID.Text);
            string fname = textboxFirstName.Text;
            string mname = txtMidName.Text;
            string lname = txtLastName.Text;
            string group_id = comboBoxGroup.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            string gmail= textBoxGmail.Text;
            int userid= Convert.ToInt32(textBoxID.Text);
            MemoryStream pic = new MemoryStream();
            if (!checkName(fname))
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
                    else if (contact.insertContact(id,fname,mname,lname,phone,address,gmail,userid,group_id,pic))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        throw new Exception("Unable to add Contact!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
