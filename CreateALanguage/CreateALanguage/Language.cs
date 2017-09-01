using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateALanguage
{
    // A language over an alphabet is a set of strings over an alphabet.
    // This class is a representation of a language defined by user inputs over the alphabet {a, b}.
    public class Language
    {
        const int MAX_LENGTH = 20;
        const int MIN_LENGTH = 0;
        const int MAX_WORDS = 20;
        Random rnd = new Random();

        char[] alphabet = new char[] { 'a', 'b' }; // An alphabet is a finite set of fundamental units
        List<string> words = new List<string>();

        private List<int> wordLength = new List<int>();
        private List<int> numAs = new List<int>();
        private List<int> numBs = new List<int>();
        private char startChar = ' ';
        private char endChar = ' ';
        // private char[] thisWord;
        // private bool goodParams = true;
        private int numRepeats = 0;

        // Fix constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wordLengthStr"></param>
        /// <param name="numAsStr"></param>
        /// <param name="numBsStr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public Language(string wordLengthStr, string numAsStr, string numBsStr, char start, char end)
        {
            setNumbers(wordLengthStr, "wordLength");
            setNumbers(numAsStr, "numAs");
            setNumbers(numBsStr, "numBs");
            startChar = start;
            endChar = end;

            // Check params; pick lengths; go
            for (int i = wordLength.Last(); i <= MAX_LENGTH; i++)
            {
                numAs.Remove(i);
                numBs.Remove(i);
            }

            if (start == 'a' || end == 'a')
            {
                if (start == 'a' && end == 'a')
                    numAs.Remove(1);
                numAs.Remove(0);
            }

            if (start == 'b' || end == 'b')
            {
                if (start == 'b' && end == 'b')
                    numBs.Remove(1);
                numBs.Remove(0);
            }

            int word;
            int a;
            int b;
            while(true)
            {
                word = wordLength.ElementAt(rnd.Next(wordLength.Count));
                a = numAs.ElementAt(rnd.Next(numAs.Count));
                b = word - a;
                if (numBs.Contains(b))
                    break;
            }

            numAs.Clear();
            numAs.Add(a);
            numBs.Clear();
            numBs.Add(b);
            wordLength.Clear();
            wordLength.Add(word);

            for (int i = 0; i < MAX_WORDS; i++)
            {
                if (numRepeats >= 5)
                    break;
                else
                {
                    addWord();
                }
            }
        }

        private void addWord()
        {
            int totalNumAs = numAs[0];
            int totalNumBs = numBs[0];
            int aCount = 0;
            int bCount = 0;

            char[] word = new char[totalNumAs + totalNumBs];
            int startIndex = 0;
            int endIndex = word.Length;

            if (alphabet.Contains(startChar))
            {
                word[0] = startChar;

                if (startChar == 'a')
                    aCount++;
                else
                    bCount++;

                startIndex++;
            }

            if (alphabet.Contains(endChar))
            {
                word[word.Length - 1] = endChar;

                if (endChar == 'a')
                    aCount++;
                else
                    bCount++;

                endIndex--;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                if (aCount == totalNumAs)
                {
                    word[i] = 'b';
                    bCount++;
                }
                else if (bCount == totalNumBs)
                {
                    word[i] = 'a';
                    aCount++;
                }
                else
                {
                    word[i] = alphabet[rnd.Next(2)];
                    
                    if (word[i] == 'a')
                        aCount++;
                    else
                        bCount++;
                }
            }

            if (!words.Contains(word.ToString()))
                words.Add(new String(word));
            else
                numRepeats++;

            Console.WriteLine(word);
        }        

        private void setNumbers(string info, string variable)
        {
            List<int> numbers;
            if (variable == "numAs")
                numbers = numAs;
            else if (variable == "numBs")
                numbers = numBs;
            else
                numbers = wordLength;

            string description = info.Substring(0, info.LastIndexOf(" "));
            int number = Int32.Parse(info.Substring(info.LastIndexOf(" ") + 1));

            if (description == "exactly")
                numbers.Add(number);
            else if (description == "at least")
            {
                for (int i = 0; i < MAX_LENGTH - number; i++)
                    numbers.Add(i + number);
            }
            else if (description == "at most")
            {
                for (int i = 0; i <= number; i++)
                    numbers.Add(i);
            }
            else if (description == "even")
            {
                for (int i = 0; i < MAX_LENGTH; i += 2)
                    numbers.Add(number + i);
            }
            else if (description == "odd")
            {
                for (int i = 0; i < MAX_LENGTH; i += 2)
                    numbers.Add(number + i);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> getLanguage()
        {
            return words;
        }
    }
}
