namespace QLSV.score
{
    partial class PrintScore
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
            this.qLSVDataSet3 = new QLSV.QLSVDataSet3();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter = new QLSV.QLSVDataSet3TableAdapters.scoreTableAdapter();
            this.qLSVDataSet4 = new QLSV.QLSVDataSet4();
            this.scoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter1 = new QLSV.QLSVDataSet4TableAdapters.scoreTableAdapter();
            this.qLSVDataSet5 = new QLSV.QLSVDataSet5();
            this.scoreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTableAdapter2 = new QLSV.QLSVDataSet5TableAdapters.scoreTableAdapter();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // printWord_button
            // 
            this.printWord_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.printWord_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printWord_button.Location = new System.Drawing.Point(447, 409);
            this.printWord_button.Name = "printWord_button";
            this.printWord_button.Size = new System.Drawing.Size(156, 38);
            this.printWord_button.TabIndex = 14;
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
            this.printButton.Location = new System.Drawing.Point(35, 409);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(155, 38);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "Print to Excel";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printtoPDF_button
            // 
            this.printtoPDF_button.BackColor = System.Drawing.Color.OrangeRed;
            this.printtoPDF_button.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printtoPDF_button.Location = new System.Drawing.Point(231, 409);
            this.printtoPDF_button.Name = "printtoPDF_button";
            this.printtoPDF_button.Size = new System.Drawing.Size(160, 38);
            this.printtoPDF_button.TabIndex = 13;
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
            this.studentidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn,
            this.studentscoreDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewPF.DataSource = this.scoreBindingSource2;
            this.dataGridViewPF.Location = new System.Drawing.Point(35, 77);
            this.dataGridViewPF.Name = "dataGridViewPF";
            this.dataGridViewPF.RowHeadersWidth = 51;
            this.dataGridViewPF.RowTemplate.Height = 24;
            this.dataGridViewPF.Size = new System.Drawing.Size(928, 296);
            this.dataGridViewPF.TabIndex = 11;
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
            // qLSVDataSet3
            // 
            this.qLSVDataSet3.DataSetName = "QLSVDataSet3";
            this.qLSVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "score";
            this.scoreBindingSource.DataSource = this.qLSVDataSet3;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // qLSVDataSet4
            // 
            this.qLSVDataSet4.DataSetName = "QLSVDataSet4";
            this.qLSVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource1
            // 
            this.scoreBindingSource1.DataMember = "score";
            this.scoreBindingSource1.DataSource = this.qLSVDataSet4;
            // 
            // scoreTableAdapter1
            // 
            this.scoreTableAdapter1.ClearBeforeFill = true;
            // 
            // qLSVDataSet5
            // 
            this.qLSVDataSet5.DataSetName = "QLSVDataSet5";
            this.qLSVDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreBindingSource2
            // 
            this.scoreBindingSource2.DataMember = "score";
            this.scoreBindingSource2.DataSource = this.qLSVDataSet5;
            // 
            // scoreTableAdapter2
            // 
            this.scoreTableAdapter2.ClearBeforeFill = true;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // studentscoreDataGridViewTextBoxColumn
            // 
            this.studentscoreDataGridViewTextBoxColumn.DataPropertyName = "student_score";
            this.studentscoreDataGridViewTextBoxColumn.HeaderText = "student_score";
            this.studentscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentscoreDataGridViewTextBoxColumn.Name = "studentscoreDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // PrintScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 524);
            this.Controls.Add(this.printWord_button);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.printtoPDF_button);
            this.Controls.Add(this.dataGridViewPF);
            this.Name = "PrintScore";
            this.Text = "PrintScore";
            this.Load += new System.EventHandler(this.PrintScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_demoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource courseBindingSource;
        private QLSVDataSet qLSVDataSet;
        private QLSVDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private QLSVDataSet3 qLSVDataSet3;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private QLSVDataSet3TableAdapters.scoreTableAdapter scoreTableAdapter;
        private QLSVDataSet4 qLSVDataSet4;
        private System.Windows.Forms.BindingSource scoreBindingSource1;
        private QLSVDataSet4TableAdapters.scoreTableAdapter scoreTableAdapter1;
        private QLSVDataSet5 qLSVDataSet5;
        private System.Windows.Forms.BindingSource scoreBindingSource2;
        private QLSVDataSet5TableAdapters.scoreTableAdapter scoreTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}