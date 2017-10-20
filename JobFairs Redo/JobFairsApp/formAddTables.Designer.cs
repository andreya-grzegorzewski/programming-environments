namespace JobFairsApp
{
    partial class formAddTables
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
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.labelJobFair = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.cbJobFair = new System.Windows.Forms.ComboBox();
            this.jobFairsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFairDataSet = new JobFairsApp.JobFairDataSet();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.checkboxAccessible = new System.Windows.Forms.CheckBox();
            this.checkboxHasPower = new System.Windows.Forms.CheckBox();
            this.jobFairsTableAdapter = new JobFairsApp.JobFairDataSetTableAdapters.JobFairsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(23, 315);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(247, 315);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // labelJobFair
            // 
            this.labelJobFair.AutoSize = true;
            this.labelJobFair.Location = new System.Drawing.Point(23, 47);
            this.labelJobFair.Name = "labelJobFair";
            this.labelJobFair.Size = new System.Drawing.Size(41, 13);
            this.labelJobFair.TabIndex = 2;
            this.labelJobFair.Text = "Job fair";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(23, 72);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Location";
            // 
            // cbJobFair
            // 
            this.cbJobFair.DataSource = this.jobFairsBindingSource;
            this.cbJobFair.DisplayMember = "Title";
            this.cbJobFair.FormattingEnabled = true;
            this.cbJobFair.Location = new System.Drawing.Point(80, 44);
            this.cbJobFair.Name = "cbJobFair";
            this.cbJobFair.Size = new System.Drawing.Size(242, 21);
            this.cbJobFair.TabIndex = 4;
            this.cbJobFair.ValueMember = "ID";
            this.cbJobFair.SelectedIndexChanged += new System.EventHandler(this.cbJobFair_SelectedIndexChanged);
            // 
            // jobFairsBindingSource
            // 
            this.jobFairsBindingSource.DataMember = "JobFairs";
            this.jobFairsBindingSource.DataSource = this.jobFairDataSet;
            // 
            // jobFairDataSet
            // 
            this.jobFairDataSet.DataSetName = "JobFairDataSet";
            this.jobFairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(80, 69);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(242, 21);
            this.cbLocation.TabIndex = 5;
            // 
            // checkboxAccessible
            // 
            this.checkboxAccessible.AutoSize = true;
            this.checkboxAccessible.Location = new System.Drawing.Point(26, 127);
            this.checkboxAccessible.Name = "checkboxAccessible";
            this.checkboxAccessible.Size = new System.Drawing.Size(77, 17);
            this.checkboxAccessible.TabIndex = 6;
            this.checkboxAccessible.Text = "Accessible";
            this.checkboxAccessible.UseVisualStyleBackColor = true;
            // 
            // checkboxHasPower
            // 
            this.checkboxHasPower.AutoSize = true;
            this.checkboxHasPower.Location = new System.Drawing.Point(26, 150);
            this.checkboxHasPower.Name = "checkboxHasPower";
            this.checkboxHasPower.Size = new System.Drawing.Size(77, 17);
            this.checkboxHasPower.TabIndex = 7;
            this.checkboxHasPower.Text = "Has power";
            this.checkboxHasPower.UseVisualStyleBackColor = true;
            // 
            // jobFairsTableAdapter
            // 
            this.jobFairsTableAdapter.ClearBeforeFill = true;
            // 
            // formAddTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 355);
            this.Controls.Add(this.checkboxHasPower);
            this.Controls.Add(this.checkboxAccessible);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.cbJobFair);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelJobFair);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddTable);
            this.Name = "formAddTables";
            this.Text = "Add Tables";
            this.Load += new System.EventHandler(this.formAddTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFairsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFairDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label labelJobFair;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox cbJobFair;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.CheckBox checkboxAccessible;
        private System.Windows.Forms.CheckBox checkboxHasPower;
        private JobFairDataSet jobFairDataSet;
        private System.Windows.Forms.BindingSource jobFairsBindingSource;
        private JobFairDataSetTableAdapters.JobFairsTableAdapter jobFairsTableAdapter;
    }
}