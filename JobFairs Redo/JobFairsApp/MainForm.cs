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
                List<string> interviewInfo = Database.GetReadableInterviews();

                /*
                try
                {
                    StreamReader streamToPrint = new StreamReader(textFile);
                    try
                    {
                        Font printFont = new Font("Arial", 12);
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler
                           (this.pd_PrintPage);
                        pd.Print();
                    }
                    finally
                    {
                        streamToPrint.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                */
                Printer.PrintInterviews(interviewInfo);

                //string filename = @"C:\Users\Andreya\Documents\InterviewsWord.docx";
                //DocumentModel.Load(filename, LoadOptions.DocxDefault).Print();


            }
        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Arial", 12);

            StreamReader streamToPrint = new StreamReader(@"C:\Users\Andreya\Documents\Interviews.txt");

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            line = streamToPrint.ReadLine();

            // Print each line of the file.
            while (count < linesPerPage && line != null)
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

        }

    }
}
