using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Contact_and_Group : Form
    {
        public Contact_and_Group()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        GROUP group = new GROUP();
        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditHRUser editHRUser = new EditHRUser();
            editHRUser.ShowDialog();
        }
        public void getImageandUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin where username=@user", mydb.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = Login_Form.User;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                label1.Text = "Welcome back ( " + table.Rows[0]["username"].ToString() + " )";
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Contact_and_Group.ActiveForm.Close();
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditContact editContact = new EditContact();
            editContact.ShowDialog();
        }

        private void Contact_and_Group_Load(object sender, EventArgs e)
        {
            getImageandUsername();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectContact selectContact = new SelectContact();
            selectContact.ShowDialog();
            try
            {
                int contactID = Convert.ToInt32(selectContact.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                CONTACT contact = new CONTACT();
                DataTable table = contact.getContactById(contactID);
                textBoxContactID.Text = table.Rows[0]["id"].ToString();

            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            try
            {
                int id = Convert.ToInt32(textBoxContactID.Text);
                if (MessageBox.Show("Sure to delete ?","Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (contact.deleteContact(id))
                    {
                        MessageBox.Show("Contact deleted", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxContactID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Contact not deleted", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Enter A valid ID", " Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowFull showFull = new ShowFull();
            showFull.ShowDialog();
        }
        void loadData()
        {
            comboBoxGrName.DataSource = group.getAllGroup(Login_Form.User);
            comboBoxGrName.DisplayMember = "name";
            comboBoxGrName.ValueMember = "Id";
            comboBoxGRNameRemove.DataSource = group.getAllGroup(Login_Form.User);
            comboBoxGRNameRemove.DisplayMember = "name";
            comboBoxGRNameRemove.ValueMember = "Id";
        }
        private void buttonAdd_Group_Click(object sender, EventArgs e)
        {
            int groudid = Convert.ToInt32(textBoxGroupID.Text.Trim());
            string name = textBoxGroupName.Text;

            if (textBoxGroupID.Text != "" && textBoxGroupName.Text != "")
            {
                if (!group.groupExist(name, "add", Login_Form.User))
                {
                    if (group.insertGroup(groudid, name, Login_Form.User))
                    {
                        MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxGroupID.Text = "";
                        textBoxGroupName.Text = "";
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Name or ID already exists", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonEdit_Group_Click(object sender, EventArgs e)
        {
            int groudid = Convert.ToInt32(comboBoxGrName.SelectedValue);
            string name = textBoxEditNameGroup.Text;

            if (textBoxEditNameGroup.Text != "")
            {
                if (!group.groupExist(name, "edit", Login_Form.User, groudid))
                {
                    if (group.updateGroup(groudid, name))
                    {
                        MessageBox.Show("Group Update Successful", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxEditNameGroup.Text = "";
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Name already exists", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemove_Group_Click(object sender, EventArgs e)
        {
            try
            {
                int groudid = Convert.ToInt32(comboBoxGRNameRemove.SelectedValue);
                if ((MessageBox.Show("Are you sure you want to deleted", "Remove Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (group.deleteGroup(groudid))
                    {
                        MessageBox.Show("Group was Deleted", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Group Not Deleted", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Mumeric ID", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
