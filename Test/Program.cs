using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Test.DLL;
using System.Reflection;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string readPath = @"C:\Users\annae\Desktop\TestTask\Test\Test\Война и мир Том 1.txt";
            string writePath = @"C:\Users\annae\Desktop\Война и мир Том 1 количество уникальных слов.txt";

            StreamReader sr = new StreamReader(readPath);

            while (!sr.EndOfStream)
            {
                char[] separators = new char[] { ' ', ',', '!', '-', '\t', '\n', '?', '.', ':', '/', '|', '[', ']'};
                string[] textMass = sr.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var w in textMass)
                {
                    words.Add(w.ToLower());
                }
            }
            sr.Close();

            WordsCounter wc = new WordsCounter();

            Type myType = wc.GetType();

            var method = myType.GetMethod("WordsCount", BindingFlags.NonPublic | BindingFlags.Instance);

            method.Invoke(wc, new object[] { words, dict });


            using (var writer = new StreamWriter(writePath))
            {
                foreach (var kvp in dict)
                {
                    writer.WriteLine($"{kvp.Key}\t{kvp.Value}");
                }
            }
        }
    }
}
