﻿using AForge.Math.Metrics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using iTextSharp.text.pdf;

using iTextSharp.text;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.AxHost;

namespace QLSV
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        public void fill_Grid(SqlCommand command)

        {
            dataGridViewPF.ReadOnly = true;
            //Xu li anh
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewPF.RowTemplate.Height = 80;
            dataGridViewPF.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridViewPF.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewPF.AllowUserToAddRows = false;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from std");
            fill_Grid(cmd);

            //dieu khien cac ratiobutton chuyen trang thai

            if (no_radioButton.Checked)
            {
                dateTimePicker1.Enabled = false; dateTimePicker2.Enabled = false;
            }
        }

        private void yes_RatioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true; dateTimePicker2.Enabled = true;
        }

        private void no_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = !false; dateTimePicker2.Enabled = false;
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            String query;
            if (yes_RatioButton.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (Male_RatioButton.Checked)
                {
                    query = "Select * from std where gender = 'Male' and bdate Between '" + date1 + "'And'" + date2 + "'";
                }
                else if (female_radioButton.Checked)
                {
                    query = "Select * from std where gender = 'Female' and bdate Between '" + date1 + "'And'" + date2 + "'";
                }
                else
                {
                    query = "Select * from std where bdate Between '" + date1 + "'And'" + date2 + "'";
                }
                cmd = new SqlCommand(query);
                fill_Grid(cmd);

            }
            else
            {
                if (Male_RatioButton.Checked)
                {
                    query = "Select * From std Where gender = 'Male'";
                }
                else if (female_radioButton.Checked)
                {
                    query = "Select * From std Where gender = 'Female'";
                }
                else
                {
                    query = "Select * From std";
                }

                cmd = new SqlCommand(query);
                fill_Grid(cmd);
            }
        }





        private void printButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;

            // copying the dataGridViewPF to worksheet
            for (int i = 0; i < dataGridViewPF.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewPF.Columns.Count; j++)
                {
                    string cellValue = dataGridViewPF.Rows[i].Cells[j].Value == null ? "" : dataGridViewPF.Rows[i].Cells[j].Value.ToString();
                    ws.Cells[i + 1, j + 1] = cellValue;
                }
            }

            // saving excel file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "StudentList.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(saveFileDialog.FileName);
                excel.Visible = true;
            }
        }


        private void PrintForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_demoDataSet2.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSV_demoDataSet2.std);

        }



        private void printtoPDF_button_Click(object sender, EventArgs e)
        {
            // Create a new save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set the default file name and extension
            saveFileDialog1.FileName = "students_list";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

            // Open the save file dialog box to save the PDF file
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;

                // Create a new instance of the iTextSharp Document class
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document();
                PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));

                // Open the PDF document
                pdfDoc.Open();

                // Add a new table and set its properties
                PdfPTable pdfTable = new PdfPTable(dataGridViewPF.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Add the headers from the data grid view to the PDF table
                foreach (DataGridViewColumn column in dataGridViewPF.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                // Add the data from the data grid view to the PDF table
                foreach (DataGridViewRow row in dataGridViewPF.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            pdfTable.AddCell("");
                        }
                    }
                }


                // Add the PDF table to the document
                pdfDoc.Add(pdfTable);

                // Close the PDF document and open it in the default PDF viewer
                pdfDoc.Close();
                System.Diagnostics.Process.Start(fileName);
            }
        }

        private void printWord_button_Click(object sender, EventArgs e)
        {
            //Create a new instance of Word application
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            //Create a new Document in Word and set the page orientation
            Microsoft.Office.Interop.Word.Document wordDoc = wordApp.Documents.Add();
            wordDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

            //Write the header text in the document
            Microsoft.Office.Interop.Word.Paragraph headerPara = wordDoc.Paragraphs.Add();
            headerPara.Range.Text = "STUDENTS LIST";
            headerPara.Range.Font.Name = "Calibri";
            headerPara.Range.Font.Size = 30;
            headerPara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            headerPara.Range.InsertParagraphAfter();

            //Add a new table to the document and set its properties
            Table wordTable = wordDoc.Tables.Add(headerPara.Range, dataGridViewPF.Rows.Count + 1, dataGridViewPF.Columns.Count);
            wordTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
            wordTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
            wordTable.Range.Font.Name = "Calibri";
            wordTable.Range.Font.Size = 8;

            //Write the column headers from the data grid view to the Word table
            for (int i = 0; i < dataGridViewPF.Columns.Count; i++)
            {
                wordTable.Cell(1, i + 1).Range.Text = dataGridViewPF.Columns[i].HeaderText;
            }

            //Write the data from the data grid view to the Word table
            for (int i = 0; i < dataGridViewPF.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewPF.Columns.Count; j++)
                {
                    DataGridViewCell cell = dataGridViewPF.Rows[i].Cells[j];
                    if (cell.Value != null)
                    {
                        if (cell.Value.GetType() == typeof(byte[]) && j == 11) // add image to 11th column
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
            object fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "students_list.docx");
            wordDoc.SaveAs2(ref fileName);
            wordDoc.Close();

            //Open the Word document in the default Word application
            Process.Start(fileName.ToString());

        }


    }

}



