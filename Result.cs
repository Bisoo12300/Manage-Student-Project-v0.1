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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private SCORE score = new SCORE();

        private void Result_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT StudentID, AVG(Score) as AVG FROM SCORE GROUP BY StudentID");
            dataGridView1.DataSource = score.getAvgScoreByCourse();
            int total = int.Parse(execCount("SELECT COUNT(*) FROM Score"));
            float pass = int.Parse(execCount("SELECT COUNT(*) FROM Score where student_score >= 5"));
            float fail = int.Parse(execCount("SELECT COUNT(*) FROM Score where student_score < 5"));
            label3.Text = ("Pass: " + (pass / total) * 100 + "%");
            label4.Text = ("Fail: " + (fail / total) * 100 + "%");
        }

        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
       
    }
}
