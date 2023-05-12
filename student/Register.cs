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
using System.Xml.Linq;
using System.IO;
using System.Net.Configuration;
using System.Net;
using System.Net.Mail;
using static System.Net.WebRequestMethods;

namespace QLSV.NewFolder1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int otp;
        bool Test()
        {
            if (String.Compare(textBox_Password.Text, textBox_CfPassword.Text, false) == 0)
            {
                if (otp.ToString().Equals(textBox_OTP.Text))
                {
                    MessageBox.Show("Successful Verification", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Verification Failure", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Confirm Password incorrect", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void checkBox_ShowPw_CheckedChanged(object sender, EventArgs e)
        {

            textBox_Password.PasswordChar = checkBox_ShowPw.Checked ? (char)0 : '*';
            textBox_CfPassword.PasswordChar = checkBox_ShowPw.Checked ? (char)0 : '*';

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {

            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string userName = textBox_Username.Text;
            string passWord = textBox_Password.Text;
            string gmail= textBox_gmail.Text;

            string cfpassWord = textBox_CfPassword.Text;
            if (Test())
            {
                if (passWord != cfpassWord)
                {
                    MessageBox.Show("Passwords don't match!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @user", db.getConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = textBox_Username.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    MessageBox.Show("User have been used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    db.openConnection();
                    SqlCommand command2 = new SqlCommand("INSERT INTO login (username, password,gmail,state)" +
                                    " VALUES (@user, @password,@gmail,0)", db.getConnection);
                    command2.Parameters.Add("@user", SqlDbType.VarChar).Value = textBox_Username.Text;
                    command2.Parameters.Add("@password", SqlDbType.VarChar).Value = textBox_Password.Text;
                    command2.Parameters.Add("@gmail", SqlDbType.VarChar).Value = textBox_gmail.Text;
               
                    command2.ExecuteNonQuery(); // thuc hien cau lenh truy van
                    db.closeConnection();
                    if (MessageBox.Show("Tạo tài khoản mới thành công!", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        textBox_Username.Clear();
                        textBox_Password.Clear();
                        textBox_gmail.Clear();
                        textBox_OTP.Clear();
                        textBox_CfPassword.Clear();

                    }
                }
           
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register.ActiveForm.Close();
            
        }

        private void button_sendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);

                var fromAddress = new MailAddress("thaison123456xyz@gmail.com");
                var toAddress = new MailAddress(textBox_gmail.ToString());

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
    }
}


