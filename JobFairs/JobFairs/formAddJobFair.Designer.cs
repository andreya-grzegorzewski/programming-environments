namespace JobFairs
{
    partial class formAddJobFair
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonAddJobFair = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbContact = new System.Windows.Forms.ComboBox();
            this.jobFairPeopleDataSet = new JobFairs.JobFairPeopleDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new JobFairs.JobFairPeopleDataSetTableAdapters.PeopleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairPeopleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(44, 100);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(44, 125);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Description";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(44, 150);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(55, 13);
            this.labelStartDate.TabIndex = 2;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(44, 175);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(52, 13);
            this.labelEndDate.TabIndex = 3;
            this.labelEndDate.Text = "End Date";
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(44, 200);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(46, 13);
            this.labelWebsite.TabIndex = 4;
            this.labelWebsite.Text = "Website";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(44, 225);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(44, 250);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(80, 13);
            this.labelContact.TabIndex = 6;
            this.labelContact.Text = "Contact Person";
            // 
            // buttonAddJobFair
            // 
            this.buttonAddJobFair.Location = new System.Drawing.Point(273, 427);
            this.buttonAddJobFair.Name = "buttonAddJobFair";
            this.buttonAddJobFair.Size = new System.Drawing.Size(75, 23);
            this.buttonAddJobFair.TabIndex = 7;
            this.buttonAddJobFair.Text = "Add Job Fair";
            this.buttonAddJobFair.UseVisualStyleBackColor = true;
            this.buttonAddJobFair.Click += new System.EventHandler(this.buttonAddJobFair_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(132, 97);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(121, 20);
            this.tbTitle.TabIndex = 8;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(132, 122);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(121, 20);
            this.tbDesc.TabIndex = 9;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(132, 147);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(121, 20);
            this.tbStartDate.TabIndex = 10;
            this.tbStartDate.Text = "YYYY-MM-DD";
            this.tbStartDate.Enter += new System.EventHandler(this.tbStartDate_Enter);
            this.tbStartDate.Leave += new System.EventHandler(this.tbStartDate_Leave);
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(132, 172);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(121, 20);
            this.tbEndDate.TabIndex = 11;
            this.tbEndDate.Text = "YYYY-MM-DD";
            this.tbEndDate.Enter += new System.EventHandler(this.tbEndDate_Enter);
            this.tbEndDate.Leave += new System.EventHandler(this.tbEndDate_Leave);
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(132, 197);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(121, 20);
            this.tbWebsite.TabIndex = 12;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(132, 222);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(121, 20);
            this.tbPhone.TabIndex = 13;
            // 
            // cbContact
            // 
            this.cbContact.DataSource = this.peopleBindingSource;
            this.cbContact.DisplayMember = "First";
            this.cbContact.FormattingEnabled = true;
            this.cbContact.Location = new System.Drawing.Point(132, 247);
            this.cbContact.Name = "cbContact";
            this.cbContact.Size = new System.Drawing.Size(121, 21);
            this.cbContact.TabIndex = 14;
            // 
            // jobFairPeopleDataSet
            // 
            this.jobFairPeopleDataSet.DataSetName = "JobFairPeopleDataSet";
            this.jobFairPeopleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.jobFairPeopleDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // formAddJobFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 500);
            this.Controls.Add(this.cbContact);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbWebsite);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.buttonAddJobFair);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelTitle);
            this.Name = "formAddJobFair";
            this.Text = "Add Job Fair";
            this.Load += new System.EventHandler(this.formAddJobFair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairPeopleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button buttonAddJobFair;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbContact;
        private JobFairPeopleDataSet jobFairPeopleDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private JobFairPeopleDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
    }
}