namespace QLSV
{
    partial class ManageUser
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
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonUnblock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonBlock = new System.Windows.Forms.RadioButton();
            this.radioButtonUnblock = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btInsert.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btInsert.Location = new System.Drawing.Point(232, 520);
            this.btInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(93, 52);
            this.btInsert.TabIndex = 115;
            this.btInsert.Text = "Add";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Gray;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDelete.Location = new System.Drawing.Point(359, 520);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(93, 52);
            this.btDelete.TabIndex = 114;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Teal;
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEdit.Location = new System.Drawing.Point(72, 520);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(121, 52);
            this.btEdit.TabIndex = 113;
            this.btEdit.Text = "Change Pass";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Black;
            this.btRefresh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRefresh.Location = new System.Drawing.Point(561, 74);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(99, 52);
            this.btRefresh.TabIndex = 112;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Peru;
            this.btFind.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btFind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFind.Location = new System.Drawing.Point(456, 76);
            this.btFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(97, 52);
            this.btFind.TabIndex = 111;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSearch.Location = new System.Drawing.Point(456, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 31);
            this.txtSearch.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 109;
            this.label4.Text = "Search User, Gmail:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 262);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(653, 237);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtGmail
            // 
            this.txtGmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(198, 112);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGmail.Multiline = true;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(194, 34);
            this.txtGmail.TabIndex = 107;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(198, 55);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(194, 34);
            this.txtPass.TabIndex = 106;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtUser.Location = new System.Drawing.Point(198, 3);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 31);
            this.txtUser.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 104;
            this.label3.Text = "Gmail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(68, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Username:";
            // 
            // buttonBlock
            // 
            this.buttonBlock.BackColor = System.Drawing.Color.LightCoral;
            this.buttonBlock.Location = new System.Drawing.Point(492, 520);
            this.buttonBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(93, 52);
            this.buttonBlock.TabIndex = 122;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = false;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonUnblock
            // 
            this.buttonUnblock.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonUnblock.Location = new System.Drawing.Point(614, 520);
            this.buttonUnblock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUnblock.Name = "buttonUnblock";
            this.buttonUnblock.Size = new System.Drawing.Size(93, 52);
            this.buttonUnblock.TabIndex = 123;
            this.buttonUnblock.Text = "Unblock";
            this.buttonUnblock.UseVisualStyleBackColor = false;
            this.buttonUnblock.Click += new System.EventHandler(this.buttonUnblock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(68, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 120;
            this.label5.Text = "State:";
            this.label5.Visible = false;
            // 
            // radioButtonBlock
            // 
            this.radioButtonBlock.AutoSize = true;
            this.radioButtonBlock.Location = new System.Drawing.Point(198, 168);
            this.radioButtonBlock.Name = "radioButtonBlock";
            this.radioButtonBlock.Size = new System.Drawing.Size(55, 21);
            this.radioButtonBlock.TabIndex = 124;
            this.radioButtonBlock.TabStop = true;
            this.radioButtonBlock.Text = "Block";
            this.radioButtonBlock.UseVisualStyleBackColor = true;
            this.radioButtonBlock.Visible = false;
            // 
            // radioButtonUnblock
            // 
            this.radioButtonUnblock.AutoSize = true;
            this.radioButtonUnblock.Location = new System.Drawing.Point(198, 195);
            this.radioButtonUnblock.Name = "radioButtonUnblock";
            this.radioButtonUnblock.Size = new System.Drawing.Size(69, 21);
            this.radioButtonUnblock.TabIndex = 125;
            this.radioButtonUnblock.TabStop = true;
            this.radioButtonUnblock.Text = "Unblock";
            this.radioButtonUnblock.UseVisualStyleBackColor = true;
            this.radioButtonUnblock.Visible = false;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 639);
            this.Controls.Add(this.radioButtonUnblock);
            this.Controls.Add(this.radioButtonBlock);
            this.Controls.Add(this.buttonUnblock);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btFind;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtGmail;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button buttonUnblock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonBlock;
        private System.Windows.Forms.RadioButton radioButtonUnblock;
    }
}