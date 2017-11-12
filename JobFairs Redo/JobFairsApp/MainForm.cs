using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;

namespace JobFairsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            formAddPerson form = new formAddPerson();
            form.ShowDialog(this);
        }

        private void buttonAddJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFair form = new formAddJobFair();
            form.ShowDialog(this);
        }

        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            formAddVenue form = new formAddVenue();
            form.ShowDialog(this);
        }

        private void buttonAssociateVenueWithJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFairVenues form = new formAddJobFairVenues();
            form.ShowDialog(this);
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            formAddCompany form = new formAddCompany();
            form.ShowDialog(this);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            formAddLocation form = new formAddLocation();
            form.ShowDialog(this);
        }

        private void buttonAssociatePersonWithJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFairPerson form = new formAddJobFairPerson();
            form.ShowDialog(this);
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            formAddTables form = new formAddTables();
            form.ShowDialog(this);
        }

        private void buttonGenerateInterviews_Click(object sender, EventArgs e)
        {
            if (!Database.GenerateInterviews())
            {
                MessageBox.Show("Problems!");
            }
        }

        private void buttonPrintInterviews_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == DialogResult.OK)
            {
                List<string> interviewInfo = Database.GetReadableInterviews(); // Used on my laptop

                // Used when I'm in the Lounge and I don't have access to my database
                /*
                List<string> interviewInfo = new List<string>
                {
                    "Interviews for Andreya Candidate",
                    "You will be interviewing with Jerry Interviewer at Google for a Full-time position in Computer Science. Your interview will take place at Table 2 in Kinghorn, from 9:00 to 9:20.",
                    "Interview 2",
                    "Interviews for Some Candidate",
                    "A first interview",
                    "A second interview",
                    "A third interview",
                    "A fourth interview",
                    "Interviews for A Final Candidate",
                    "This is some data",
                    "And here is some more",
                    "And this is the end."
                };
                */

                Printer.PrintInterviews(interviewInfo);
            }
        }
    }
}
