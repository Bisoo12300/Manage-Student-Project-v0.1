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

namespace QLSV
{
    public partial class ForgotPassword : Form
    {
        Random random = new Random();
        int otp;
        public ForgotPassword()
        {
            InitializeComponent();
        }


        bool Test()
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
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (Test())
            {
                try
                {
                    MY_DB db = new MY_DB();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Gmail = @gmail ", db.getConnection);
                    cmd.Parameters.Add("@gmail", SqlDbType.VarChar).Value = textBox_Gmail.Text;

                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        string selectedEmail = table.Rows[0]["Gmail"].ToString();
                        
                        ChangePassword cp = new ChangePassword(selectedEmail);
                        cp.Show(this);

                    }
                    else
                    {
                        MessageBox.Show("Invalid Gmail or OTP", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void button_sendOTP_Click(object sender, EventArgs e)
        {
            try
            {
                otp = random.Next(100000, 1000000);

                var fromAddress = new MailAddress("thaison123456xyz@gmail.com");
                var toAddress = new MailAddress(textBox_Gmail.ToString());

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
                MessageBox.Show("OTP was sent via gmail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Gmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_OTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
