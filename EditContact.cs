using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class EditContact : Form
    {
        CONTACT contact = new CONTACT();
        public EditContact()
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
        private void button_SelectContact_Click(object sender, EventArgs e)
        {
            try
            {
                //thu tu cua cac cot id, fname, mname, lname, bdate, gender, phone, email, address, year, falcuty, picture
                int id = Convert.ToInt32(textBoxID.Text);
                SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id = " + id);

                DataTable table = contact.getContactById(id);

                if (table.Rows.Count > 0)
                {
                    textboxFirstName.Text = table.Rows[0]["fname"].ToString();
                    txtMidName.Text = table.Rows[0]["mname"].ToString();
                    txtLastName.Text = table.Rows[0]["lname"].ToString();

                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxGmail.Text = table.Rows[0]["email"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["pic"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox1.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found !!!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textboxFirstName.Text;
            string mname = txtMidName.Text;
            string lname = txtLastName.Text;
            string group_id = comboBoxGroupID.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            string gmail = textBoxGmail.Text;
            int userid = Convert.ToInt32(textBoxID.Text);
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
                    else if (contact.insertContact(id, fname, mname, lname, phone, address, gmail, userid, group_id, pic))
                    {
                        MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        throw new Exception("Unable to Edit Contact!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
