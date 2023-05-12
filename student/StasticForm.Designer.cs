namespace QLSV
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GenderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Total_Label = new System.Windows.Forms.Label();
            this.total_male = new System.Windows.Forms.Label();
            this.total_female = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GenderChart
            // 
            chartArea2.Name = "ChartArea1";
            this.GenderChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GenderChart.Legends.Add(legend2);
            this.GenderChart.Location = new System.Drawing.Point(-1, -1);
            this.GenderChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenderChart.Name = "GenderChart";
            this.GenderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Student Chart";
            this.GenderChart.Series.Add(series2);
            this.GenderChart.Size = new System.Drawing.Size(583, 533);
            this.GenderChart.TabIndex = 0;
            this.GenderChart.Text = "Pie Chart";
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Total_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.Location = new System.Drawing.Point(504, 336);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(149, 29);
            this.Total_Label.TabIndex = 1;
            this.Total_Label.Text = "TotalStudent: ";
            // 
            // total_male
            // 
            this.total_male.AutoSize = true;
            this.total_male.BackColor = System.Drawing.Color.White;
            this.total_male.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_male.Location = new System.Drawing.Point(504, 387);
            this.total_male.Name = "total_male";
            this.total_male.Size = new System.Drawing.Size(122, 29);
            this.total_male.TabIndex = 2;
            this.total_male.Text = "Total male: ";
            // 
            // total_female
            // 
            this.total_female.AutoSize = true;
            this.total_female.BackColor = System.Drawing.Color.White;
            this.total_female.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_female.Location = new System.Drawing.Point(504, 436);
            this.total_female.Name = "total_female";
            this.total_female.Size = new System.Drawing.Size(143, 29);
            this.total_female.TabIndex = 3;
            this.total_female.Text = "Total female: ";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 534);
            this.Controls.Add(this.total_female);
            this.Controls.Add(this.total_male);
            this.Controls.Add(this.Total_Label);
            this.Controls.Add(this.GenderChart);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatisticForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GenderChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GenderChart;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.Label total_male;
        private System.Windows.Forms.Label total_female;
    }
}