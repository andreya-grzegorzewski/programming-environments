using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateALanguage;
using System.Collections.Generic;

namespace LanguageTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenNumbersTest()
        {
            Language l = new Language("exactly 10", "exactly 4", "exactly 6", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            Console.WriteLine(wordsArray);

            int problems = 0;

            if (words.Count == 0)
                problems++;

            for (int i = 0; i < wordsArray.Length; i++) {
                string word = wordsArray[i];
                if (word.Length == 10) {
                    int aCount = 0;
                    int bCount = 0;
                    for (int j = 0; j < word.Length; j++) {
                        if (word[j] == 'a')
                            aCount++;
                        else if (word[j] == 'b')
                            bCount++;
                    }
                    if (aCount != 4 || bCount != 6)
                        problems++;
                }
                else
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }

        [TestMethod]
        public void EvenTest()
        {
            Language l = new Language("at least 5", "even 4", "at least 0", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            int problems = 0;

            if (words.Count == 0)
                problems++;

            for (int i = 0; i < wordsArray.Length; i++) {
                string word = wordsArray[i];
                
                int aCount = 0;
                for (int j = 0; j < word.Length; j++) {
                    if (word[j] == 'a')
                        aCount++;
                }
                if (aCount % 2 != 0)
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }

        [TestMethod]
        public void OddTest()
        {
            Language l = new Language("at least 5", "exactly 4", "odd 1", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            int problems = 0;

            if (words.Count == 0)
                problems++;

            for (int i = 0; i < wordsArray.Length; i++)
            {
                string word = wordsArray[i];

                int bCount = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'b')
                        bCount++;
                }
                if (bCount % 2 != 1)
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }

        [TestMethod]
        public void AtLeastTest()
        {
            Language l = new Language("at least 5", "at least 4", "at least 6", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            int problems = 0;

            if (words.Count == 0)
                problems++;

            for (int i = 0; i < wordsArray.Length; i++)
            {
                string word = wordsArray[i];
                int aCount = 0;
                int bCount = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'a')
                        aCount++;
                    else if (word[j] == 'b')
                        bCount++;
                }
                if (aCount < 4 || bCount < 6)
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }

        [TestMethod]
        public void AtMostTest()
        {
            Language l = new Language("at least 5", "at most 4", "at most 6", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            int problems = 0;

            if (words.Count == 0)
                problems++;

            for (int i = 0; i < wordsArray.Length; i++)
            {
                string word = wordsArray[i];
                int aCount = 0;
                int bCount = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'a')
                        aCount++;
                    else if (word[j] == 'b')
                        bCount++;
                }
                if (aCount > 4 || bCount > 6)
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }

        [TestMethod]
        public void StartCharTest()
        {
            Language l = new Language("exactly 5", "exactly 3", "exactly 2", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            int problems = 0;

            for (int i = 0; i < wordsArray.Length; i++)
            {
                string word = wordsArray[i];
                if (word.Substring(0, 1) != "a")
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }

        [TestMethod]
        public void EndCharTest()
        {
            Language l = new Language("at least 5", "even 4", "at least 0", 'a', 'b');

            List<string> words = l.getLanguage();
            string[] wordsArray = words.ToArray();

            int problems = 0;

            for (int i = 0; i < wordsArray.Length; i++)
            {
                string word = wordsArray[i];
                if (word[word.Length - 1] != 'b')
                    problems++;
            }

            Assert.IsTrue(problems == 0);
        }
    }
}
