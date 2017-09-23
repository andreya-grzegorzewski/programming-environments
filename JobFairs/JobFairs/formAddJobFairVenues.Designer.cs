namespace JobFairs
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.cbJobFair = new System.Windows.Forms.ComboBox();
            this.labelJobFair = new System.Windows.Forms.Label();
            this.labelVenue = new System.Windows.Forms.Label();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.lbAssociations = new System.Windows.Forms.ListBox();
            this.labelAssociations = new System.Windows.Forms.Label();
            this.jobFairsDataSet = new JobFairs.JobFairsDataSet();
            this.jobFairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairsTableAdapter = new JobFairs.JobFairsDataSetTableAdapters.JobFairsTableAdapter();
            this.jobFairVenuesDataSet = new JobFairs.JobFairVenuesDataSet();
            this.venuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venuesTableAdapter = new JobFairs.JobFairVenuesDataSetTableAdapters.VenuesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairVenuesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(31, 177);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(218, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Venue to Job Fair";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(28, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Where is your job fair?";
            // 
            // cbJobFair
            // 
            this.cbJobFair.DataSource = this.jobFairsBindingSource;
            this.cbJobFair.DisplayMember = "Title";
            this.cbJobFair.FormattingEnabled = true;
            this.cbJobFair.Location = new System.Drawing.Point(128, 86);
            this.cbJobFair.Name = "cbJobFair";
            this.cbJobFair.Size = new System.Drawing.Size(121, 21);
            this.cbJobFair.TabIndex = 2;
            this.cbJobFair.ValueMember = "ID";
            // 
            // labelJobFair
            // 
            this.labelJobFair.AutoSize = true;
            this.labelJobFair.Location = new System.Drawing.Point(28, 89);
            this.labelJobFair.Name = "labelJobFair";
            this.labelJobFair.Size = new System.Drawing.Size(47, 13);
            this.labelJobFair.TabIndex = 3;
            this.labelJobFair.Text = "Job Fair:";
            // 
            // labelVenue
            // 
            this.labelVenue.AutoSize = true;
            this.labelVenue.Location = new System.Drawing.Point(28, 116);
            this.labelVenue.Name = "labelVenue";
            this.labelVenue.Size = new System.Drawing.Size(41, 13);
            this.labelVenue.TabIndex = 4;
            this.labelVenue.Text = "Venue:";
            // 
            // cbVenue
            // 
            this.cbVenue.DataSource = this.venuesBindingSource;
            this.cbVenue.DisplayMember = "Name";
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Location = new System.Drawing.Point(128, 113);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(121, 21);
            this.cbVenue.TabIndex = 5;
            this.cbVenue.ValueMember = "ID";
            // 
            // lbAssociations
            // 
            this.lbAssociations.FormattingEnabled = true;
            this.lbAssociations.Location = new System.Drawing.Point(316, 86);
            this.lbAssociations.Name = "lbAssociations";
            this.lbAssociations.Size = new System.Drawing.Size(222, 238);
            this.lbAssociations.TabIndex = 6;
            // 
            // labelAssociations
            // 
            this.labelAssociations.AutoSize = true;
            this.labelAssociations.Location = new System.Drawing.Point(313, 32);
            this.labelAssociations.Name = "labelAssociations";
            this.labelAssociations.Size = new System.Drawing.Size(66, 13);
            this.labelAssociations.TabIndex = 7;
            this.labelAssociations.Text = "Associations";
            // 
            // jobFairsDataSet
            // 
            this.jobFairsDataSet.DataSetName = "JobFairsDataSet";
            this.jobFairsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobFairsBindingSource
            // 
            this.jobFairsBindingSource.DataMember = "JobFairs";
            this.jobFairsBindingSource.DataSource = this.jobFairsDataSet;
            // 
            // jobFairsTableAdapter
            // 
            this.jobFairsTableAdapter.ClearBeforeFill = true;
            // 
            // jobFairVenuesDataSet
            // 
            this.jobFairVenuesDataSet.DataSetName = "JobFairVenuesDataSet";
            this.jobFairVenuesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venuesBindingSource
            // 
            this.venuesBindingSource.DataMember = "Venues";
            this.venuesBindingSource.DataSource = this.jobFairVenuesDataSet;
            // 
            // venuesTableAdapter
            // 
            this.venuesTableAdapter.ClearBeforeFill = true;
            // 
            // AddJobFairVenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 378);
            this.Controls.Add(this.labelAssociations);
            this.Controls.Add(this.lbAssociations);
            this.Controls.Add(this.cbVenue);
            this.Controls.Add(this.labelVenue);
            this.Controls.Add(this.labelJobFair);
            this.Controls.Add(this.cbJobFair);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddJobFairVenues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Venue to Job Fair";
            this.Load += new System.EventHandler(this.AddJobFairVenues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairVenuesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox cbJobFair;
        private System.Windows.Forms.Label labelJobFair;
        private System.Windows.Forms.Label labelVenue;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.ListBox lbAssociations;
        private System.Windows.Forms.Label labelAssociations;
        private JobFairsDataSet jobFairsDataSet;
        private System.Windows.Forms.BindingSource jobFairsBindingSource;
        private JobFairsDataSetTableAdapters.JobFairsTableAdapter jobFairsTableAdapter;
        private JobFairVenuesDataSet jobFairVenuesDataSet;
        private System.Windows.Forms.BindingSource venuesBindingSource;
        private JobFairVenuesDataSetTableAdapters.VenuesTableAdapter venuesTableAdapter;
    }
}