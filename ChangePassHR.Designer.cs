namespace QLSV
{
    partial class ChangePassHR
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
            this.button_Confirm = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.textBox_cfPass = new System.Windows.Forms.TextBox();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(229, 245);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(74, 19);
            this.button_Confirm.TabIndex = 23;
            this.button_Confirm.Text = "CONFIRM";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(418, 181);
            this.checkBox_ShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(104, 19);
            this.checkBox_ShowPassword.TabIndex = 22;
            this.checkBox_ShowPassword.Text = "Show Password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // textBox_cfPass
            // 
            this.textBox_cfPass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_cfPass.Location = new System.Drawing.Point(252, 145);
            this.textBox_cfPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_cfPass.Name = "textBox_cfPass";
            this.textBox_cfPass.PasswordChar = '*';
            this.textBox_cfPass.Size = new System.Drawing.Size(260, 20);
            this.textBox_cfPass.TabIndex = 21;
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.Location = new System.Drawing.Point(252, 84);
            this.textBox_NewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.PasswordChar = '*';
            this.textBox_NewPass.Size = new System.Drawing.Size(260, 20);
            this.textBox_NewPass.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "New Password:";
            // 
            // ChangePassHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 302);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.textBox_cfPass);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ChangePassHR";
            this.Text = "ChangePassHR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private System.Windows.Forms.TextBox textBox_cfPass;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}