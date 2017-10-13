namespace JobFairsApp
{
    partial class formAddCompany
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
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.labelEmploymentTypes = new System.Windows.Forms.Label();
            this.checkboxFullTime = new System.Windows.Forms.CheckBox();
            this.checkboxCoop = new System.Windows.Forms.CheckBox();
            this.checkboxInternship = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(475, 184);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(93, 23);
            this.btnAddCompany.TabIndex = 0;
            this.btnAddCompany.Text = "Add Company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(36, 69);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(54, 13);
            this.labelAddress1.TabIndex = 2;
            this.labelAddress1.Text = "Address 1";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(36, 92);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 3;
            this.labelAddress2.Text = "Address 2";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(36, 115);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(36, 138);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 5;
            this.labelState.Text = "State";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(36, 161);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(24, 13);
            this.labelZip.TabIndex = 6;
            this.labelZip.Text = "ZIP";
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Location = new System.Drawing.Point(36, 184);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(46, 13);
            this.labelWebsite.TabIndex = 7;
            this.labelWebsite.Text = "Website";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbAddress1
            // 
            this.tbAddress1.Location = new System.Drawing.Point(112, 66);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(172, 20);
            this.tbAddress1.TabIndex = 9;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(112, 89);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(172, 20);
            this.tbAddress2.TabIndex = 10;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(112, 112);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(172, 20);
            this.tbCity.TabIndex = 11;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(112, 135);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(172, 20);
            this.tbState.TabIndex = 12;
            this.tbState.Leave += new System.EventHandler(this.tbState_Leave);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(112, 158);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(172, 20);
            this.tbZip.TabIndex = 13;
            this.tbZip.Leave += new System.EventHandler(this.tbZip_Leave);
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(112, 181);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(172, 20);
            this.tbWebsite.TabIndex = 14;
            // 
            // labelEmploymentTypes
            // 
            this.labelEmploymentTypes.AutoSize = true;
            this.labelEmploymentTypes.Location = new System.Drawing.Point(338, 46);
            this.labelEmploymentTypes.Name = "labelEmploymentTypes";
            this.labelEmploymentTypes.Size = new System.Drawing.Size(230, 13);
            this.labelEmploymentTypes.TabIndex = 15;
            this.labelEmploymentTypes.Text = "What types of positions are you looking to hire?";
            // 
            // checkboxFullTime
            // 
            this.checkboxFullTime.AutoSize = true;
            this.checkboxFullTime.Location = new System.Drawing.Point(341, 64);
            this.checkboxFullTime.Name = "checkboxFullTime";
            this.checkboxFullTime.Size = new System.Drawing.Size(64, 17);
            this.checkboxFullTime.TabIndex = 16;
            this.checkboxFullTime.Text = "Full-time";
            this.checkboxFullTime.UseVisualStyleBackColor = true;
            // 
            // checkboxCoop
            // 
            this.checkboxCoop.AutoSize = true;
            this.checkboxCoop.Location = new System.Drawing.Point(341, 85);
            this.checkboxCoop.Name = "checkboxCoop";
            this.checkboxCoop.Size = new System.Drawing.Size(54, 17);
            this.checkboxCoop.TabIndex = 17;
            this.checkboxCoop.Text = "Co-op";
            this.checkboxCoop.UseVisualStyleBackColor = true;
            // 
            // checkboxInternship
            // 
            this.checkboxInternship.AutoSize = true;
            this.checkboxInternship.Location = new System.Drawing.Point(341, 106);
            this.checkboxInternship.Name = "checkboxInternship";
            this.checkboxInternship.Size = new System.Drawing.Size(112, 17);
            this.checkboxInternship.TabIndex = 18;
            this.checkboxInternship.Text = "Summer internship";
            this.checkboxInternship.UseVisualStyleBackColor = true;
            // 
            // formAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 246);
            this.Controls.Add(this.checkboxInternship);
            this.Controls.Add(this.checkboxCoop);
            this.Controls.Add(this.checkboxFullTime);
            this.Controls.Add(this.labelEmploymentTypes);
            this.Controls.Add(this.tbWebsite);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelWebsite);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAddCompany);
            this.Name = "formAddCompany";
            this.Text = "formAddCompany";
            this.Load += new System.EventHandler(this.formAddCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label labelEmploymentTypes;
        private System.Windows.Forms.CheckBox checkboxFullTime;
        private System.Windows.Forms.CheckBox checkboxCoop;
        private System.Windows.Forms.CheckBox checkboxInternship;
    }
}