using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace JobFairsApp
{
    class Printer
    {
        private List<string> interviewInfoCandidate = Database.GetInterviews('c');
        private List<string> interviewInfoInterviewer = Database.GetInterviews('i');
        private List<string> interviewInfoMaster = Database.GetInterviews('m');

        // Fonts used throughout the printing process
        Font headerFont = new Font("Calibri", 16f);
        Font bodyFont = new Font("Calibri", 12f);
        Font littleFont = new Font("Calibri", 10f);

        // Pages and indices for candidates, interviewers, and master
        private int pages = 1;
        private int index = 0;

        SizeF stringSize; // Used for measuring strings throughout

        public void CandidateDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintInterviews(e, interviewInfoCandidate);
        }

        public void InterviewerDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintInterviews(e, interviewInfoInterviewer);
        }

        public void MasterDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintInterviews(e, interviewInfoMaster);
        }

        // Use this to print interviews for each method - to condense the code
        private PrintPageEventArgs PrintInterviews(PrintPageEventArgs e, List<string> interviewInfo)
        {
            Graphics g = e.Graphics;

            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float leftMargin = e.MarginBounds.Left;
            float yPos = topMargin; // Used keeping track of how much of the page we've used

            // Write the page number in a header
            stringSize = g.MeasureString(pages.ToString(), littleFont);
            g.DrawString(pages.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, topMargin - stringSize.Height - 30);
            pages++;

            // Write the date in a footer
            stringSize = g.MeasureString(DateTime.Now.ToString(), littleFont);
            g.DrawString(DateTime.Now.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, bottomMargin + stringSize.Height);

            // Write the header if we're printing the interviewer or candidate pages - Interviews for ...
            if (interviewInfo[index].IndexOf("Interviews for") == 0)
            {
                stringSize = g.MeasureString(interviewInfo[index], headerFont);
                g.DrawString(interviewInfo[index], headerFont, Brushes.DarkCyan, leftMargin, yPos);
                yPos = topMargin + stringSize.Height + 20;
            }
            // Otherwise write the generic header, "Interviews," for the master doc
            else if (pages == 2) // Use 2 because we already incremented mPages above
            {
                stringSize = g.MeasureString("Interviews", headerFont);
                g.DrawString("Interviews", headerFont, Brushes.DarkCyan, leftMargin, yPos);
                yPos = topMargin + stringSize.Height + 20;
            }

            // Write the content
            for (int i = index + 1; i < interviewInfo.Count; i++)
            {
                // Detect page break
                if (interviewInfo[i].IndexOf("Interviews for") == 0 || yPos > bottomMargin)
                {
                    e.HasMorePages = true;
                    index = i;
                    return e;
                }

                // If it's not time for a page break, write this interview info
                stringSize = g.MeasureString(interviewInfo[i], bodyFont);
                g.DrawString(interviewInfo[i], bodyFont, Brushes.Black, leftMargin, yPos);
                yPos += stringSize.Height + 10;
            }

            // If we get to here, reset everything and tell the printer to stop printing
            e.HasMorePages = false;
            index = 0;
            pages = 1;

            return e;
        }
    }
}
