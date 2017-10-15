using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairsApp
{
    public partial class formAddCandidate : Form
    {
        Table candidates;
        bool interviewer;

        public formAddCandidate(int personID, bool interviewer)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            candidates.Columns[1].CurrentValue = personID.ToString();
            this.interviewer = interviewer;
        }

        private void formAddCandidate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employmentTypesDataSet.EmploymentTypes' table. You can move, or remove it, as needed.
            this.employmentTypesTableAdapter.Fill(this.employmentTypesDataSet.EmploymentTypes);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            candidates.Columns[2].CurrentValue = cbEmployment.SelectedValue.ToString();
            candidates.Columns[3].CurrentValue = tbYear.Text;
            candidates.InsertRow();
            this.Close();
            formAddPersonSpecialties formS = new formAddPersonSpecialties(Convert.ToInt32(candidates.Columns[0].CurrentValue), -1);
            formS.ShowDialog(this);
            if (interviewer)
            {
                formAddInterviewer form = new formAddInterviewer(Convert.ToInt32(candidates.Columns[1].CurrentValue));
                form.ShowDialog(this);
            }                
        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column personID = new Column("PersonID");
            Column employmentType = new Column("EmploymentType");
            Column year = new Column("Year");

            List<Column> columns = new List<Column>
            {
                id,
                personID,
                employmentType,
                year
            };

            candidates = new Table("Candidates", columns);
        }
    }
}
