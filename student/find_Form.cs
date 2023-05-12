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
    public partial class find_Form : Form
    {
        public find_Form()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void find_Form_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            fill_Grid(command);
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            total_Student.Text = ("Students: " + total.ToString());
        }
        public void fill_Grid(SqlCommand command)

        {
            dataGridViewFF.ReadOnly = true;
            //Xu li anh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewFF.RowTemplate.Height = 80;
            dataGridViewFF.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewFF.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewFF.AllowUserToAddRows = false;
        }

        private void findFF_button_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENT std = new STUDENT();
                string id = textBoxFF.Text;
                string fname = textBoxFF.Text;
                string lname = textBoxFF.Text;
                string phone = textBoxFF.Text;


                if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(fname) &&
                    string.IsNullOrWhiteSpace(lname) && string.IsNullOrWhiteSpace(phone))
                {
                    throw new Exception("Please enter a search term.");
                }

                // build the appropriate SQL command based on the search term(s)
                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrWhiteSpace(id))
                {
                    cmd.CommandText = "SELECT * FROM std WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id.Trim());
                }
                if (!string.IsNullOrWhiteSpace(fname))
                {
                    if (cmd.CommandText != "")
                    {
                        cmd.CommandText += " OR ";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM std WHERE ";
                    }
                    cmd.CommandText += "fname = @fname";
                    cmd.Parameters.AddWithValue("@fname", fname.Trim());
                }
                if (!string.IsNullOrWhiteSpace(lname))
                {
                    if (cmd.CommandText != "")
                    {
                        cmd.CommandText += " OR ";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM std WHERE ";
                    }
                    cmd.CommandText += "lname = @lname";
                    cmd.Parameters.AddWithValue("@lname", lname.Trim());
                }
                if (!string.IsNullOrWhiteSpace(phone))
                {
                    if (cmd.CommandText != "")
                    {
                        cmd.CommandText += " OR ";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM std WHERE ";
                    }
                    cmd.CommandText += "phone = @phone";
                    cmd.Parameters.AddWithValue("@phone", phone.Trim());
                }

                fill_Grid(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }






        private void refresh_Button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridViewFF.ReadOnly = true;
            //Xu li anh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewFF.RowTemplate.Height = 80;
            dataGridViewFF.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewFF.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewFF.AllowUserToAddRows = false;
        }

        private void CCdoubleclick_event(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDelFrom = new UpdateDeleteStudentForm();
            // thu tu cua cac cot id,fname,mname,lname,bdate,gender,phone,email,address,year,falcuty, picture
            updateDelFrom.TextBoxStudentID_Update.Text = dataGridViewFF.CurrentRow.Cells[0].Value.ToString();
            updateDelFrom.TextBoxFirstName_Update.Text = dataGridViewFF.CurrentRow.Cells[1].Value.ToString();
            updateDelFrom.TextBoxMiddleName_Update.Text = dataGridViewFF.CurrentRow.Cells[2].Value.ToString();
            updateDelFrom.TextBoxLastName_Update.Text = dataGridViewFF.CurrentRow.Cells[3].Value.ToString();
            updateDelFrom.dateTimePicker_Update.Value = (DateTime)dataGridViewFF.CurrentRow.Cells[4].Value;
            if (dataGridViewFF.CurrentRow.Cells[5].Value.ToString().Trim() == "Female")
            {
                updateDelFrom.radioButtonFemale_Update.Checked = true;
            }
            else
            {
                updateDelFrom.radioButtonMale_Update.Checked = true;
            }
            updateDelFrom.TextBoxPhone_Update.Text = dataGridViewFF.CurrentRow.Cells[6].Value.ToString();
            updateDelFrom.TextBoxAddress_Update.Text = dataGridViewFF.CurrentRow.Cells[7].Value.ToString();
            updateDelFrom.TextBoxEmail_Update.Text = dataGridViewFF.CurrentRow.Cells[8].Value.ToString();
            updateDelFrom.ComboBoxYear_Update.Text = dataGridViewFF.CurrentRow.Cells[9].Value.ToString();
            updateDelFrom.ComboBoxFalcuty_Update.Text = dataGridViewFF.CurrentRow.Cells[10].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridViewFF.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDelFrom.PicturePicker_Update.Image = Image.FromStream(picture);
            this.Show();
            updateDelFrom.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.ShowDialog(this);
        }

        private void print_Button_Click(object sender, EventArgs e)
        {
            PrintForm pf = new PrintForm();
            pf.Show(this);
        }
    }
}
