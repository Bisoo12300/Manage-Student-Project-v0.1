using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class SelectContact : Form
    {
        public SelectContact()
        {
            InitializeComponent();
        }

        private void SelectContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet6.contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.qLSVDataSet6.contact);
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT id,fname,mname, lname ,group_id   FROM contact ");
            
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = contact.SelectContactList(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
