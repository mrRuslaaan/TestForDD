using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DLL
{
    public class WordsCounter
    {   
        private Dictionary<string, int> WordsCount(List<string> words, Dictionary<string, int> dict)
        {
            var wordsGroups = from w in words
                              group w by w into g
                              select new { Name = g.Key, Count = g.Count() };

            var wordsOrdered = wordsGroups.
                OrderByDescending(wg => wg.Count)
                .ToList();

            foreach (var group in wordsOrdered)
            {
                dict.Add(group.Name, group.Count);
            }

            return dict;
        }

        public Dictionary<string , int> WordsCountAsync(List<string> words, Dictionary<string, int> dict)
        {
            var wordsGroups = from w in words
                              group w by w into g
                              select new { Name = g.Key, Count = g.Count() };

            var wordsOrdered = wordsGroups.AsParallel().
                OrderByDescending(wg => wg.Count)
                .ToList();

            foreach (var group in wordsOrdered)
            {
                dict.Add(group.Name, group.Count);
            }

            return dict;
        }

    }
}
