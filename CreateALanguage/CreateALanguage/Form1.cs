using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateALanguage
{
    public partial class Form1 : Form
    {
        private string wordLengthStr;
        private string aString;
        private string bString;
        private char start;
        private char end;

        public Form1()
        {
            InitializeComponent();

            wordLengthCB.Items.Add("Exactly");
            wordLengthCB.Items.Add("At most");
            wordLengthCB.Items.Add("At least");
            wordLengthCB.Items.Add("Even");
            wordLengthCB.Items.Add("Odd");
            wordLengthCB.SelectedIndex = 0;

            numAsCB.Items.Add("Exactly");
            numAsCB.Items.Add("At most");
            numAsCB.Items.Add("At least");
            numAsCB.Items.Add("Even");
            numAsCB.Items.Add("Odd");
            numAsCB.SelectedIndex = 0;

            numBsCB.Items.Add("Exactly");
            numBsCB.Items.Add("At most");
            numBsCB.Items.Add("At least");
            numBsCB.Items.Add("Even");
            numBsCB.Items.Add("Odd");
            numBsCB.SelectedIndex = 0;

            startsWithCB.Items.Add(' ');
            startsWithCB.Items.Add('a');
            startsWithCB.Items.Add('b');
            startsWithCB.SelectedIndex = 0;

            endsWithCB.Items.Add(' ');
            endsWithCB.Items.Add('a');
            endsWithCB.Items.Add('b');
            endsWithCB.SelectedIndex = 0;

            wordLengthStr = aString = bString = "exactly ";
            start = end = ' ';
        }

        private void createLanguageButton_Click(object sender, EventArgs e)
        {
            if (wordLengthTB.Text == "" || numAsTB.Text == "" || numBsTB.Text == "")
            {
                MessageBox.Show("Please fill in the text boxes with numbers.");
            }
            else
            {
                languageLB.Items.Clear();

                wordLengthStr += wordLengthTB.Text;
                aString += numAsTB.Text;
                bString += numBsTB.Text;

                Language l = new Language(wordLengthStr, aString, bString, start, end);
                List<string> words = l.getLanguage();

                for (int i = 0; i < words.Count; i++)
                {
                    languageLB.Items.Add(words.ElementAt(i));
                }

                wordLengthStr = wordLengthStr.Substring(0, wordLengthStr.LastIndexOf(" ") + 1);
                aString = aString.Substring(0, aString.LastIndexOf(" ") + 1);
                bString = bString.Substring(0, bString.LastIndexOf(" ") + 1);
            }
        }

        private void wordLengthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordLengthStr = wordLengthCB.SelectedText.ToLower() + " ";
        }

        private void numAsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            aString = numAsCB.SelectedText.ToLower() + " ";
        }

        private void numBsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bString = numBsCB.SelectedText.ToLower() + " ";
        }

        private void startsWithCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            start = (char) startsWithCB.SelectedItem;
        }

        private void endsWithCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            end = (char) endsWithCB.SelectedItem;
        }
    }
}
