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
    public partial class formAddJobFairVenues : Form
    {
        Table jobFairVenues;
        private int givenJobFairID = -1;
        private string givenJobFairTitle = "";

        public formAddJobFairVenues()
        {
            InitializeComponent();
            SetUpTable();
            FillListBox();
            StartPosition = FormStartPosition.CenterParent;
        }

        public formAddJobFairVenues(int jobFairID, string jobFairTitle)
        {
            InitializeComponent();
            SetUpTable();
            this.givenJobFairID = jobFairID;
            this.givenJobFairTitle = jobFairTitle;
            labelTitle.Text = "Where is " + jobFairTitle + "?";
            cbJobFair.Visible = false;
            labelJobFair.Visible = false;
            FillListBox();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void formAddJobFairVenues_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFairDataSet.JobFairs' table. You can move, or remove it, as needed.
            this.jobFairsTableAdapter.Fill(this.jobFairDataSet.JobFairs);
            // TODO: This line of code loads data into the 'venuesDataSet.Venues' table. You can move, or remove it, as needed.
            this.venuesTableAdapter.Fill(this.venuesDataSet.Venues);
        }

        private void SetUpTable()
        {
            Column jobFairID = new Column("JobFairID");
            Column venueID = new Column("VenueID");
            List<Column> columns = new List<Column>
            {
                jobFairID,
                venueID
            };

            jobFairVenues = new Table("JobFairVenues", columns);
        }

        private void FillListBox()
        {
            lbAssociations.Items.Clear();

            string command = "SELECT j.Title, v.Name " +
                "FROM JobFairVenues AS jv " +
                "INNER JOIN JobFairs AS j " +
                "ON j.ID = jv.JobFairID " +
                "INNER JOIN Venues AS v " +
                "ON v.ID = jv.VenueID";

            if (givenJobFairID != -1)
                command += " WHERE jv.JobFairID = " + givenJobFairID;
            command += ";";

            int columns = 2;
            List<string> data = Table.Read(command, columns);

            string thisTitle = "";
            string thisVenue = "";

            for (int i = 0; i < data.Count; i+=columns)
            {
                thisTitle = data[i];
                thisVenue = data[i + 1];

                lbAssociations.Items.Add(thisTitle + " will be at " + thisVenue);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string selectedJobFair;
            if (givenJobFairID == -1)
                selectedJobFair = cbJobFair.Text;
            else
                selectedJobFair = givenJobFairTitle;
            string selectedVenue = cbVenue.Text;
            string association;
            for (int i = 0; i < lbAssociations.Items.Count; i++)
            {
                association = lbAssociations.Items[i].ToString();
                if (association == selectedJobFair + " will be at " + selectedVenue)
                {
                    MessageBox.Show("You can't add that association because it already exists.", "Hold on!");
                    return;
                }
                    
            }

            if (givenJobFairID != -1)
                jobFairVenues.Columns[0].CurrentValue = givenJobFairID.ToString();
            else
                jobFairVenues.Columns[0].CurrentValue = cbJobFair.SelectedValue.ToString();
            jobFairVenues.Columns[1].CurrentValue = cbVenue.SelectedValue.ToString();

            jobFairVenues.InsertRow();

            FillListBox();
        }
    }
}
