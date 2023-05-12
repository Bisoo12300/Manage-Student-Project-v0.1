
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace QLSV
{
    public partial class AVGScorebyCourse : Form
    {
        public AVGScorebyCourse()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE  course = new COURSE();
        MY_DB mydb = new MY_DB();

        private void AVGScorebyCourse_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();

            // Tạo một câu lệnh SQL để lấy thông tin học sinh theo ID nhập vào
            string sql = $"SELECT std.id, std.fname,std.mname, std.lname, {GetLabels()}, AVG(score.student_score) AS AvgScore, " +
                         $"CASE WHEN AVG(score.student_score) >= 5 THEN 'Pass' ELSE 'Fail' END AS Result " +
                         $"FROM std " +
                         $"LEFT JOIN score  ON std.Id = score.student_ID " +
                         $"LEFT JOIN course  ON score.course_id = course.id " +

                         $"GROUP BY std.id, std.fname,std.mname, std.lname " +
                         $"ORDER BY std.id";


            // Thực hiện câu lệnh SQL và lấy kết quả trả về
            System.Data.DataTable dt = GetData(sql);

            // Hiển thị kết quả trên DataGridView
            dataGridView1.DataSource = dt;

        }
        public void fill_Grid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = score.fillCommand(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStudent.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxMname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxLname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxCourse.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxScore.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            // Tạo một câu lệnh SQL để lấy thông tin học sinh theo ID nhập vào
            string sql = $"SELECT std.id, std.fname,std.mname, std.lname, {GetLabels()}, AVG(score.student_score) AS AvgScore, " +
                         $"CASE WHEN AVG(score.student_score) >= 5 THEN 'Pass' ELSE 'Fail' END AS Result " +
                         $"FROM std " +
                         $"LEFT JOIN score  ON std.Id = score.student_ID " +
                         $"LEFT JOIN course  ON score.course_id = course.id " +
                         $"WHERE std.id = '{textBoxSearch.Text}' " +
                         $"GROUP BY std.id, std.fname,std.mname, std.lname";
            

            // Thực hiện câu lệnh SQL và lấy kết quả trả về
            System.Data.DataTable dt = GetData(sql);

            // Hiển thị kết quả trên DataGridView
            dataGridView1.DataSource = dt;

        }
        private string GetLabels()
        {
            // Tạo câu lệnh SQL để lấy tất cả các label trong bảng Course
            string sql = "SELECT label FROM course";

            // Thực hiện câu lệnh SQL và lấy kết quả trả về
            System.Data.DataTable dt = GetData(sql);

            // Duyệt qua từng dòng trong DataTable để tạo các column tương ứng trên DataGridView
            string labels = "";
            foreach (DataRow row in dt.Rows)
            {
                string label = row["label"].ToString();
                labels += $"MAX(CASE WHEN course.label = '{label}' THEN score.student_score ELSE NULL END) AS '{label}', ";
            }

            // Xóa ký tự ',' cuối cùng
            labels = labels.Remove(labels.Length - 2);

            return labels;
        }

        private System.Data.DataTable GetData(string sql)
        {
            // Tạo đối tượng SqlConnection để kết nối với database
            using (SqlConnection conn =
                   new SqlConnection(@"Data Source=DESKTOP-19JRBO7;Initial Catalog=QLSV;Integrated Security=True"))
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ database
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    // Tạo đối tượng DataTable để chứa dữ liệu trả về
                    System.Data.DataTable dt = new System.Data.DataTable();

                    // Mở kết nối tới database
                    conn.Open();

                    // Lấy dữ liệu từ database và đổ vào DataTable
                    da.Fill(dt);

                    // Đóng kết nối tới database
                    conn.Close();

                    // Trả về DataTable chứa dữ liệu trả về từ database
                    return dt;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Create a new instance of Word application
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            //Create a new Document in Word and set the page orientation
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();
            wordDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

            //Write the header text in the document
            Microsoft.Office.Interop.Word.Paragraph headerPara = wordDoc.Paragraphs.Add();
            headerPara.Range.Text = "STUDENT RESULT REPORT";
            headerPara.Range.Font.Name = "Calibri";
            headerPara.Range.Font.Size = 20;
            headerPara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            headerPara.Range.InsertParagraphAfter();

            //Add a new table to the document and set its properties
            Table wordTable = wordDoc.Tables.Add(headerPara.Range, dataGridView1.Rows.Count + 1,
                dataGridView1.Columns.Count);
            wordTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            wordTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            wordTable.Range.Font.Name = "Calibri";
            wordTable.Range.Font.Size = 8;

            //Write the column headers from the data grid view to the Word table
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                wordTable.Cell(1, i + 1).Range.Text = dataGridView1.Columns[i].HeaderText;
            }

            //Write the data from the data grid view to the Word table
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    DataGridViewCell cell = dataGridView1.Rows[i].Cells[j];
                    if (cell.Value != null)
                    {
                        if (cell.Value.GetType() == typeof(byte[]) && j == 20) // add image to 4th column
                        {
                            byte[] imgbyte = (byte[])cell.Value;
                            using (MemoryStream ms = new MemoryStream(imgbyte))
                            {
                                System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                                System.Drawing.Image finalPic =
                                    (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                                Clipboard.SetDataObject(finalPic);
                                wordTable.Cell(i + 2, j + 1).Range.Paste();
                            }
                        }
                        else
                        {
                            wordTable.Cell(i + 2, j + 1).Range.Text = cell.Value.ToString();
                        }
                    }
                    else
                    {
                        wordTable.Cell(i + 2, j + 1).Range.Text = "";
                    }
                }
            }

            //Save the Word document
            object fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "REPORT.docx");
            wordDoc.SaveAs2(ref fileName);
            wordDoc.Close();

            //Open the Word document in the default Word application
            Process.Start(fileName.ToString());
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            // Tạo một câu lệnh SQL để lấy thông tin học sinh theo ID nhập vào
            string sql = $"SELECT std.id, std.fname,std.mname, std.lname, {GetLabels()}, AVG(score.student_score) AS AvgScore, " +
                         $"CASE WHEN AVG(score.student_score) >= 5 THEN 'Pass' ELSE 'Fail' END AS Result " +
                         $"FROM std " +
                         $"LEFT JOIN score  ON std.Id = score.student_ID " +
                         $"LEFT JOIN course  ON score.course_id = course.id " +

                         $"GROUP BY std.id, std.fname,std.mname, std.lname " +
                         $"ORDER BY std.id";


            // Thực hiện câu lệnh SQL và lấy kết quả trả về
            System.Data.DataTable dt = GetData(sql);

            // Hiển thị kết quả trên DataGridView
            dataGridView1.DataSource = dt;

        }
    }

}
