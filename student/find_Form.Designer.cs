namespace QLSV
{
    partial class find_Form
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
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSV_demoDataSet = new QLSV.QLSV_demoDataSet();
            this.findFF_button = new System.Windows.Forms.Button();
            this.comboBoxFF = new System.Windows.Forms.ComboBox();
            this.textBoxFF = new System.Windows.Forms.TextBox();
            this.stdTableAdapter = new QLSV.QLSV_demoDataSetTableAdapters.stdTableAdapter();
            this.refresh_Button = new System.Windows.Forms.Button();
            this.print_Button = new System.Windows.Forms.Button();
            this.dataGridViewFF = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falcutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSV_demoDataSet1 = new QLSV.QLSV_demoDataSet1();
            this.stdTableAdapter1 = new QLSV.QLSV_demoDataSet1TableAdapters.stdTableAdapter();
            this.total_Student = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLSV_demoDataSet;
            // 
            // qLSV_demoDataSet
            // 
            this.qLSV_demoDataSet.DataSetName = "QLSV_demoDataSet";
            this.qLSV_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findFF_button
            // 
            this.findFF_button.Location = new System.Drawing.Point(622, 8);
            this.findFF_button.Name = "findFF_button";
            this.findFF_button.Size = new System.Drawing.Size(75, 23);
            this.findFF_button.TabIndex = 1;
            this.findFF_button.Text = "Find";
            this.findFF_button.UseVisualStyleBackColor = true;
            this.findFF_button.Click += new System.EventHandler(this.findFF_button_Click);
            // 
            // comboBoxFF
            // 
            this.comboBoxFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFF.FormattingEnabled = true;
            this.comboBoxFF.Items.AddRange(new object[] {
            "Find by ID",
            "Find by First Name",
            "Find by Last Name",
            "Find by Phone Number"});
            this.comboBoxFF.Location = new System.Drawing.Point(304, 8);
            this.comboBoxFF.Name = "comboBoxFF";
            this.comboBoxFF.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFF.TabIndex = 2;
            // 
            // textBoxFF
            // 
            this.textBoxFF.Location = new System.Drawing.Point(431, 10);
            this.textBoxFF.Name = "textBoxFF";
            this.textBoxFF.Size = new System.Drawing.Size(165, 22);
            this.textBoxFF.TabIndex = 3;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // refresh_Button
            // 
            this.refresh_Button.Location = new System.Drawing.Point(407, 458);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.Size = new System.Drawing.Size(75, 23);
            this.refresh_Button.TabIndex = 4;
            this.refresh_Button.Text = "Refresh";
            this.refresh_Button.UseVisualStyleBackColor = true;
            this.refresh_Button.Click += new System.EventHandler(this.refresh_Button_Click);
            // 
            // print_Button
            // 
            this.print_Button.Location = new System.Drawing.Point(511, 458);
            this.print_Button.Name = "print_Button";
            this.print_Button.Size = new System.Drawing.Size(75, 23);
            this.print_Button.TabIndex = 5;
            this.print_Button.Text = "Print";
            this.print_Button.UseVisualStyleBackColor = true;
            this.print_Button.Click += new System.EventHandler(this.print_Button_Click);
            // 
            // dataGridViewFF
            // 
            this.dataGridViewFF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFF.AutoGenerateColumns = false;
            this.dataGridViewFF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.falcutyDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridViewFF.DataSource = this.stdBindingSource1;
            this.dataGridViewFF.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewFF.Name = "dataGridViewFF";
            this.dataGridViewFF.RowHeadersWidth = 51;
            this.dataGridViewFF.RowTemplate.Height = 24;
            this.dataGridViewFF.Size = new System.Drawing.Size(905, 390);
            this.dataGridViewFF.TabIndex = 6;
            this.dataGridViewFF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CCdoubleclick_event);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "mname";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "mname";
            this.mnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "bdate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // falcutyDataGridViewTextBoxColumn
            // 
            this.falcutyDataGridViewTextBoxColumn.DataPropertyName = "falcuty";
            this.falcutyDataGridViewTextBoxColumn.HeaderText = "falcuty";
            this.falcutyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.falcutyDataGridViewTextBoxColumn.Name = "falcutyDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            this.stdBindingSource1.DataSource = this.qLSV_demoDataSet1;
            // 
            // qLSV_demoDataSet1
            // 
            this.qLSV_demoDataSet1.DataSetName = "QLSV_demoDataSet1";
            this.qLSV_demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter1
            // 
            this.stdTableAdapter1.ClearBeforeFill = true;
            // 
            // total_Student
            // 
            this.total_Student.AutoSize = true;
            this.total_Student.Location = new System.Drawing.Point(13, 465);
            this.total_Student.Name = "total_Student";
            this.total_Student.Size = new System.Drawing.Size(101, 17);
            this.total_Student.TabIndex = 7;
            this.total_Student.Text = "Total Student: ";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(304, 458);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // find_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.total_Student);
            this.Controls.Add(this.dataGridViewFF);
            this.Controls.Add(this.print_Button);
            this.Controls.Add(this.refresh_Button);
            this.Controls.Add(this.textBoxFF);
            this.Controls.Add(this.comboBoxFF);
            this.Controls.Add(this.findFF_button);
            this.Name = "find_Form";
            this.Text = "find_Form";
            this.Load += new System.EventHandler(this.find_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findFF_button;
        private System.Windows.Forms.ComboBox comboBoxFF;
        private System.Windows.Forms.TextBox textBoxFF;
        private QLSV_demoDataSet qLSV_demoDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSV_demoDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.Button refresh_Button;
        private System.Windows.Forms.Button print_Button;
        public System.Windows.Forms.DataGridView dataGridViewFF;
        private QLSV_demoDataSet1 qLSV_demoDataSet1;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private QLSV_demoDataSet1TableAdapters.stdTableAdapter stdTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn falcutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Label total_Student;
        private System.Windows.Forms.Button button_Add;
    }
}