namespace JobFairsApp
{
    partial class formAddLocation
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
            this.labelJobFair = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.cbJobFair = new System.Windows.Forms.ComboBox();
            this.jobFairDataSet = new JobFairsApp.JobFairDataSet();
            this.jobFairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairsTableAdapter = new JobFairsApp.JobFairDataSetTableAdapters.JobFairsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJobFair
            // 
            this.labelJobFair.AutoSize = true;
            this.labelJobFair.Location = new System.Drawing.Point(27, 38);
            this.labelJobFair.Name = "labelJobFair";
            this.labelJobFair.Size = new System.Drawing.Size(44, 13);
            this.labelJobFair.TabIndex = 0;
            this.labelJobFair.Text = "Job Fair";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(27, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Location Name";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(27, 86);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "Description";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(30, 209);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(64, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(155, 209);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(98, 23);
            this.btnAddLocation.TabIndex = 4;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(107, 83);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(146, 20);
            this.tbDesc.TabIndex = 6;
            // 
            // cbJobFair
            // 
            this.cbJobFair.DataSource = this.jobFairsBindingSource;
            this.cbJobFair.DisplayMember = "Title";
            this.cbJobFair.FormattingEnabled = true;
            this.cbJobFair.Location = new System.Drawing.Point(107, 38);
            this.cbJobFair.Name = "cbJobFair";
            this.cbJobFair.Size = new System.Drawing.Size(146, 21);
            this.cbJobFair.TabIndex = 7;
            this.cbJobFair.ValueMember = "ID";
            // 
            // jobFairDataSet
            // 
            this.jobFairDataSet.DataSetName = "JobFairDataSet";
            this.jobFairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobFairsBindingSource
            // 
            this.jobFairsBindingSource.DataMember = "JobFairs";
            this.jobFairsBindingSource.DataSource = this.jobFairDataSet;
            // 
            // jobFairsTableAdapter
            // 
            this.jobFairsTableAdapter.ClearBeforeFill = true;
            // 
            // formAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbJobFair);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelJobFair);
            this.Name = "formAddLocation";
            this.Text = "formAddLocation";
            this.Load += new System.EventHandler(this.formAddLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJobFair;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbJobFair;
        private JobFairDataSet jobFairDataSet;
        private System.Windows.Forms.BindingSource jobFairsBindingSource;
        private JobFairDataSetTableAdapters.JobFairsTableAdapter jobFairsTableAdapter;
    }
}