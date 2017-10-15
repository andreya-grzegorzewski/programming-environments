namespace JobFairsApp
{
    partial class formAddPersonSpecialties
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
            this.lbSpecialties = new System.Windows.Forms.ListBox();
            this.labelSpecialties = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.specialtiesDataSet = new JobFairsApp.SpecialtiesDataSet();
            this.specialtiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtiesTableAdapter = new JobFairsApp.SpecialtiesDataSetTableAdapters.SpecialtiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSpecialties
            // 
            this.lbSpecialties.DataSource = this.specialtiesBindingSource;
            this.lbSpecialties.DisplayMember = "Name";
            this.lbSpecialties.FormattingEnabled = true;
            this.lbSpecialties.Location = new System.Drawing.Point(28, 46);
            this.lbSpecialties.Name = "lbSpecialties";
            this.lbSpecialties.Size = new System.Drawing.Size(219, 264);
            this.lbSpecialties.TabIndex = 0;
            this.lbSpecialties.ValueMember = "ID";
            // 
            // labelSpecialties
            // 
            this.labelSpecialties.AutoSize = true;
            this.labelSpecialties.Location = new System.Drawing.Point(28, 27);
            this.labelSpecialties.Name = "labelSpecialties";
            this.labelSpecialties.Size = new System.Drawing.Size(103, 13);
            this.labelSpecialties.TabIndex = 1;
            this.labelSpecialties.Text = "Pick your specialties";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(31, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(172, 355);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // specialtiesDataSet
            // 
            this.specialtiesDataSet.DataSetName = "SpecialtiesDataSet";
            this.specialtiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtiesBindingSource
            // 
            this.specialtiesBindingSource.DataMember = "Specialties";
            this.specialtiesBindingSource.DataSource = this.specialtiesDataSet;
            // 
            // specialtiesTableAdapter
            // 
            this.specialtiesTableAdapter.ClearBeforeFill = true;
            // 
            // formAddPersonSpecialties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 415);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelSpecialties);
            this.Controls.Add(this.lbSpecialties);
            this.Name = "formAddPersonSpecialties";
            this.Text = "formAddPersonSpecialties";
            this.Load += new System.EventHandler(this.formAddPersonSpecialties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSpecialties;
        private System.Windows.Forms.Label labelSpecialties;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDone;
        private SpecialtiesDataSet specialtiesDataSet;
        private System.Windows.Forms.BindingSource specialtiesBindingSource;
        private SpecialtiesDataSetTableAdapters.SpecialtiesTableAdapter specialtiesTableAdapter;
    }
}