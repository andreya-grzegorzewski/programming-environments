using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JobFairsApp
{
    // This code borrowed from http://www.c-sharpcorner.com/UploadFile/muralidharan.d/how-to-create-word-document-using-C-Sharp/
    // It provides test code for creating a dummy document.
    // I am learning from it and adapting it to create a real document for interview data.
    class Printer
    {
        //Create document method
        public static void PrintInterviews(List<string> interviewInfo)
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                // Make Word invisible
                winword.Visible = false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "Interviews generated and printed " + DateTime.Now.ToString();
                }

                //Add the footers into the document
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                    footerRange.Fields.Add(footerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                }

                document.Content.SetRange(0, 0);
                
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = interviewInfo[0];
                para1.Range.InsertParagraphAfter();
                
                int start = interviewInfo[0].Length;
                for (int i = 1; i < interviewInfo.Count; i++)
                {
                    document.Content.SetRange(start, start);
                    if (interviewInfo[i].Substring(0, 10) == "Interviews")
                    {
                        document.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
                        Microsoft.Office.Interop.Word.Paragraph heading = document.Content.Paragraphs.Add(ref missing);
                        object headingStyle = "Heading 1";
                        heading.Range.set_Style(ref headingStyle);
                        heading.Range.Text = interviewInfo[i];
                        heading.Range.InsertParagraphAfter();
                    }
                    else
                    {
                        Microsoft.Office.Interop.Word.Paragraph body = document.Content.Paragraphs.Add(ref missing);
                        object bodyStyle = "Normal";
                        body.Range.set_Style(ref bodyStyle);
                        body.Range.Text = interviewInfo[i];
                        body.Range.InsertParagraphAfter();                         
                    }
                    start += interviewInfo[i].Length;
                }
                
                //Save the document
                string filename = @"C:\Users\Andreya\Documents\InterviewsWord.docx";
                document.SaveAs2(filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;

                document.PrintOut();
                File.Delete(filename);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
