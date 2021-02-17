using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

            var wordsGroups = from w in words
                              group w by w into g
                              //orderby words.Count descending не понимаю почему работает некорректно 
                              select new { Name = g.Key, Count = g.Count() };

            var wordsOrdered = wordsGroups.
                OrderByDescending(wg => wg.Count)
                .ToList();

            ///добавил словарь потому что не нашел способ, как можно записать анонимный тип в файл
            foreach (var group in wordsOrdered)
            {
                dict.Add(group.Name, group.Count);
            }

            using (var writer = new StreamWriter(writePath))
            {
                foreach (var kvp in dict)
                {
                    writer.WriteLine($"{kvp.Key}\t{kvp.Value}");
                }
            }

            Console.ReadLine();
        }
    }
}
