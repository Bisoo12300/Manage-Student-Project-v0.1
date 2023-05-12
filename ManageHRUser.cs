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
    public partial class ManageHRUser : Form
    {
        public ManageHRUser()
        {
            InitializeComponent();
        }

        MY_DB myDb = new MY_DB();
        public DataTable getUsers(SqlCommand command)
        {
            command.Connection = myDb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        private void btInsert_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string gmail = txtGmail.Text;
            int state = 0;
            if (verif())
            {
                try
                {
                    if (radioButtonUnblock.Checked)
                    {
                        state = 1;
                    }
                    
                    SqlCommand command =
                        new SqlCommand("INSERT INTO HRLogin(username,password,gmail,state) VALUES (@user,@pass,@gmail,state)",
                            myDb.getConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                    command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;
                    command.Parameters.Add("@state", SqlDbType.Bit).Value =state;
                    myDb.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Inserted", "Insert User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Not Inserted", "Insert User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    myDb.closeConnection();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Insert User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                if ((MessageBox.Show("Are you sure you want to delete this user?", "Delete User",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    SqlCommand command = new SqlCommand("DELETE FROM HRLogin WHERE username=@user", myDb.getConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    myDb.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Deleted", "Delete User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Not Deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    myDb.closeConnection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand("SELECT * FROM HRLogin WHERE CONCAT(username,gmail) LIKE '%" + txtSearch.Text + "%'");
            fillGrid(command);
            txtUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        void fillGrid(SqlCommand command)
        {


            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = command.CommandText = "SELECT * FROM HRLogin";
            ;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            //Xu li anh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            
            
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = getUsers(command);



        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text;
            if (verif())
            {
                string user = txtUser.Text.Trim();
                if (user != "")
                {
                    SqlCommand command = new SqlCommand("UPDATE HRLogin SET password=@pass WHERE username=@user",
                        myDb.getConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                    myDb.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User Not Updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    myDb.closeConnection();
                }
                else
                {
                    MessageBox.Show("Enter The User Id", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool verif()
        {
            if ((txtUser.Text.Trim() == "")
                || (txtPass.Text.Trim() == "")
                || (txtGmail.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtGmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "True")
            {
                radioButtonUnblock.Checked = true;
            }
            else
            {
                radioButtonBlock.Checked = true;
            }
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            int state=0;
            
            if (verif())
            {
                string user = txtUser.Text.Trim();
                if (user != "")
                {
                    SqlCommand command = new SqlCommand("UPDATE HRLogin SET state=@state WHERE username=@user",
                        myDb.getConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    command.Parameters.Add("@state", SqlDbType.Bit).Value = state;
                    myDb.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account blocked successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to block account");
                    }
                    myDb.closeConnection();
                }
                else
                {
                    MessageBox.Show("Enter The User Id", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUnblock_Click(object sender, EventArgs e)
        {
            int state = 1;
           
            if (verif())
            {
                string user = txtUser.Text.Trim();
                if (user != "")
                {
                    SqlCommand command = new SqlCommand("UPDATE HRLogin SET state=@state WHERE username=@user",
                        myDb.getConnection);
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    command.Parameters.Add("@state", SqlDbType.Bit).Value = state;
                    myDb.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Unblocked successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Unblock account");
                    }
                    myDb.closeConnection();
                }
                else
                {
                    MessageBox.Show("Enter The User Id", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageHRUser_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = getUsers(command);
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
