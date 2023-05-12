namespace QLSV
{
    partial class ManageScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Student = new System.Windows.Forms.TextBox();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.textBox_des = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_avg = new System.Windows.Forms.Button();
            this.button_student = new System.Windows.Forms.Button();
            this.button_show_score = new System.Windows.Forms.Button();
            this.dataGridViewStudentScore = new System.Windows.Forms.DataGridView();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // textBox_Student
            // 
            this.textBox_Student.Location = new System.Drawing.Point(223, 82);
            this.textBox_Student.Name = "textBox_Student";
            this.textBox_Student.Size = new System.Drawing.Size(100, 22);
            this.textBox_Student.TabIndex = 4;
            // 
            // textBox_Score
            // 
            this.textBox_Score.Location = new System.Drawing.Point(223, 183);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(100, 22);
            this.textBox_Score.TabIndex = 5;
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(223, 132);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Course.TabIndex = 6;
            // 
            // textBox_des
            // 
            this.textBox_des.Location = new System.Drawing.Point(223, 249);
            this.textBox_des.Multiline = true;
            this.textBox_des.Name = "textBox_des";
            this.textBox_des.Size = new System.Drawing.Size(194, 125);
            this.textBox_des.TabIndex = 7;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(87, 425);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(168, 425);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 9;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_avg
            // 
            this.button_avg.Location = new System.Drawing.Point(249, 425);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(182, 23);
            this.button_avg.TabIndex = 10;
            this.button_avg.Text = "Average Score By Course";
            this.button_avg.UseVisualStyleBackColor = true;
            this.button_avg.Click += new System.EventHandler(this.button_avg_Click);
            // 
            // button_student
            // 
            this.button_student.Location = new System.Drawing.Point(669, 79);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(75, 23);
            this.button_student.TabIndex = 11;
            this.button_student.Text = "Students";
            this.button_student.UseVisualStyleBackColor = true;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // button_show_score
            // 
            this.button_show_score.Location = new System.Drawing.Point(834, 79);
            this.button_show_score.Name = "button_show_score";
            this.button_show_score.Size = new System.Drawing.Size(75, 23);
            this.button_show_score.TabIndex = 12;
            this.button_show_score.Text = "Scores";
            this.button_show_score.UseVisualStyleBackColor = true;
            this.button_show_score.Click += new System.EventHandler(this.button_show_score_Click);
            // 
            // dataGridViewStudentScore
            // 
            this.dataGridViewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentScore.Location = new System.Drawing.Point(456, 168);
            this.dataGridViewStudentScore.Name = "dataGridViewStudentScore";
            this.dataGridViewStudentScore.RowHeadersWidth = 51;
            this.dataGridViewStudentScore.RowTemplate.Height = 24;
            this.dataGridViewStudentScore.Size = new System.Drawing.Size(611, 309);
            this.dataGridViewStudentScore.TabIndex = 13;
            this.dataGridViewStudentScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentScore_CellContentClick);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(127, 467);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 627);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.dataGridViewStudentScore);
            this.Controls.Add(this.button_show_score);
            this.Controls.Add(this.button_student);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_des);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.textBox_Student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Student;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.TextBox textBox_des;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_avg;
        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Button button_show_score;
        private System.Windows.Forms.DataGridView dataGridViewStudentScore;
        private System.Windows.Forms.Button button_Cancel;
    }
}