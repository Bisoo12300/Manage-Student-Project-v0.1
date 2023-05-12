using Microsoft.Office.Interop.Word;
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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalmale = Convert.ToDouble(student.totalMaleStudent());
            double totalfemale = Convert.ToDouble(student.totalFemaleStudent());
            double male_Percent = (totalmale / (total));
            double female_Percent = (totalfemale / (total));
            Total_Label.Text = ("Students: " + total.ToString());
            total_female.Text = ("Male: " + totalmale.ToString());
            total_male.Text = ("Female: " + totalfemale.ToString());
            GenderChart.Series["Student Chart"].Points.AddXY(male_Percent.ToString(".00" + "%"), male_Percent);
            GenderChart.Series["Student Chart"].Points.AddXY(female_Percent.ToString(".00" + "%"), female_Percent);
        }

    }
}