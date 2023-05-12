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

using QLSV.NewFolder1;

namespace QLSV
{
    public partial class Login_Form : Form
    {
        public static string User;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE username =@Username AND password = @Password AND state = 1", db.getConnection);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = TextBox_Username.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TextBox_Password.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    User = table.Rows[0]["username"].ToString();

                    // Kiểm tra xem tài khoản đăng nhập có phải là "admin" hay không
                    if (User != "admin")
                    {
                        Login_Form.ActiveForm.Hide();
                        MainForm01 mainForm01 = new MainForm01();
                        mainForm01.ShowDialog(this);
                    }
                    else
                    {
                        // Mở các mainform khác
                        // ...
                        Login_Form.ActiveForm.Hide();
                        MainForm2 mainForm2 = new MainForm2();
                        mainForm2.ShowDialog(this);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password or Account is locked", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButton2.Checked)
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HRLogin WHERE username =@Username AND password = @Password AND state = 1", db.getConnection);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = TextBox_Username.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TextBox_Password.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    User = table.Rows[0]["username"].ToString();

                    // Kiểm tra xem tài khoản đăng nhập có phải là "admin" hay không
                    if (User != "admin")
                    {
                        Login_Form.ActiveForm.Hide();
                       Contact_and_Group contact_And_Group = new Contact_and_Group();
                        contact_And_Group.ShowDialog(this);
                    }
                    else
                    {
                        // Mở các mainform khác
                        // ...
                        Login_Form.ActiveForm.Hide();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password or Account is locked", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }


        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_Password.PasswordChar = checkBox_ShowPassword.Checked ? (char)0 : '*';

        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/XXX.png");
        }

        private void bt_CreateAcount_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Register register = new Register();
                register.ShowDialog(this);
            }
            else if (radioButton2.Checked)
            {
                HRRegister registerHR = new HRRegister();
                registerHR.ShowDialog(this);
            }
            
        }

        private void TextBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Login.PerformClick();
            }
        }

        private void lb_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                ForgotPassword fg = new ForgotPassword();
                fg.ShowDialog(this);
            }
            else if (radioButton2.Checked)
            {
                HRForgotPassword fgHR = new HRForgotPassword();
                fgHR.ShowDialog(this);
            }
            
        }
    }
}
