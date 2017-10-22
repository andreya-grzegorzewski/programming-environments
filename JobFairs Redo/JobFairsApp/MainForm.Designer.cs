namespace JobFairsApp
{
    partial class MainForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelAddData = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonAddVenue = new System.Windows.Forms.Button();
            this.buttonAddJobFair = new System.Windows.Forms.Button();
            this.buttonAssociateVenueWithJobFair = new System.Windows.Forms.Button();
            this.buttonAddCompany = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.buttonAssociatePersonWithJobFair = new System.Windows.Forms.Button();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.buttonGenerateInterviews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(101, 33);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(413, 24);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to your Job Fair Management System!";
            // 
            // labelAddData
            // 
            this.labelAddData.AutoSize = true;
            this.labelAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddData.Location = new System.Drawing.Point(41, 78);
            this.labelAddData.Name = "labelAddData";
            this.labelAddData.Size = new System.Drawing.Size(66, 16);
            this.labelAddData.TabIndex = 1;
            this.labelAddData.Text = "Add data:";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(69, 111);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(166, 23);
            this.buttonAddPerson.TabIndex = 2;
            this.buttonAddPerson.Text = "Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // buttonAddVenue
            // 
            this.buttonAddVenue.Location = new System.Drawing.Point(69, 140);
            this.buttonAddVenue.Name = "buttonAddVenue";
            this.buttonAddVenue.Size = new System.Drawing.Size(166, 23);
            this.buttonAddVenue.TabIndex = 3;
            this.buttonAddVenue.Text = "Venue";
            this.buttonAddVenue.UseVisualStyleBackColor = true;
            this.buttonAddVenue.Click += new System.EventHandler(this.buttonAddVenue_Click);
            // 
            // buttonAddJobFair
            // 
            this.buttonAddJobFair.Location = new System.Drawing.Point(69, 169);
            this.buttonAddJobFair.Name = "buttonAddJobFair";
            this.buttonAddJobFair.Size = new System.Drawing.Size(166, 23);
            this.buttonAddJobFair.TabIndex = 4;
            this.buttonAddJobFair.Text = "Job Fair";
            this.buttonAddJobFair.UseVisualStyleBackColor = true;
            this.buttonAddJobFair.Click += new System.EventHandler(this.buttonAddJobFair_Click);
            // 
            // buttonAssociateVenueWithJobFair
            // 
            this.buttonAssociateVenueWithJobFair.Location = new System.Drawing.Point(69, 198);
            this.buttonAssociateVenueWithJobFair.Name = "buttonAssociateVenueWithJobFair";
            this.buttonAssociateVenueWithJobFair.Size = new System.Drawing.Size(166, 23);
            this.buttonAssociateVenueWithJobFair.TabIndex = 5;
            this.buttonAssociateVenueWithJobFair.Text = "Associate Venue with Job Fair";
            this.buttonAssociateVenueWithJobFair.UseVisualStyleBackColor = true;
            this.buttonAssociateVenueWithJobFair.Click += new System.EventHandler(this.buttonAssociateVenueWithJobFair_Click);
            // 
            // buttonAddCompany
            // 
            this.buttonAddCompany.Location = new System.Drawing.Point(69, 227);
            this.buttonAddCompany.Name = "buttonAddCompany";
            this.buttonAddCompany.Size = new System.Drawing.Size(166, 23);
            this.buttonAddCompany.TabIndex = 6;
            this.buttonAddCompany.Text = "Company";
            this.buttonAddCompany.UseVisualStyleBackColor = true;
            this.buttonAddCompany.Click += new System.EventHandler(this.buttonAddCompany_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(69, 257);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(166, 23);
            this.btnAddLocation.TabIndex = 7;
            this.btnAddLocation.Text = "Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // buttonAssociatePersonWithJobFair
            // 
            this.buttonAssociatePersonWithJobFair.Location = new System.Drawing.Point(69, 286);
            this.buttonAssociatePersonWithJobFair.Name = "buttonAssociatePersonWithJobFair";
            this.buttonAssociatePersonWithJobFair.Size = new System.Drawing.Size(166, 23);
            this.buttonAssociatePersonWithJobFair.TabIndex = 8;
            this.buttonAssociatePersonWithJobFair.Text = "Associate Person with Job Fair";
            this.buttonAssociatePersonWithJobFair.UseVisualStyleBackColor = true;
            this.buttonAssociatePersonWithJobFair.Click += new System.EventHandler(this.buttonAssociatePersonWithJobFair_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(69, 315);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(166, 23);
            this.buttonAddTable.TabIndex = 9;
            this.buttonAddTable.Text = "Table";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonGenerateInterviews
            // 
            this.buttonGenerateInterviews.Location = new System.Drawing.Point(359, 315);
            this.buttonGenerateInterviews.Name = "buttonGenerateInterviews";
            this.buttonGenerateInterviews.Size = new System.Drawing.Size(166, 23);
            this.buttonGenerateInterviews.TabIndex = 10;
            this.buttonGenerateInterviews.Text = "Generate Interviews";
            this.buttonGenerateInterviews.UseVisualStyleBackColor = true;
            this.buttonGenerateInterviews.Click += new System.EventHandler(this.buttonGenerateInterviews_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 365);
            this.Controls.Add(this.buttonGenerateInterviews);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonAssociatePersonWithJobFair);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.buttonAddCompany);
            this.Controls.Add(this.buttonAssociateVenueWithJobFair);
            this.Controls.Add(this.buttonAddJobFair);
            this.Controls.Add(this.buttonAddVenue);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.labelAddData);
            this.Controls.Add(this.labelWelcome);
            this.Name = "MainForm";
            this.Text = "Job Fair Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelAddData;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonAddVenue;
        private System.Windows.Forms.Button buttonAddJobFair;
        private System.Windows.Forms.Button buttonAssociateVenueWithJobFair;
        private System.Windows.Forms.Button buttonAddCompany;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button buttonAssociatePersonWithJobFair;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.Button buttonGenerateInterviews;
    }
}

