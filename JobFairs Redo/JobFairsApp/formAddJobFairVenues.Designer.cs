namespace JobFairsApp
{
    partial class formAddJobFairVenues
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelJobFair = new System.Windows.Forms.Label();
            this.labelVenue = new System.Windows.Forms.Label();
            this.labelAssocations = new System.Windows.Forms.Label();
            this.lbAssociations = new System.Windows.Forms.ListBox();
            this.cbJobFair = new System.Windows.Forms.ComboBox();
            this.jobFairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairDataSet = new JobFairsApp.JobFairDataSet();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.jobFairsTableAdapter = new JobFairsApp.JobFairDataSetTableAdapters.JobFairsTableAdapter();
            this.venuesDataSet = new JobFairsApp.VenuesDataSet();
            this.venuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venuesTableAdapter = new JobFairsApp.VenuesDataSetTableAdapters.VenuesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(55, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Where is your job fair?";
            // 
            // labelJobFair
            // 
            this.labelJobFair.AutoSize = true;
            this.labelJobFair.Location = new System.Drawing.Point(55, 89);
            this.labelJobFair.Name = "labelJobFair";
            this.labelJobFair.Size = new System.Drawing.Size(44, 13);
            this.labelJobFair.TabIndex = 1;
            this.labelJobFair.Text = "Job Fair";
            // 
            // labelVenue
            // 
            this.labelVenue.AutoSize = true;
            this.labelVenue.Location = new System.Drawing.Point(55, 114);
            this.labelVenue.Name = "labelVenue";
            this.labelVenue.Size = new System.Drawing.Size(38, 13);
            this.labelVenue.TabIndex = 2;
            this.labelVenue.Text = "Venue";
            // 
            // labelAssocations
            // 
            this.labelAssocations.AutoSize = true;
            this.labelAssocations.Location = new System.Drawing.Point(305, 36);
            this.labelAssocations.Name = "labelAssocations";
            this.labelAssocations.Size = new System.Drawing.Size(66, 13);
            this.labelAssocations.TabIndex = 3;
            this.labelAssocations.Text = "Associations";
            // 
            // lbAssociations
            // 
            this.lbAssociations.FormattingEnabled = true;
            this.lbAssociations.Location = new System.Drawing.Point(308, 89);
            this.lbAssociations.Name = "lbAssociations";
            this.lbAssociations.Size = new System.Drawing.Size(257, 277);
            this.lbAssociations.TabIndex = 4;
            // 
            // cbJobFair
            // 
            this.cbJobFair.DataSource = this.jobFairsBindingSource;
            this.cbJobFair.DisplayMember = "Title";
            this.cbJobFair.FormattingEnabled = true;
            this.cbJobFair.Location = new System.Drawing.Point(114, 89);
            this.cbJobFair.Name = "cbJobFair";
            this.cbJobFair.Size = new System.Drawing.Size(146, 21);
            this.cbJobFair.TabIndex = 5;
            this.cbJobFair.ValueMember = "ID";
            // 
            // jobFairsBindingSource
            // 
            this.jobFairsBindingSource.DataMember = "JobFairs";
            this.jobFairsBindingSource.DataSource = this.jobFairDataSet;
            // 
            // jobFairDataSet
            // 
            this.jobFairDataSet.DataSetName = "JobFairDataSet";
            this.jobFairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbVenue
            // 
            this.cbVenue.DataSource = this.venuesBindingSource;
            this.cbVenue.DisplayMember = "Name";
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Location = new System.Drawing.Point(114, 116);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(146, 21);
            this.cbVenue.TabIndex = 6;
            this.cbVenue.ValueMember = "ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(58, 186);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add Venue to Job Fair";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // jobFairsTableAdapter
            // 
            this.jobFairsTableAdapter.ClearBeforeFill = true;
            // 
            // venuesDataSet
            // 
            this.venuesDataSet.DataSetName = "VenuesDataSet";
            this.venuesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venuesBindingSource
            // 
            this.venuesBindingSource.DataMember = "Venues";
            this.venuesBindingSource.DataSource = this.venuesDataSet;
            // 
            // venuesTableAdapter
            // 
            this.venuesTableAdapter.ClearBeforeFill = true;
            // 
            // formAddJobFairVenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 453);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.cbVenue);
            this.Controls.Add(this.cbJobFair);
            this.Controls.Add(this.lbAssociations);
            this.Controls.Add(this.labelAssocations);
            this.Controls.Add(this.labelVenue);
            this.Controls.Add(this.labelJobFair);
            this.Controls.Add(this.labelTitle);
            this.Name = "formAddJobFairVenues";
            this.Text = "Add Venue to Job Fair";
            this.Load += new System.EventHandler(this.formAddJobFairVenues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelJobFair;
        private System.Windows.Forms.Label labelVenue;
        private System.Windows.Forms.Label labelAssocations;
        private System.Windows.Forms.ListBox lbAssociations;
        private System.Windows.Forms.ComboBox cbJobFair;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.Button buttonAdd;
        private JobFairDataSet jobFairDataSet;
        private System.Windows.Forms.BindingSource jobFairsBindingSource;
        private JobFairDataSetTableAdapters.JobFairsTableAdapter jobFairsTableAdapter;
        private VenuesDataSet venuesDataSet;
        private System.Windows.Forms.BindingSource venuesBindingSource;
        private VenuesDataSetTableAdapters.VenuesTableAdapter venuesTableAdapter;
    }
}