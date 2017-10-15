namespace JobFairsApp
{
    partial class formAddJobFairPerson
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
            this.labelPerson = new System.Windows.Forms.Label();
            this.lbJobFair = new System.Windows.Forms.ListBox();
            this.lbPerson = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.jobFairDataSet = new JobFairsApp.JobFairDataSet();
            this.jobFairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairsTableAdapter = new JobFairsApp.JobFairDataSetTableAdapters.JobFairsTableAdapter();
            this.contactPersonDataSet = new JobFairsApp.ContactPersonDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new JobFairsApp.ContactPersonDataSetTableAdapters.PeopleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJobFair
            // 
            this.labelJobFair.AutoSize = true;
            this.labelJobFair.Location = new System.Drawing.Point(28, 30);
            this.labelJobFair.Name = "labelJobFair";
            this.labelJobFair.Size = new System.Drawing.Size(89, 13);
            this.labelJobFair.TabIndex = 0;
            this.labelJobFair.Text = "Select the job fair";
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Location = new System.Drawing.Point(237, 30);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(90, 13);
            this.labelPerson.TabIndex = 1;
            this.labelPerson.Text = "Select the person";
            // 
            // lbJobFair
            // 
            this.lbJobFair.DataSource = this.jobFairsBindingSource;
            this.lbJobFair.DisplayMember = "Title";
            this.lbJobFair.FormattingEnabled = true;
            this.lbJobFair.Location = new System.Drawing.Point(31, 59);
            this.lbJobFair.Name = "lbJobFair";
            this.lbJobFair.Size = new System.Drawing.Size(187, 238);
            this.lbJobFair.TabIndex = 2;
            this.lbJobFair.ValueMember = "ID";
            // 
            // lbPerson
            // 
            this.lbPerson.DataSource = this.peopleBindingSource;
            this.lbPerson.DisplayMember = "First";
            this.lbPerson.FormattingEnabled = true;
            this.lbPerson.Location = new System.Drawing.Point(240, 59);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(187, 238);
            this.lbPerson.TabIndex = 3;
            this.lbPerson.ValueMember = "ID";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(31, 315);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(352, 315);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
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
            // contactPersonDataSet
            // 
            this.contactPersonDataSet.DataSetName = "ContactPersonDataSet";
            this.contactPersonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.contactPersonDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // formAddJobFairPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 353);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbPerson);
            this.Controls.Add(this.lbJobFair);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.labelJobFair);
            this.Name = "formAddJobFairPerson";
            this.Text = "formAddJobFairPerson";
            this.Load += new System.EventHandler(this.formAddJobFairPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJobFair;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.ListBox lbJobFair;
        private System.Windows.Forms.ListBox lbPerson;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDone;
        private JobFairDataSet jobFairDataSet;
        private System.Windows.Forms.BindingSource jobFairsBindingSource;
        private JobFairDataSetTableAdapters.JobFairsTableAdapter jobFairsTableAdapter;
        private ContactPersonDataSet contactPersonDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private ContactPersonDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
    }
}