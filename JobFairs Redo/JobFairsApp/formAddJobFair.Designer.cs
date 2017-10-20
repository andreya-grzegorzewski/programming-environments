namespace JobFairsApp
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
            this.labelContactPerson = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbStartDate = new System.Windows.Forms.TextBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbContactPerson = new System.Windows.Forms.ComboBox();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactPersonDataSet = new JobFairsApp.ContactPersonDataSet();
            this.btnAddJobFair = new System.Windows.Forms.Button();
            this.peopleTableAdapter = new JobFairsApp.ContactPersonDataSetTableAdapters.PeopleTableAdapter();
            this.labelIntStart = new System.Windows.Forms.Label();
            this.labelIntEnd = new System.Windows.Forms.Label();
            this.cbIntStart = new System.Windows.Forms.ComboBox();
            this.cbIntEnd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(38, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(38, 64);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Description";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(38, 89);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(55, 13);
            this.labelStartDate.TabIndex = 2;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(38, 114);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(52, 13);
            this.labelEndDate.TabIndex = 3;
            this.labelEndDate.Text = "End Date";
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(38, 139);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(46, 13);
            this.labelWebsite.TabIndex = 4;
            this.labelWebsite.Text = "Website";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(38, 164);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone";
            // 
            // labelContactPerson
            // 
            this.labelContactPerson.AutoSize = true;
            this.labelContactPerson.Location = new System.Drawing.Point(38, 189);
            this.labelContactPerson.Name = "labelContactPerson";
            this.labelContactPerson.Size = new System.Drawing.Size(80, 13);
            this.labelContactPerson.TabIndex = 6;
            this.labelContactPerson.Text = "Contact Person";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(139, 36);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(131, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(139, 61);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(131, 20);
            this.tbDesc.TabIndex = 8;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Location = new System.Drawing.Point(139, 86);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.Size = new System.Drawing.Size(131, 20);
            this.tbStartDate.TabIndex = 9;
            this.tbStartDate.Text = "YYYY-MM-DD";
            this.tbStartDate.Leave += new System.EventHandler(this.tbStartDate_Leave);
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(139, 111);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.Size = new System.Drawing.Size(131, 20);
            this.tbEndDate.TabIndex = 10;
            this.tbEndDate.Text = "YYYY-MM-DD";
            this.tbEndDate.Leave += new System.EventHandler(this.tbEndDate_Leave);
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(139, 136);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(131, 20);
            this.tbWebsite.TabIndex = 11;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(139, 161);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(131, 20);
            this.tbPhone.TabIndex = 12;
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
            // 
            // cbContactPerson
            // 
            this.cbContactPerson.DataSource = this.peopleBindingSource;
            this.cbContactPerson.DisplayMember = "First";
            this.cbContactPerson.FormattingEnabled = true;
            this.cbContactPerson.Location = new System.Drawing.Point(139, 186);
            this.cbContactPerson.Name = "cbContactPerson";
            this.cbContactPerson.Size = new System.Drawing.Size(131, 21);
            this.cbContactPerson.TabIndex = 13;
            this.cbContactPerson.ValueMember = "ID";
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.contactPersonDataSet;
            // 
            // contactPersonDataSet
            // 
            this.contactPersonDataSet.DataSetName = "ContactPersonDataSet";
            this.contactPersonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddJobFair
            // 
            this.btnAddJobFair.Location = new System.Drawing.Point(240, 277);
            this.btnAddJobFair.Name = "btnAddJobFair";
            this.btnAddJobFair.Size = new System.Drawing.Size(75, 23);
            this.btnAddJobFair.TabIndex = 14;
            this.btnAddJobFair.Text = "Add Job Fair";
            this.btnAddJobFair.UseVisualStyleBackColor = true;
            this.btnAddJobFair.Click += new System.EventHandler(this.btnAddJobFair_Click);
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // labelIntStart
            // 
            this.labelIntStart.AutoSize = true;
            this.labelIntStart.Location = new System.Drawing.Point(38, 214);
            this.labelIntStart.Name = "labelIntStart";
            this.labelIntStart.Size = new System.Drawing.Size(101, 13);
            this.labelIntStart.TabIndex = 15;
            this.labelIntStart.Text = "Interview Start Time";
            // 
            // labelIntEnd
            // 
            this.labelIntEnd.AutoSize = true;
            this.labelIntEnd.Location = new System.Drawing.Point(38, 241);
            this.labelIntEnd.Name = "labelIntEnd";
            this.labelIntEnd.Size = new System.Drawing.Size(98, 13);
            this.labelIntEnd.TabIndex = 16;
            this.labelIntEnd.Text = "Interview End Time";
            // 
            // cbIntStart
            // 
            this.cbIntStart.FormattingEnabled = true;
            this.cbIntStart.Location = new System.Drawing.Point(139, 211);
            this.cbIntStart.Name = "cbIntStart";
            this.cbIntStart.Size = new System.Drawing.Size(131, 21);
            this.cbIntStart.TabIndex = 17;
            this.cbIntStart.ValueMember = "ID";
            this.cbIntStart.SelectedIndexChanged += new System.EventHandler(this.cbIntStart_SelectedIndexChanged);
            // 
            // cbIntEnd
            // 
            this.cbIntEnd.FormattingEnabled = true;
            this.cbIntEnd.Location = new System.Drawing.Point(139, 238);
            this.cbIntEnd.Name = "cbIntEnd";
            this.cbIntEnd.Size = new System.Drawing.Size(131, 21);
            this.cbIntEnd.TabIndex = 18;
            this.cbIntEnd.ValueMember = "ID";
            // 
            // formAddJobFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 322);
            this.Controls.Add(this.cbIntEnd);
            this.Controls.Add(this.cbIntStart);
            this.Controls.Add(this.labelIntEnd);
            this.Controls.Add(this.labelIntStart);
            this.Controls.Add(this.btnAddJobFair);
            this.Controls.Add(this.cbContactPerson);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbWebsite);
            this.Controls.Add(this.tbEndDate);
            this.Controls.Add(this.tbStartDate);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.labelContactPerson);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelTitle);
            this.Name = "formAddJobFair";
            this.Text = "Add Job Fair";
            this.Load += new System.EventHandler(this.formAddJobFair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonDataSet)).EndInit();
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
        private System.Windows.Forms.Label labelContactPerson;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbStartDate;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbContactPerson;
        private System.Windows.Forms.Button btnAddJobFair;
        private ContactPersonDataSet contactPersonDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private ContactPersonDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.Label labelIntStart;
        private System.Windows.Forms.Label labelIntEnd;
        private System.Windows.Forms.ComboBox cbIntStart;
        private System.Windows.Forms.ComboBox cbIntEnd;
    }
}