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
using System.Net.Configuration;
using System.Net;
using System.Net.Mail;
using static System.Net.WebRequestMethods;

namespace QLSV
{
    public partial class HRRegister : Form
    {
        public HRRegister()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int otp;
        HR hr = new HR();
        bool verif()
        {
            if (textboxFirstName.Text.Trim() == ""
                || txtLastName.Text.Trim() == ""
                
                
                || pictureBox1.Image == null)
                return false;
            else
                return true;
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        private void button_sendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);

                var fromAddress = new MailAddress("thaison123456xyz@gmail.com");
                var toAddress = new MailAddress(textBoxGmail.ToString());

                const string fromPass = "prxugnlpqamojhfc";
                const string subject = "OTP Code";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                    Timeout = 200000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                       {
                           Subject = subject,
                           Body = body
                       })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("OPT was sent via gmail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void checkBox_ShowPw_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBox_ShowPw.Checked ? (char)0 : '*';
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HRRegister.ActiveForm.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                HR student = new HR();
                
                string fname = textboxFirstName.Text;
                string mname = txtMidName.Text;
                string lname = txtLastName.Text;
                string user = textBoxUsername.Text;
                string pass = textBoxPassword.Text;
                string gmail = textBoxGmail.Text;
                int state = 0;




                MemoryStream pic = new MemoryStream();

                if (!checkName(fname))
                {
                    MessageBox.Show("Wrong First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!checkName(lname))
                {
                    MessageBox.Show("Wrong Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        else if (hr.insertUser( fname, mname, lname, user, pass, gmail, pic, state))
                        {
                            MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                            throw new Exception("Unable to add user!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}

