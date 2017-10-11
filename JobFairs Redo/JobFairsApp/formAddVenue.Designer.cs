namespace JobFairsApp
{
    partial class formAddVenue
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelShortDesc = new System.Windows.Forms.Label();
            this.labelLongDesc = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbShortDesc = new System.Windows.Forms.TextBox();
            this.tbLongDesc = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.buttonAddVenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelShortDesc
            // 
            this.labelShortDesc.AutoSize = true;
            this.labelShortDesc.Location = new System.Drawing.Point(32, 60);
            this.labelShortDesc.Name = "labelShortDesc";
            this.labelShortDesc.Size = new System.Drawing.Size(88, 13);
            this.labelShortDesc.TabIndex = 1;
            this.labelShortDesc.Text = "Short Description";
            // 
            // labelLongDesc
            // 
            this.labelLongDesc.AutoSize = true;
            this.labelLongDesc.Location = new System.Drawing.Point(32, 84);
            this.labelLongDesc.Name = "labelLongDesc";
            this.labelLongDesc.Size = new System.Drawing.Size(87, 13);
            this.labelLongDesc.TabIndex = 2;
            this.labelLongDesc.Text = "Long Description";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(32, 108);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(51, 13);
            this.labelAddress1.TabIndex = 3;
            this.labelAddress1.Text = "Address1";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(32, 132);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(51, 13);
            this.labelAddress2.TabIndex = 4;
            this.labelAddress2.Text = "Address2";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(32, 156);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(32, 180);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(32, 204);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(24, 13);
            this.labelZip.TabIndex = 7;
            this.labelZip.Text = "ZIP";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(136, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbShortDesc
            // 
            this.tbShortDesc.Location = new System.Drawing.Point(136, 57);
            this.tbShortDesc.Name = "tbShortDesc";
            this.tbShortDesc.Size = new System.Drawing.Size(242, 20);
            this.tbShortDesc.TabIndex = 9;
            // 
            // tbLongDesc
            // 
            this.tbLongDesc.Location = new System.Drawing.Point(136, 81);
            this.tbLongDesc.Name = "tbLongDesc";
            this.tbLongDesc.Size = new System.Drawing.Size(242, 20);
            this.tbLongDesc.TabIndex = 10;
            // 
            // tbAddress1
            // 
            this.tbAddress1.Location = new System.Drawing.Point(136, 105);
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(242, 20);
            this.tbAddress1.TabIndex = 11;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(136, 129);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(242, 20);
            this.tbAddress2.TabIndex = 12;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(136, 153);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(242, 20);
            this.tbCity.TabIndex = 13;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(136, 177);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(242, 20);
            this.tbState.TabIndex = 14;
            this.tbState.Leave += new System.EventHandler(this.tbState_Leave);
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(136, 201);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(242, 20);
            this.tbZip.TabIndex = 15;
            this.tbZip.Leave += new System.EventHandler(this.tbZip_Leave);
            // 
            // buttonAddVenue
            // 
            this.buttonAddVenue.Location = new System.Drawing.Point(360, 256);
            this.buttonAddVenue.Name = "buttonAddVenue";
            this.buttonAddVenue.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVenue.TabIndex = 16;
            this.buttonAddVenue.Text = "Add Venue";
            this.buttonAddVenue.UseVisualStyleBackColor = true;
            this.buttonAddVenue.Click += new System.EventHandler(this.buttonAddVenue_Click);
            // 
            // formAddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 307);
            this.Controls.Add(this.buttonAddVenue);
            this.Controls.Add(this.tbZip);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.tbLongDesc);
            this.Controls.Add(this.tbShortDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelLongDesc);
            this.Controls.Add(this.labelShortDesc);
            this.Controls.Add(this.labelName);
            this.Name = "formAddVenue";
            this.Text = "Add Venue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelShortDesc;
        private System.Windows.Forms.Label labelLongDesc;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbShortDesc;
        private System.Windows.Forms.TextBox tbLongDesc;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Button buttonAddVenue;
    }
}