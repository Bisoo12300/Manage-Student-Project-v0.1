using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.IO;

namespace QLSV
{
    public partial class StudentList : Form
    {
        string courid;
        string label;
        SCORE score = new SCORE();
        public StudentList(string courid, string label)
        {
            InitializeComponent();
            this.courid = courid;
            this.label = label;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                studentID = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
               
            }
            catch { }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

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
            headerPara.Range.Text = "COURSES LIST";
            headerPara.Range.Font.Name = "Calibri";
            headerPara.Range.Font.Size = 20;
            headerPara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            headerPara.Range.InsertParagraphAfter();

            //Add a new table to the document and set its properties
            Table wordTable = wordDoc.Tables.Add(headerPara.Range, dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count);
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
                        if (cell.Value.GetType() == typeof(byte[]) && j == 4) // add image to 4th column
                        {
                            byte[] imgbyte = (byte[])cell.Value;
                            using (MemoryStream ms = new MemoryStream(imgbyte))
                            {
                                System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                                System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
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
            object fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "courses_list.docx");
            wordDoc.SaveAs2(ref fileName);
            wordDoc.Close();

            //Open the Word document in the default Word application
            Process.Start(fileName.ToString());
        }
        string studentID;
       
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {

                if ((MessageBox.Show("Are you sure you want to deleted", "Remove Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(studentID, courid))
                    {
                        MessageBox.Show("Student Deleted", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentOfCourse(courid);
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Mumeric ID", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.score.getStudentOfCourse(courid);

        }

    }
}
