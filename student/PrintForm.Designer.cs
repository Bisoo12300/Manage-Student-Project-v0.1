namespace QLSV
{
    partial class PrintForm
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
            this.dataGridViewPF = new System.Windows.Forms.DataGridView();
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
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSV_demoDataSet2 = new QLSV.QLSV_demoDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allGender_ratiobutton = new System.Windows.Forms.RadioButton();
            this.check_button = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.no_radioButton = new System.Windows.Forms.RadioButton();
            this.yes_RatioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.Male_RatioButton = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this.stdTableAdapter = new QLSV.QLSV_demoDataSet2TableAdapters.stdTableAdapter();
            this.printtoPDF_button = new System.Windows.Forms.Button();
            this.printWord_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPF
            // 
            this.dataGridViewPF.AutoGenerateColumns = false;
            this.dataGridViewPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewPF.DataSource = this.stdBindingSource;
            this.dataGridViewPF.Location = new System.Drawing.Point(4, 135);
            this.dataGridViewPF.Name = "dataGridViewPF";
            this.dataGridViewPF.RowHeadersWidth = 51;
            this.dataGridViewPF.RowTemplate.Height = 24;
            this.dataGridViewPF.Size = new System.Drawing.Size(928, 322);
            this.dataGridViewPF.TabIndex = 0;
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
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLSV_demoDataSet2;
            // 
            // qLSV_demoDataSet2
            // 
            this.qLSV_demoDataSet2.DataSetName = "QLSV_demoDataSet2";
            this.qLSV_demoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allGender_ratiobutton);
            this.groupBox1.Controls.Add(this.check_button);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.no_radioButton);
            this.groupBox1.Controls.Add(this.yes_RatioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.female_radioButton);
            this.groupBox1.Controls.Add(this.Male_RatioButton);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // allGender_ratiobutton
            // 
            this.allGender_ratiobutton.AutoSize = true;
            this.allGender_ratiobutton.Location = new System.Drawing.Point(23, 47);
            this.allGender_ratiobutton.Name = "allGender_ratiobutton";
            this.allGender_ratiobutton.Size = new System.Drawing.Size(53, 28);
            this.allGender_ratiobutton.TabIndex = 11;
            this.allGender_ratiobutton.TabStop = true;
            this.allGender_ratiobutton.Text = "All";
            this.allGender_ratiobutton.UseVisualStyleBackColor = true;
            // 
            // check_button
            // 
            this.check_button.BackColor = System.Drawing.Color.Pink;
            this.check_button.Location = new System.Drawing.Point(548, 12);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(200, 37);
            this.check_button.TabIndex = 10;
            this.check_button.Text = "Check";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(548, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // no_radioButton
            // 
            this.no_radioButton.AutoSize = true;
            this.no_radioButton.Location = new System.Drawing.Point(443, 16);
            this.no_radioButton.Name = "no_radioButton";
            this.no_radioButton.Size = new System.Drawing.Size(54, 28);
            this.no_radioButton.TabIndex = 5;
            this.no_radioButton.TabStop = true;
            this.no_radioButton.Text = "No";
            this.no_radioButton.UseVisualStyleBackColor = true;
            this.no_radioButton.CheckedChanged += new System.EventHandler(this.no_radioButton_CheckedChanged);
            // 
            // yes_RatioButton
            // 
            this.yes_RatioButton.AutoSize = true;
            this.yes_RatioButton.Location = new System.Drawing.Point(370, 16);
            this.yes_RatioButton.Name = "yes_RatioButton";
            this.yes_RatioButton.Size = new System.Drawing.Size(59, 28);
            this.yes_RatioButton.TabIndex = 4;
            this.yes_RatioButton.TabStop = true;
            this.yes_RatioButton.Text = "Yes";
            this.yes_RatioButton.UseVisualStyleBackColor = true;
            this.yes_RatioButton.CheckedChanged += new System.EventHandler(this.yes_RatioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use Range: ";
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(157, 47);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(86, 28);
            this.female_radioButton.TabIndex = 2;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Male_RatioButton
            // 
            this.Male_RatioButton.AutoSize = true;
            this.Male_RatioButton.Location = new System.Drawing.Point(82, 47);
            this.Male_RatioButton.Name = "Male_RatioButton";
            this.Male_RatioButton.Size = new System.Drawing.Size(69, 28);
            this.Male_RatioButton.TabIndex = 1;
            this.Male_RatioButton.TabStop = true;
            this.Male_RatioButton.Text = "Male";
            this.Male_RatioButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.printButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(134, 464);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(155, 38);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print to Excel";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // printtoPDF_button
            // 
            this.printtoPDF_button.BackColor = System.Drawing.Color.OrangeRed;
            this.printtoPDF_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printtoPDF_button.Location = new System.Drawing.Point(341, 464);
            this.printtoPDF_button.Name = "printtoPDF_button";
            this.printtoPDF_button.Size = new System.Drawing.Size(160, 38);
            this.printtoPDF_button.TabIndex = 4;
            this.printtoPDF_button.Text = "Print to PDF";
            this.printtoPDF_button.UseVisualStyleBackColor = false;
            this.printtoPDF_button.Click += new System.EventHandler(this.printtoPDF_button_Click);
            // 
            // printWord_button
            // 
            this.printWord_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.printWord_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printWord_button.Location = new System.Drawing.Point(542, 464);
            this.printWord_button.Name = "printWord_button";
            this.printWord_button.Size = new System.Drawing.Size(156, 38);
            this.printWord_button.TabIndex = 5;
            this.printWord_button.Text = "Print to Word";
            this.printWord_button.UseVisualStyleBackColor = false;
            this.printWord_button.Click += new System.EventHandler(this.printWord_button_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(935, 587);
            this.Controls.Add(this.printWord_button);
            this.Controls.Add(this.printtoPDF_button);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPF);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton no_radioButton;
        private System.Windows.Forms.RadioButton yes_RatioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton Male_RatioButton;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.RadioButton allGender_ratiobutton;
        private System.Windows.Forms.Button printButton;
        private QLSV_demoDataSet2 qLSV_demoDataSet2;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSV_demoDataSet2TableAdapters.stdTableAdapter stdTableAdapter;
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
        private System.Windows.Forms.Button printtoPDF_button;
        private System.Windows.Forms.Button printWord_button;
    }
}