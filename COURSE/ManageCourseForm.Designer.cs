
namespace QLSV
{
    partial class ManageCourseForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.First_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.Previous_button = new System.Windows.Forms.Button();
            this.Last_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.total_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textbox_desc = new System.Windows.Forms.RichTextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_semes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // First_button
            // 
            this.First_button.Location = new System.Drawing.Point(51, 472);
            this.First_button.Margin = new System.Windows.Forms.Padding(4);
            this.First_button.Name = "First_button";
            this.First_button.Size = new System.Drawing.Size(94, 34);
            this.First_button.TabIndex = 6;
            this.First_button.Text = "First";
            this.First_button.UseVisualStyleBackColor = true;
            this.First_button.Click += new System.EventHandler(this.First_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(165, 472);
            this.Next_button.Margin = new System.Windows.Forms.Padding(4);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(94, 34);
            this.Next_button.TabIndex = 7;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Previous_button
            // 
            this.Previous_button.Location = new System.Drawing.Point(268, 472);
            this.Previous_button.Margin = new System.Windows.Forms.Padding(4);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(94, 34);
            this.Previous_button.TabIndex = 8;
            this.Previous_button.Text = "Previous";
            this.Previous_button.UseVisualStyleBackColor = true;
            this.Previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // Last_button
            // 
            this.Last_button.Location = new System.Drawing.Point(370, 471);
            this.Last_button.Margin = new System.Windows.Forms.Padding(4);
            this.Last_button.Name = "Last_button";
            this.Last_button.Size = new System.Drawing.Size(94, 34);
            this.Last_button.TabIndex = 9;
            this.Last_button.Text = "Last";
            this.Last_button.UseVisualStyleBackColor = true;
            this.Last_button.Click += new System.EventHandler(this.Last_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(50, 576);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(94, 34);
            this.Add_button.TabIndex = 10;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(151, 576);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(94, 34);
            this.Edit_button.TabIndex = 11;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 19;
            this.listBoxCourse.Location = new System.Drawing.Point(518, 88);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(338, 460);
            this.listBoxCourse.TabIndex = 10;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            this.listBoxCourse.DoubleClick += new System.EventHandler(this.listBoxCourse_DoubleClick);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(721, 555);
            this.total_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(100, 19);
            this.total_label.TabIndex = 11;
            this.total_label.Text = "Total Course: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(201, 56);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(204, 26);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(201, 125);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(204, 26);
            this.textBoxLabel.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(201, 182);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(204, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textbox_desc
            // 
            this.textbox_desc.Location = new System.Drawing.Point(201, 290);
            this.textbox_desc.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_desc.Name = "textbox_desc";
            this.textbox_desc.Size = new System.Drawing.Size(204, 142);
            this.textbox_desc.TabIndex = 14;
            this.textbox_desc.Text = "";
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(268, 576);
            this.Remove_button.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(94, 34);
            this.Remove_button.TabIndex = 12;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Semester:";
            // 
            // comboBox_semes
            // 
            this.comboBox_semes.FormattingEnabled = true;
            this.comboBox_semes.Items.AddRange(new object[] {
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
            this.comboBox_semes.Location = new System.Drawing.Point(201, 231);
            this.comboBox_semes.Name = "comboBox_semes";
            this.comboBox_semes.Size = new System.Drawing.Size(204, 27);
            this.comboBox_semes.TabIndex = 16;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.comboBox_semes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.textbox_desc);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Last_button);
            this.Controls.Add(this.Previous_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.First_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageCourseForm";
            this.Text = "Manage Course ";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button First_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.Button Last_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox textbox_desc;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_semes;
    }
}