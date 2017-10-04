namespace JobFairs
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
            this.buttonAddVenue = new System.Windows.Forms.Button();
            this.tbLongDesc = new System.Windows.Forms.TextBox();
            this.tbShortDesc = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelLongDesc = new System.Windows.Forms.Label();
            this.labelShortDesc = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddVenue
            // 
            this.buttonAddVenue.Location = new System.Drawing.Point(206, 150);
            this.buttonAddVenue.Name = "buttonAddVenue";
            this.buttonAddVenue.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVenue.TabIndex = 30;
            this.buttonAddVenue.Text = "Add Venue";
            this.buttonAddVenue.UseVisualStyleBackColor = true;
            this.buttonAddVenue.Click += new System.EventHandler(this.buttonAddVenue_Click);
            // 
            // tbLongDesc
            // 
            this.tbLongDesc.Location = new System.Drawing.Point(139, 95);
            this.tbLongDesc.Name = "tbLongDesc";
            this.tbLongDesc.Size = new System.Drawing.Size(100, 20);
            this.tbLongDesc.TabIndex = 29;
            // 
            // tbShortDesc
            // 
            this.tbShortDesc.Location = new System.Drawing.Point(139, 71);
            this.tbShortDesc.Name = "tbShortDesc";
            this.tbShortDesc.Size = new System.Drawing.Size(100, 20);
            this.tbShortDesc.TabIndex = 28;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 27;
            // 
            // labelLongDesc
            // 
            this.labelLongDesc.AutoSize = true;
            this.labelLongDesc.Location = new System.Drawing.Point(32, 98);
            this.labelLongDesc.Name = "labelLongDesc";
            this.labelLongDesc.Size = new System.Drawing.Size(87, 13);
            this.labelLongDesc.TabIndex = 25;
            this.labelLongDesc.Text = "Long Description";
            // 
            // labelShortDesc
            // 
            this.labelShortDesc.AutoSize = true;
            this.labelShortDesc.Location = new System.Drawing.Point(32, 74);
            this.labelShortDesc.Name = "labelShortDesc";
            this.labelShortDesc.Size = new System.Drawing.Size(88, 13);
            this.labelShortDesc.TabIndex = 24;
            this.labelShortDesc.Text = "Short Description";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // formAddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 205);
            this.Controls.Add(this.buttonAddVenue);
            this.Controls.Add(this.tbLongDesc);
            this.Controls.Add(this.tbShortDesc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelLongDesc);
            this.Controls.Add(this.labelShortDesc);
            this.Controls.Add(this.labelName);
            this.Name = "formAddVenue";
            this.Text = "Add Venue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddVenue;
        private System.Windows.Forms.TextBox tbLongDesc;
        private System.Windows.Forms.TextBox tbShortDesc;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelLongDesc;
        private System.Windows.Forms.Label labelShortDesc;
        private System.Windows.Forms.Label labelName;
    }
}