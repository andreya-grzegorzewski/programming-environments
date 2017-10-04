using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobFairs
{
    public partial class formAddJobFairVenues : Form
    {
        public formAddJobFairVenues()
        {
            InitializeComponent();
            FillListBox();
        }

        // Start by assuming we aren't working with a specific job fair
        // And no venue is selected
        private int jobFairID = -1;
        private string jobFairTitle = "";
        private int venueID = -1;
        private bool specificJobFair = false;

        // Set the current job fair to the one just entered into the DB
        public void SpecifyJobFair(JobFair j)
        {
            // Only allow associations for the current job fair
            cbJobFair.Visible = false;
            labelJobFair.Visible = false;
            labelTitle.Text = "Where is " + j.Title.Replace("''", "'") + "?";

            // Update variables to reflect the current job fair
            jobFairTitle = j.Title.Replace("''", "'");
            jobFairID = j.ID;
            specificJobFair = true;

            // Remove any associations that aren't for this job fair
            for (int i = 0; i < lbAssociations.Items.Count; i++)
            {
                if (!lbAssociations.Items[i].ToString().Contains(jobFairTitle))
                {
                    lbAssociations.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void AddJobFairVenues_Load(object sender, EventArgs e)
        {
            this.venuesTableAdapter.Fill(this.jobFairVenuesDataSet.Venues);
            this.jobFairsTableAdapter.Fill(this.jobFairsDataSet.JobFairs);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Get the select job fair and venue
            DataRow jobFair = ((DataRowView)cbJobFair.SelectedItem).Row;
            DataRow venue = ((DataRowView)cbVenue.SelectedItem).Row;

            // If we don't know which job fair we're working with, get the ID
            if (!specificJobFair)
            {
                jobFairID = int.Parse(jobFair["ID"].ToString());
            }

            // Get the venue ID
            venueID = int.Parse(venue["ID"].ToString());

            // Connect to the DB
            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            // Create insert statement and set command data
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO JobFairVenues " +
                "(JobFairID, VenueID) VALUES ('" +
                jobFairID + "', '" +
                venueID + "')";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            // Try to add the association
            if (cmd.ExecuteNonQuery() != 1)
                MessageBox.Show(this, "The venue could not be added to the job fair.", "Error");

            // Close the DB connection and update the list box
            sc.Close();
            lbAssociations.Items.Clear();
            FillListBox();
        }

        // Show the user all venue-job fair associations that already exist
        private void FillListBox()
        {
            // Connect to the DB
            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            // Select job fair title/venue name pairs
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT j.Title, v.Name " +
                "FROM JobFairVenues AS jv " +
                "INNER JOIN JobFairs AS j " +
                "ON j.ID = jv.JobFairID " +
                "INNER JOIN Venues AS v " +
                "ON v.ID = jv.VenueID;";

            // Set command data
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            // The current job fair title and venue name
            string thisTitle;
            string thisName;

            // Iterate through title/name pairs
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    thisTitle = reader.GetString(0);
                    thisName = reader.GetString(1);

                    // If the pair should be shown, show it
                    if (!specificJobFair || thisTitle == jobFairTitle)
                        lbAssociations.Items.Add(thisTitle + " will be at " + thisName);
                }
            }
            sc.Close();
        }
    }
}
