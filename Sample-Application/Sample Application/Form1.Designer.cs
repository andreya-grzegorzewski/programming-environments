namespace Sample_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbID = new System.Windows.Forms.TextBox();
            this.m_tbName = new System.Windows.Forms.TextBox();
            this.m_btnGetName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // m_tbID
            // 
            this.m_tbID.Location = new System.Drawing.Point(136, 84);
            this.m_tbID.Name = "m_tbID";
            this.m_tbID.Size = new System.Drawing.Size(100, 20);
            this.m_tbID.TabIndex = 2;
            // 
            // m_tbName
            // 
            this.m_tbName.Location = new System.Drawing.Point(136, 125);
            this.m_tbName.Name = "m_tbName";
            this.m_tbName.Size = new System.Drawing.Size(100, 20);
            this.m_tbName.TabIndex = 2;
            // 
            // m_btnGetName
            // 
            this.m_btnGetName.Location = new System.Drawing.Point(284, 92);
            this.m_btnGetName.Name = "m_btnGetName";
            this.m_btnGetName.Size = new System.Drawing.Size(85, 49);
            this.m_btnGetName.TabIndex = 3;
            this.m_btnGetName.Text = "Get Name from Name ID";
            this.m_btnGetName.UseVisualStyleBackColor = true;
            this.m_btnGetName.Click += new System.EventHandler(this.m_btnGetName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 507);
            this.Controls.Add(this.m_btnGetName);
            this.Controls.Add(this.m_tbName);
            this.Controls.Add(this.m_tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbID;
        private System.Windows.Forms.TextBox m_tbName;
        private System.Windows.Forms.Button m_btnGetName;
    }
}

