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

        // Pages and indices for candidates, interviewers, and master
        private int cPages = 1;
        private int iPages = 1;
        private int mPages = 1;
        private int cIndex = 0;
        private int iIndex = 0;
        private int mIndex = 0;

        public void CandidateDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float leftMargin = e.MarginBounds.Left;
            float yPos = topMargin; // Used keeping track of how much of the page we've used

            Font headerFont = new Font("Calibri", 16f);
            Font bodyFont = new Font("Calibri", 12f);
            Font littleFont = new Font("Calibri", 10f);

            // Write the page number in a header
            SizeF stringSize = g.MeasureString(cPages.ToString(), littleFont);
            g.DrawString(cPages.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, topMargin - stringSize.Height);
            cPages++;

            // Write the date in a footer
            stringSize = g.MeasureString(DateTime.Now.ToString(), littleFont);
            g.DrawString(DateTime.Now.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, bottomMargin + stringSize.Height);

            // Write the header - Interviews for ...
            if (interviewInfoCandidate[cIndex].IndexOf("Interviews for") == 0)
            {
                stringSize = g.MeasureString(interviewInfoCandidate[cIndex], headerFont);
                g.DrawString(interviewInfoCandidate[cIndex], headerFont, Brushes.DarkCyan, leftMargin, yPos);
                yPos = topMargin + stringSize.Height + 20;
            }

            // Write the content
            for (int i = cIndex + 1; i < interviewInfoCandidate.Count; i++)
            {
                // Detect page break
                if (interviewInfoCandidate[i].IndexOf("Interviews for") == 0 || yPos > bottomMargin)
                {
                    e.HasMorePages = true;
                    cIndex = i;
                    return;
                }

                // If it's not time for a page break, write this interview info
                stringSize = g.MeasureString(interviewInfoCandidate[i], bodyFont);
                g.DrawString(interviewInfoCandidate[i], bodyFont, Brushes.Black, leftMargin, yPos);
                yPos += stringSize.Height + 10;
            }

            // If we get to here, reset everything and tell the printer to stop printing
            e.HasMorePages = false;
            cIndex = 0;
            cPages = 1;
        }

        public void InterviewerDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float leftMargin = e.MarginBounds.Left;
            float yPos = topMargin; // Used keeping track of how much of the page we've used

            Font headerFont = new Font("Calibri", 16f);
            Font bodyFont = new Font("Calibri", 12f);
            Font littleFont = new Font("Calibri", 10f);

            // Write the page number in a header
            SizeF stringSize = g.MeasureString(iPages.ToString(), littleFont);
            g.DrawString(iPages.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, topMargin - stringSize.Height);
            iPages++;

            // Write the date in a footer
            stringSize = g.MeasureString(DateTime.Now.ToString(), littleFont);
            g.DrawString(DateTime.Now.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, bottomMargin + stringSize.Height);

            // Write the header - Interviews for ...
            if (interviewInfoInterviewer[iIndex].IndexOf("Interviews for") == 0)
            {
                stringSize = g.MeasureString(interviewInfoInterviewer[iIndex], headerFont);
                g.DrawString(interviewInfoInterviewer[iIndex], headerFont, Brushes.DarkCyan, leftMargin, yPos);
                yPos = topMargin + stringSize.Height + 20;
            }

            // Write the content
            for (int i = iIndex + 1; i < interviewInfoInterviewer.Count; i++)
            {
                // Detect page break
                if (interviewInfoInterviewer[i].IndexOf("Interviews for") == 0 || yPos > bottomMargin)
                {
                    e.HasMorePages = true;
                    iIndex = i;
                    return;
                }

                // If it's not time for a page break, write this interview info
                stringSize = g.MeasureString(interviewInfoInterviewer[i], bodyFont);
                g.DrawString(interviewInfoInterviewer[i], bodyFont, Brushes.Black, leftMargin, yPos);
                yPos += stringSize.Height + 10;
            }

            // If we get to here, reset everything and tell the printer to stop printing
            e.HasMorePages = false;
            iIndex = 0;
            iPages = 1;
        }

        public void MasterDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float leftMargin = e.MarginBounds.Left;
            float yPos = topMargin; // Used keeping track of how much of the page we've used

            Font headerFont = new Font("Calibri", 16f);
            Font bodyFont = new Font("Calibri", 12f);
            Font littleFont = new Font("Calibri", 10f);

            // Write the page number in a header
            SizeF stringSize = g.MeasureString(mPages.ToString(), littleFont);
            g.DrawString(mPages.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, topMargin - stringSize.Height);
            mPages++;

            // Write the date in a footer
            stringSize = g.MeasureString(DateTime.Now.ToString(), littleFont);
            g.DrawString(DateTime.Now.ToString(), littleFont, Brushes.Black, rightMargin - stringSize.Width, bottomMargin + stringSize.Height);

            // Write the header - Interviews
            if (mPages == 2) // Use 2 because we already incremented mPages above
            {
                stringSize = g.MeasureString("Interviews", headerFont);
                g.DrawString("Interviews", headerFont, Brushes.DarkCyan, leftMargin, yPos);
                yPos = topMargin + stringSize.Height + 20;
            }

            // Write the content
            for (int i = mIndex + 1; i < interviewInfoMaster.Count; i++)
            {
                // Detect page break
                if (yPos > bottomMargin)
                {
                    e.HasMorePages = true;
                    mIndex = i;
                    return;
                }

                // If it's not time for a page break, write this interview info
                stringSize = g.MeasureString(interviewInfoMaster[i], bodyFont);
                g.DrawString(interviewInfoMaster[i], bodyFont, Brushes.Black, leftMargin, yPos);
                yPos += stringSize.Height + 10;
            }

            // If we get to here, reset everything and tell the printer to stop printing
            e.HasMorePages = false;
            mIndex = 0;
            mPages = 1;

        }
    }
}
