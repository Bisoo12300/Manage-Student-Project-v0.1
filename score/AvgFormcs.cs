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
    public partial class AvgFormcs : Form
    {
        public AvgFormcs()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();

        private void AvgFormcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet2.score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this.qLSVDataSet2.score);
            SqlCommand command = new SqlCommand("SELECT StudentID, AVG(Score) as AVG FROM SCORE GROUP BY StudentID");
            dataGridView1.DataSource = score.getAvgScoreByCourse();
        }
    }
}
