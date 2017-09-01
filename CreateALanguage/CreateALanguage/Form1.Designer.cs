namespace CreateALanguage
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
            this.createLanguageButton = new System.Windows.Forms.Button();
            this.languageLB = new System.Windows.Forms.ListBox();
            this.wordLengthCB = new System.Windows.Forms.ComboBox();
            this.wordLengthLabel = new System.Windows.Forms.Label();
            this.wordLengthTB = new System.Windows.Forms.TextBox();
            this.numAsTB = new System.Windows.Forms.TextBox();
            this.numAsLabel = new System.Windows.Forms.Label();
            this.numAsCB = new System.Windows.Forms.ComboBox();
            this.numBsTB = new System.Windows.Forms.TextBox();
            this.numBsLabel = new System.Windows.Forms.Label();
            this.numBsCB = new System.Windows.Forms.ComboBox();
            this.startsWithLabel = new System.Windows.Forms.Label();
            this.endsWithLabel = new System.Windows.Forms.Label();
            this.endsWithCB = new System.Windows.Forms.ComboBox();
            this.startsWithCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createLanguageButton
            // 
            this.createLanguageButton.Location = new System.Drawing.Point(216, 262);
            this.createLanguageButton.Name = "createLanguageButton";
            this.createLanguageButton.Size = new System.Drawing.Size(172, 23);
            this.createLanguageButton.TabIndex = 0;
            this.createLanguageButton.Text = "Create My Language";
            this.createLanguageButton.UseVisualStyleBackColor = true;
            this.createLanguageButton.Click += new System.EventHandler(this.createLanguageButton_Click);
            // 
            // languageLB
            // 
            this.languageLB.FormattingEnabled = true;
            this.languageLB.Location = new System.Drawing.Point(680, 22);
            this.languageLB.Name = "languageLB";
            this.languageLB.Size = new System.Drawing.Size(268, 433);
            this.languageLB.TabIndex = 1;
            // 
            // wordLengthCB
            // 
            this.wordLengthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wordLengthCB.FormattingEnabled = true;
            this.wordLengthCB.Location = new System.Drawing.Point(243, 79);
            this.wordLengthCB.Name = "wordLengthCB";
            this.wordLengthCB.Size = new System.Drawing.Size(121, 21);
            this.wordLengthCB.TabIndex = 2;
            this.wordLengthCB.SelectedIndexChanged += new System.EventHandler(this.wordLengthCB_SelectedIndexChanged);
            // 
            // wordLengthLabel
            // 
            this.wordLengthLabel.AutoSize = true;
            this.wordLengthLabel.Location = new System.Drawing.Point(154, 86);
            this.wordLengthLabel.Name = "wordLengthLabel";
            this.wordLengthLabel.Size = new System.Drawing.Size(72, 13);
            this.wordLengthLabel.TabIndex = 3;
            this.wordLengthLabel.Text = "Word Length:";
            // 
            // wordLengthTB
            // 
            this.wordLengthTB.Location = new System.Drawing.Point(393, 79);
            this.wordLengthTB.Name = "wordLengthTB";
            this.wordLengthTB.Size = new System.Drawing.Size(100, 20);
            this.wordLengthTB.TabIndex = 4;
            // 
            // numAsTB
            // 
            this.numAsTB.Location = new System.Drawing.Point(393, 106);
            this.numAsTB.Name = "numAsTB";
            this.numAsTB.Size = new System.Drawing.Size(100, 20);
            this.numAsTB.TabIndex = 7;
            // 
            // numAsLabel
            // 
            this.numAsLabel.AutoSize = true;
            this.numAsLabel.Location = new System.Drawing.Point(154, 113);
            this.numAsLabel.Name = "numAsLabel";
            this.numAsLabel.Size = new System.Drawing.Size(75, 13);
            this.numAsLabel.TabIndex = 6;
            this.numAsLabel.Text = "Number of a\'s:";
            // 
            // numAsCB
            // 
            this.numAsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numAsCB.FormattingEnabled = true;
            this.numAsCB.Location = new System.Drawing.Point(243, 106);
            this.numAsCB.Name = "numAsCB";
            this.numAsCB.Size = new System.Drawing.Size(121, 21);
            this.numAsCB.TabIndex = 5;
            this.numAsCB.SelectedIndexChanged += new System.EventHandler(this.numAsCB_SelectedIndexChanged);
            // 
            // numBsTB
            // 
            this.numBsTB.Location = new System.Drawing.Point(393, 133);
            this.numBsTB.Name = "numBsTB";
            this.numBsTB.Size = new System.Drawing.Size(100, 20);
            this.numBsTB.TabIndex = 10;
            // 
            // numBsLabel
            // 
            this.numBsLabel.AutoSize = true;
            this.numBsLabel.Location = new System.Drawing.Point(154, 140);
            this.numBsLabel.Name = "numBsLabel";
            this.numBsLabel.Size = new System.Drawing.Size(75, 13);
            this.numBsLabel.TabIndex = 9;
            this.numBsLabel.Text = "Number of b\'s:";
            // 
            // numBsCB
            // 
            this.numBsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numBsCB.FormattingEnabled = true;
            this.numBsCB.Location = new System.Drawing.Point(243, 133);
            this.numBsCB.Name = "numBsCB";
            this.numBsCB.Size = new System.Drawing.Size(121, 21);
            this.numBsCB.TabIndex = 8;
            this.numBsCB.SelectedIndexChanged += new System.EventHandler(this.numBsCB_SelectedIndexChanged);
            // 
            // startsWithLabel
            // 
            this.startsWithLabel.AutoSize = true;
            this.startsWithLabel.Location = new System.Drawing.Point(167, 168);
            this.startsWithLabel.Name = "startsWithLabel";
            this.startsWithLabel.Size = new System.Drawing.Size(62, 13);
            this.startsWithLabel.TabIndex = 12;
            this.startsWithLabel.Text = "Starts With:";
            // 
            // endsWithLabel
            // 
            this.endsWithLabel.AutoSize = true;
            this.endsWithLabel.Location = new System.Drawing.Point(170, 195);
            this.endsWithLabel.Name = "endsWithLabel";
            this.endsWithLabel.Size = new System.Drawing.Size(59, 13);
            this.endsWithLabel.TabIndex = 15;
            this.endsWithLabel.Text = "Ends With:";
            // 
            // endsWithCB
            // 
            this.endsWithCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endsWithCB.FormattingEnabled = true;
            this.endsWithCB.Location = new System.Drawing.Point(243, 187);
            this.endsWithCB.Name = "endsWithCB";
            this.endsWithCB.Size = new System.Drawing.Size(121, 21);
            this.endsWithCB.TabIndex = 17;
            this.endsWithCB.SelectedIndexChanged += new System.EventHandler(this.endsWithCB_SelectedIndexChanged);
            // 
            // startsWithCB
            // 
            this.startsWithCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startsWithCB.FormattingEnabled = true;
            this.startsWithCB.Location = new System.Drawing.Point(243, 160);
            this.startsWithCB.Name = "startsWithCB";
            this.startsWithCB.Size = new System.Drawing.Size(121, 21);
            this.startsWithCB.TabIndex = 18;
            this.startsWithCB.SelectedIndexChanged += new System.EventHandler(this.startsWithCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 478);
            this.Controls.Add(this.startsWithCB);
            this.Controls.Add(this.endsWithCB);
            this.Controls.Add(this.endsWithLabel);
            this.Controls.Add(this.startsWithLabel);
            this.Controls.Add(this.numBsTB);
            this.Controls.Add(this.numBsLabel);
            this.Controls.Add(this.numBsCB);
            this.Controls.Add(this.numAsTB);
            this.Controls.Add(this.numAsLabel);
            this.Controls.Add(this.numAsCB);
            this.Controls.Add(this.wordLengthTB);
            this.Controls.Add(this.wordLengthLabel);
            this.Controls.Add(this.wordLengthCB);
            this.Controls.Add(this.languageLB);
            this.Controls.Add(this.createLanguageButton);
            this.Name = "Form1";
            this.Text = "Create A Language";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLanguageButton;
        private System.Windows.Forms.ListBox languageLB;
        private System.Windows.Forms.ComboBox wordLengthCB;
        private System.Windows.Forms.Label wordLengthLabel;
        private System.Windows.Forms.TextBox wordLengthTB;
        private System.Windows.Forms.TextBox numAsTB;
        private System.Windows.Forms.Label numAsLabel;
        private System.Windows.Forms.ComboBox numAsCB;
        private System.Windows.Forms.TextBox numBsTB;
        private System.Windows.Forms.Label numBsLabel;
        private System.Windows.Forms.ComboBox numBsCB;
        private System.Windows.Forms.Label startsWithLabel;
        private System.Windows.Forms.Label endsWithLabel;
        private System.Windows.Forms.ComboBox endsWithCB;
        private System.Windows.Forms.ComboBox startsWithCB;
    }
}

