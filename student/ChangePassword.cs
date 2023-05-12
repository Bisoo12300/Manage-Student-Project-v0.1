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

namespace QLSV
{
    public partial class ChangePassword : Form
    {
        public string SelectedEmail { get; set; }

        public ChangePassword(string selectedEmail)
        {
            InitializeComponent();
            SelectedEmail = selectedEmail;
        }


        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_NewPass.PasswordChar = checkBox_ShowPassword.Checked ? (char)0 : '*';
            textBox_cfPass.PasswordChar = checkBox_ShowPassword.Checked ? (char)0 : '*';
        }


        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string newPass = textBox_NewPass.Text;
            string cfPass = textBox_cfPass.Text;

            if (newPass != cfPass)
            {
                MessageBox.Show("Passwords don't match!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MY_DB db = new MY_DB();
                SqlCommand cmd = new SqlCommand("UPDATE Login SET Password=@pass WHERE Gmail=@gmail", db.getConnection);
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = newPass;
                cmd.Parameters.Add("@gmail", SqlDbType.VarChar).Value = SelectedEmail;

                db.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Password changed successfully!", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangePassword.ActiveForm.Close();
                    ForgotPassword.ActiveForm.Close();

                }
                else
                {
                    MessageBox.Show("Password change failed!", "Password Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_cfPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

