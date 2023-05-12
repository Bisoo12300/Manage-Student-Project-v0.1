namespace QLSV
{
    partial class EditCourseForm
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
            this.label_txt = new System.Windows.Forms.TextBox();
            this.textBox_descrip = new System.Windows.Forms.TextBox();
            this.edit_Button = new System.Windows.Forms.Button();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.numericUpDown_period = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_period)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description: ";
            // 
            // label_txt
            // 
            this.label_txt.Location = new System.Drawing.Point(250, 200);
            this.label_txt.Margin = new System.Windows.Forms.Padding(4);
            this.label_txt.Name = "label_txt";
            this.label_txt.Size = new System.Drawing.Size(216, 31);
            this.label_txt.TabIndex = 5;
            // 
            // textBox_descrip
            // 
            this.textBox_descrip.Location = new System.Drawing.Point(250, 410);
            this.textBox_descrip.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_descrip.Multiline = true;
            this.textBox_descrip.Name = "textBox_descrip";
            this.textBox_descrip.Size = new System.Drawing.Size(216, 113);
            this.textBox_descrip.TabIndex = 7;
            // 
            // edit_Button
            // 
            this.edit_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit_Button.Location = new System.Drawing.Point(281, 561);
            this.edit_Button.Margin = new System.Windows.Forms.Padding(4);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(216, 54);
            this.edit_Button.TabIndex = 8;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = false;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(250, 131);
            this.comboBox_course.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(216, 32);
            this.comboBox_course.TabIndex = 9;
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged_1);
            // 
            // numericUpDown_period
            // 
            this.numericUpDown_period.Location = new System.Drawing.Point(250, 277);
            this.numericUpDown_period.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_period.Name = "numericUpDown_period";
            this.numericUpDown_period.Size = new System.Drawing.Size(216, 31);
            this.numericUpDown_period.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 348);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Semester: ";
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_semester.Location = new System.Drawing.Point(250, 348);
            this.comboBox_semester.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(216, 32);
            this.comboBox_semester.TabIndex = 12;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(42, 561);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(216, 54);
            this.buttoncancel.TabIndex = 13;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Edit Course";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(572, 648);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.comboBox_semester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_period);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.textBox_descrip);
            this.Controls.Add(this.label_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox label_txt;
        private System.Windows.Forms.TextBox textBox_descrip;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.NumericUpDown numericUpDown_period;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_semester;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Label label6;
    }
}