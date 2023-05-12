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
    public partial class ShowFull : Form
    {
        public ShowFull()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();
        private void ShowFull_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            // cau truc lay tu gợi ý của sự

            SqlCommand command = new SqlCommand("SELECT fname ',mname , lname , mygroup.name , phone, email, address, pic "
                                                + "FROM contact INNER JOIN mygroup on contact.id = mygroup.Id ");

   
            dataGridView1.DataSource = contact.SelectContactList(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }

            listBox1.DataSource = group.getGroup(Login_Form.User);
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
            listBox1.SelectedItem = null;
            dataGridView1.ClearSelection();
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
        // Sinh viên gợi ý cách sort
        private void dtgvDataContact_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {

                int groupid = (Int32)listBox1.SelectedValue;

                SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', mygroup.name as 'Group', phone, email, address, pic "
                                                    + " FROM contact INNER JOIN group on contact.group_id = mygroup.id "
                                                    + " mycontact.group_id = @groupid");

                command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
               

                dataGridView1.DataSource = contact.SelectContactList(command);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (IsOdd(i))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception)
            {
            }
            dataGridView1.ClearSelection();
        }
    }
}
