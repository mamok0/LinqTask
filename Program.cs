using System;
using System.Linq;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A BB CC A BB CC CC";
            string[] words = str.Split(' ');
            var wordsCount = words.GroupBy(word => word).Select(word => new { Value = word.Key, Count = word.Count() });

            foreach (var word in wordsCount)
            {
                Console.WriteLine($"{word.Value}: {word.Count}");
            }

            Console.ReadKey();
        }
    }
}
