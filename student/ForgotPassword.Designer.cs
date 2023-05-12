namespace QLSV
{
    partial class ForgotPassword
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
            this.textBox_Gmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_sendOTP = new System.Windows.Forms.Button();
            this.textBox_OTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Gmail
            // 
            this.textBox_Gmail.Location = new System.Drawing.Point(261, 136);
            this.textBox_Gmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Gmail.Multiline = true;
            this.textBox_Gmail.Name = "textBox_Gmail";
            this.textBox_Gmail.Size = new System.Drawing.Size(260, 27);
            this.textBox_Gmail.TabIndex = 8;
            this.textBox_Gmail.TextChanged += new System.EventHandler(this.textBox_Gmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gmail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(261, 284);
            this.button_Next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(56, 19);
            this.button_Next.TabIndex = 11;
            this.button_Next.Text = "NEXT";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_sendOTP
            // 
            this.button_sendOTP.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sendOTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_sendOTP.Location = new System.Drawing.Point(438, 180);
            this.button_sendOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sendOTP.Name = "button_sendOTP";
            this.button_sendOTP.Size = new System.Drawing.Size(82, 25);
            this.button_sendOTP.TabIndex = 18;
            this.button_sendOTP.Text = "Send OTP";
            this.button_sendOTP.UseVisualStyleBackColor = true;
            this.button_sendOTP.Click += new System.EventHandler(this.button_sendOTP_Click);
            // 
            // textBox_OTP
            // 
            this.textBox_OTP.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_OTP.Location = new System.Drawing.Point(261, 180);
            this.textBox_OTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_OTP.Multiline = true;
            this.textBox_OTP.Name = "textBox_OTP";
            this.textBox_OTP.Size = new System.Drawing.Size(260, 26);
            this.textBox_OTP.TabIndex = 17;
            this.textBox_OTP.TextChanged += new System.EventHandler(this.textBox_OTP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "OTP:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_sendOTP);
            this.Controls.Add(this.textBox_OTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.textBox_Gmail);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Gmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_sendOTP;
        private System.Windows.Forms.TextBox textBox_OTP;
        private System.Windows.Forms.Label label6;
    }
}