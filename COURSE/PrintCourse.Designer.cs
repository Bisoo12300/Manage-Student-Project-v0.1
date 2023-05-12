namespace QLSV
{
    partial class PrintCourse
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
            this.printWord_button = new System.Windows.Forms.Button();
            this.stdTableAdapter = new QLSV.QLSV_demoDataSet2TableAdapters.stdTableAdapter();
            this.printButton = new System.Windows.Forms.Button();
            this.printtoPDF_button = new System.Windows.Forms.Button();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSV_demoDataSet2 = new QLSV.QLSV_demoDataSet2();
            this.dataGridViewPF = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new QLSV.QLSVDataSet();
            this.courseTableAdapter = new QLSV.QLSVDataSetTableAdapters.courseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // printWord_button
            // 
            this.printWord_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.printWord_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printWord_button.Location = new System.Drawing.Point(412, 344);
            this.printWord_button.Name = "printWord_button";
            this.printWord_button.Size = new System.Drawing.Size(156, 38);
            this.printWord_button.TabIndex = 10;
            this.printWord_button.Text = "Print to Word";
            this.printWord_button.UseVisualStyleBackColor = false;
            this.printWord_button.Click += new System.EventHandler(this.printWord_button_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.printButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(0, 344);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(155, 38);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Print to Excel";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printtoPDF_button
            // 
            this.printtoPDF_button.BackColor = System.Drawing.Color.OrangeRed;
            this.printtoPDF_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printtoPDF_button.Location = new System.Drawing.Point(196, 344);
            this.printtoPDF_button.Name = "printtoPDF_button";
            this.printtoPDF_button.Size = new System.Drawing.Size(160, 38);
            this.printtoPDF_button.TabIndex = 9;
            this.printtoPDF_button.Text = "Print to PDF";
            this.printtoPDF_button.UseVisualStyleBackColor = false;
            this.printtoPDF_button.Click += new System.EventHandler(this.printtoPDF_button_Click);
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
            // dataGridViewPF
            // 
            this.dataGridViewPF.AutoGenerateColumns = false;
            this.dataGridViewPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewPF.DataSource = this.courseBindingSource;
            this.dataGridViewPF.Location = new System.Drawing.Point(0, 12);
            this.dataGridViewPF.Name = "dataGridViewPF";
            this.dataGridViewPF.RowHeadersWidth = 51;
            this.dataGridViewPF.RowTemplate.Height = 24;
            this.dataGridViewPF.Size = new System.Drawing.Size(928, 296);
            this.dataGridViewPF.TabIndex = 6;
            this.dataGridViewPF.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPF_CellContentClick);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "label";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // PrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 469);
            this.Controls.Add(this.printWord_button);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.printtoPDF_button);
            this.Controls.Add(this.dataGridViewPF);
            this.Name = "PrintCourse";
            this.Text = "PrintCourse";
            this.Load += new System.EventHandler(this.PrintCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printWord_button;
        private QLSV_demoDataSet2TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button printtoPDF_button;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSV_demoDataSet2 qLSV_demoDataSet2;
        private System.Windows.Forms.DataGridView dataGridViewPF;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private QLSVDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}