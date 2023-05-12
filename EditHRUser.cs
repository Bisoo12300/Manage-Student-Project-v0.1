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
using System.Data.SqlClient;



using static System.Windows.Forms.AxHost;

namespace QLSV
{
    public partial class EditHRUser : Form
    {
        public EditHRUser()
        {
            InitializeComponent();
        }
        
        Random random = new Random();
        int otp;
        HR hr = new HR();
        MY_DB mydb = new MY_DB();
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
        private void EditHRUser_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            System.Data.DataTable table = new System.Data.DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin where username=@a", mydb.getConnection);

            command.Parameters.Add("@a", SqlDbType.VarChar).Value = Login_Form.User;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                
                textboxFirstName.Text = table.Rows[0]["firstname"].ToString();
                txtMidName.Text = table.Rows[0]["midname"].ToString();
                txtLastName.Text = table.Rows[0]["lastname"].ToString();
                
                textBoxPassword.Text = table.Rows[0]["password"].ToString();
                textBoxGmail.Text = table.Rows[0]["gmail"].ToString();
                byte[] pic;
                pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fname = textboxFirstName.Text;
            string mname = txtMidName.Text;
            string lname = txtLastName.Text;
            string pass = textBoxPassword.Text;
            string gmail = textBoxGmail.Text;
            string username = Login_Form.User;
            MemoryStream pic = new MemoryStream();
            if (!checkName(fname))
            {
                MessageBox.Show("Wrong First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkName(lname))
            {
                MessageBox.Show("Wrong Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if (verif())
            {
                try
                {
                    string user = Login_Form.User;
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (hr.updatetUser(fname,mname,lname,pass,gmail,pic))
                        MessageBox.Show("User Information Changed Successful !!!", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something Wrong !!!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
                MessageBox.Show("Empty Fields", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
