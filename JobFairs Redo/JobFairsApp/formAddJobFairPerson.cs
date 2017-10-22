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
    public partial class formAddJobFairPerson : Form
    {
        Table jobFairPeople;
        int givenPersonID = -1;
        bool candidate;
        bool interviewer;

        public formAddJobFairPerson()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            candidate = false;
            interviewer = false;
        }

        public formAddJobFairPerson(int personID, bool candidate, bool interviewer)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            givenPersonID = personID;
            jobFairPeople.Columns[1].CurrentValue = personID.ToString();
            this.candidate = candidate;
            this.interviewer = interviewer;
            labelPerson.Visible = false;
            lbPerson.Visible = false;
        }

        private void formAddJobFairPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactPersonDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactPersonDataSet.People);
            // TODO: This line of code loads data into the 'jobFairDataSet.JobFairs' table. You can move, or remove it, as needed.
            this.jobFairsTableAdapter.Fill(this.jobFairDataSet.JobFairs);

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
            if (candidate)
            {
                formAddCandidate form = new formAddCandidate(givenPersonID, interviewer);
                form.ShowDialog(this);
            }
            else if (interviewer)
            {
                formAddInterviewer formI = new formAddInterviewer(givenPersonID);
                formI.ShowDialog(this);
            }
        }

        private void SetUpTable()
        {
            Column jobFairID = new Column("JobFairID");
            Column personID = new Column("PersonID");

            List<Column> columns = new List<Column>
            {
                jobFairID,
                personID
            };

            jobFairPeople = new Table("JobFairPeople", columns);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            jobFairPeople.Columns[0].CurrentValue = lbJobFair.SelectedValue.ToString();
            if (givenPersonID == -1)
                jobFairPeople.Columns[1].CurrentValue = lbPerson.SelectedValue.ToString();
            jobFairPeople.InsertRow();
        }
    }
}
