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
    public partial class RemoveScore : Form
    {

        public RemoveScore()
        {
            InitializeComponent();
        }
        SCORE score =new SCORE();
        private void RemoveScore_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score");
            fill_Grid(command);

        }
        public void fill_Grid(SqlCommand command)

        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = score.getAllScore(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ScoreID_Txt.Text;
                SqlCommand cmd = new SqlCommand("SELECT * FROM score WHERE student_id = @sid");
                cmd.Parameters.Add("@sid", System.Data.SqlDbType.VarChar).Value = id;
                if (id.Trim() == "")
                {
                    MessageBox.Show("Enter the Score ID", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id = @sid");
                    command.Parameters.AddWithValue("@sid", SqlDbType.VarChar).Value = id;
                    dataGridView1.DataSource = score.getAllScore(command);
                }
                fill_Grid(cmd);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttoncc_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string selectedStudentId;

        private string selectedCourseId;
        private void remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                string studentid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string courseid = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Are You Sure You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentid, courseid))
                    {
                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selectedStudentId = row.Cells["student_id"].Value.ToString();
                selectedCourseId = row.Cells["course_id"].Value.ToString();
            }
        }

    }
}
