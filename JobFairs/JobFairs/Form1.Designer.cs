namespace JobFairs
{
    partial class Form1
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
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.labelAddData = new System.Windows.Forms.Label();
            this.buttonAddVenue = new System.Windows.Forms.Button();
            this.buttonAddJobFair = new System.Windows.Forms.Button();
            this.buttonAssociateVenueWithJobFair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelWelcome.Location = new System.Drawing.Point(23, 40);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(413, 24);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to your Job Fair Management System!";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(70, 160);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(169, 23);
            this.buttonAddPerson.TabIndex = 1;
            this.buttonAddPerson.Text = "Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // labelAddData
            // 
            this.labelAddData.AutoSize = true;
            this.labelAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAddData.Location = new System.Drawing.Point(42, 131);
            this.labelAddData.Name = "labelAddData";
            this.labelAddData.Size = new System.Drawing.Size(69, 17);
            this.labelAddData.TabIndex = 2;
            this.labelAddData.Text = "Add data:";
            // 
            // buttonAddVenue
            // 
            this.buttonAddVenue.Location = new System.Drawing.Point(70, 189);
            this.buttonAddVenue.Name = "buttonAddVenue";
            this.buttonAddVenue.Size = new System.Drawing.Size(169, 23);
            this.buttonAddVenue.TabIndex = 3;
            this.buttonAddVenue.Text = "Venue";
            this.buttonAddVenue.UseVisualStyleBackColor = true;
            this.buttonAddVenue.Click += new System.EventHandler(this.buttonAddVenue_Click);
            // 
            // buttonAddJobFair
            // 
            this.buttonAddJobFair.Location = new System.Drawing.Point(70, 218);
            this.buttonAddJobFair.Name = "buttonAddJobFair";
            this.buttonAddJobFair.Size = new System.Drawing.Size(169, 23);
            this.buttonAddJobFair.TabIndex = 4;
            this.buttonAddJobFair.Text = "Job Fair";
            this.buttonAddJobFair.UseVisualStyleBackColor = true;
            this.buttonAddJobFair.Click += new System.EventHandler(this.buttonAddJobFair_Click);
            // 
            // buttonAssociateVenueWithJobFair
            // 
            this.buttonAssociateVenueWithJobFair.Location = new System.Drawing.Point(70, 247);
            this.buttonAssociateVenueWithJobFair.Name = "buttonAssociateVenueWithJobFair";
            this.buttonAssociateVenueWithJobFair.Size = new System.Drawing.Size(169, 23);
            this.buttonAssociateVenueWithJobFair.TabIndex = 5;
            this.buttonAssociateVenueWithJobFair.Text = "Associate Venue with Job Fair";
            this.buttonAssociateVenueWithJobFair.UseVisualStyleBackColor = true;
            this.buttonAssociateVenueWithJobFair.Click += new System.EventHandler(this.buttonAssociateVenueWithJobFair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 550);
            this.Controls.Add(this.buttonAssociateVenueWithJobFair);
            this.Controls.Add(this.buttonAddJobFair);
            this.Controls.Add(this.buttonAddVenue);
            this.Controls.Add(this.labelAddData);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form1";
            this.Text = "Job Fair Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Label labelAddData;
        private System.Windows.Forms.Button buttonAddVenue;
        private System.Windows.Forms.Button buttonAddJobFair;
        private System.Windows.Forms.Button buttonAssociateVenueWithJobFair;
    }
}

