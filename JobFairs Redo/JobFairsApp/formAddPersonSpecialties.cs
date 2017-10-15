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
    public partial class formAddPersonSpecialties : Form
    {
        Table candidateSpecialties;
        Table interviewerSpecialties;

        public formAddPersonSpecialties(int candidateID, int interviewerID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            candidateSpecialties.Columns[0].CurrentValue = candidateID.ToString();
            interviewerSpecialties.Columns[0].CurrentValue = interviewerID.ToString();

            if (candidateID != -1)
                labelSpecialties.Text = "Select your candidate specialties.";
            else
                labelSpecialties.Text = "Select your interviewer specialties.";
        }

        private void SetUpTable()
        {
            Column candidateID = new Column("CandidateID");
            Column cSpecialtyID = new Column("SpecialtyID");

            List<Column> candidateColumns = new List<Column>
            {
                candidateID,
                cSpecialtyID
            };

            candidateSpecialties = new Table("CandidateSpecialties", candidateColumns);

            Column interviewerID = new Column("InterviewerID");
            Column iSpecialtyID = new Column("SpecialtyID");

            List<Column> interviewerColumns = new List<Column>
            {
                interviewerID,
                iSpecialtyID
            };

            interviewerSpecialties = new Table("InterviewerSpecialties", interviewerColumns);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAddPersonSpecialties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'specialtiesDataSet.Specialties' table. You can move, or remove it, as needed.
            this.specialtiesTableAdapter.Fill(this.specialtiesDataSet.Specialties);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (candidateSpecialties.Columns[0].CurrentValue != "-1")
            {
                candidateSpecialties.Columns[1].CurrentValue = lbSpecialties.SelectedValue.ToString();
                candidateSpecialties.InsertRow();
            }
            else
            {
                interviewerSpecialties.Columns[1].CurrentValue = lbSpecialties.SelectedValue.ToString();
                interviewerSpecialties.InsertRow();
            }
        }
    }
}
