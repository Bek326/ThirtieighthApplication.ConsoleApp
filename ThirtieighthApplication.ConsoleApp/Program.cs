using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ThirtieighthApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = @"C:\Users\bekManOfSteal\Downloads\Text1.txt";
            
            var lines = File.ReadAllText(str);

            var noPunctuationText = new string(lines.Where(c => !char.IsPunctuation(c)).ToArray());

            var words = noPunctuationText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 0);
                }
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
