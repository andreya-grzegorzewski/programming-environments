namespace JobFairsApp
{
    partial class formAddCandidate
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
            this.labelEmployment = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.cbEmployment = new System.Windows.Forms.ComboBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.employmentTypesDataSet = new JobFairsApp.EmploymentTypesDataSet();
            this.employmentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employmentTypesTableAdapter = new JobFairsApp.EmploymentTypesDataSetTableAdapters.EmploymentTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employmentTypesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployment
            // 
            this.labelEmployment.AutoSize = true;
            this.labelEmployment.Location = new System.Drawing.Point(25, 30);
            this.labelEmployment.Name = "labelEmployment";
            this.labelEmployment.Size = new System.Drawing.Size(87, 13);
            this.labelEmployment.TabIndex = 0;
            this.labelEmployment.Text = "Employment type";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(25, 52);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(74, 13);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "Year in school";
            // 
            // cbEmployment
            // 
            this.cbEmployment.DataSource = this.employmentTypesBindingSource;
            this.cbEmployment.DisplayMember = "Name";
            this.cbEmployment.FormattingEnabled = true;
            this.cbEmployment.Location = new System.Drawing.Point(134, 21);
            this.cbEmployment.Name = "cbEmployment";
            this.cbEmployment.Size = new System.Drawing.Size(168, 21);
            this.cbEmployment.TabIndex = 2;
            this.cbEmployment.ValueMember = "ID";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(134, 52);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(168, 20);
            this.tbYear.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(28, 96);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // employmentTypesDataSet
            // 
            this.employmentTypesDataSet.DataSetName = "EmploymentTypesDataSet";
            this.employmentTypesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employmentTypesBindingSource
            // 
            this.employmentTypesBindingSource.DataMember = "EmploymentTypes";
            this.employmentTypesBindingSource.DataSource = this.employmentTypesDataSet;
            // 
            // employmentTypesTableAdapter
            // 
            this.employmentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // formAddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 162);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.cbEmployment);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelEmployment);
            this.Name = "formAddCandidate";
            this.Text = "formAddCandidate";
            this.Load += new System.EventHandler(this.formAddCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employmentTypesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employmentTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployment;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ComboBox cbEmployment;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Button btnConfirm;
        private EmploymentTypesDataSet employmentTypesDataSet;
        private System.Windows.Forms.BindingSource employmentTypesBindingSource;
        private EmploymentTypesDataSetTableAdapters.EmploymentTypesTableAdapter employmentTypesTableAdapter;
    }
}