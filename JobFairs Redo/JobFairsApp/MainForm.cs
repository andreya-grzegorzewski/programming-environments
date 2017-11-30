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
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                Printer myPrinter = new Printer();

                // Set up the candidate document
                PrintDocument candidateDoc = new PrintDocument();
                candidateDoc.DocumentName = "Interviews for Candidates";
                candidateDoc.DefaultPageSettings.Landscape = true;
                candidateDoc.PrintPage += myPrinter.CandidateDoc_PrintPage;

                // Set up the interviewer document
                PrintDocument interviewerDoc = new PrintDocument();
                interviewerDoc.DocumentName = "Interviews for Interviewers";
                interviewerDoc.DefaultPageSettings.Landscape = true;
                interviewerDoc.PrintPage += myPrinter.InterviewerDoc_PrintPage;

                // Set up the master document
                PrintDocument masterDoc = new PrintDocument();
                masterDoc.DocumentName = "Interviews - Master";
                masterDoc.DefaultPageSettings.Landscape = true;
                masterDoc.PrintPage += myPrinter.MasterDoc_PrintPage;

                // Show the print previews for each document
                ppd.Document = candidateDoc;
                ppd.ShowDialog();

                ppd.Document = interviewerDoc;
                ppd.ShowDialog();

                ppd.Document = masterDoc;
                ppd.ShowDialog();
                
                // Print the documents - uncomment this when I'm working with an actual printer
                // candidateDoc.Print();
                // interviewerDoc.Print();
                // masterDoc.Print();
            }
        }
    }
}
