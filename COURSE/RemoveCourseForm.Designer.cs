namespace QLSV
{
    partial class RemoveCourseForm
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
            this.CourseID_Txt = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttoncc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Course ID:";
            // 
            // CourseID_Txt
            // 
            this.CourseID_Txt.Location = new System.Drawing.Point(248, 95);
            this.CourseID_Txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseID_Txt.Multiline = true;
            this.CourseID_Txt.Name = "CourseID_Txt";
            this.CourseID_Txt.Size = new System.Drawing.Size(228, 42);
            this.CourseID_Txt.TabIndex = 1;
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.remove_button.Location = new System.Drawing.Point(88, 195);
            this.remove_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(152, 42);
            this.remove_button.TabIndex = 2;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(116, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remove Course";
            // 
            // buttoncc
            // 
            this.buttoncc.BackColor = System.Drawing.Color.Chocolate;
            this.buttoncc.Location = new System.Drawing.Point(276, 195);
            this.buttoncc.Name = "buttoncc";
            this.buttoncc.Size = new System.Drawing.Size(152, 42);
            this.buttoncc.TabIndex = 4;
            this.buttoncc.Text = "Cancel";
            this.buttoncc.UseVisualStyleBackColor = false;
            this.buttoncc.Click += new System.EventHandler(this.buttoncc_Click);
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(521, 275);
            this.Controls.Add(this.buttoncc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.CourseID_Txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CourseID_Txt;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttoncc;
    }
}