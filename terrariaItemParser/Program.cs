using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaFileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the file you wish to edit:\n" +
                "I)tem IDs\n" +
                "P)refix IDs\n" +
                "A)lphabetize Items\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "I":
                case "i":
                    ParseItems();
                    Console.WriteLine("Parsing complete. Exiting");
                    break;
                case "P":
                case "p":
                    ParsePrefixes();
                    Console.WriteLine("Parsing complete. Exiting");
                    break;
                case "A":
                case "a":
                    AlphabetizeItems();
                    Console.WriteLine("Items alphabetized. Exiting");
                    break;
                default:
                    Console.WriteLine("Invalid input. Exiting");
                    break;
            }
            Console.Read();
        }

        private static void ParseItems()
        {

            string[] lines = System.IO.File.ReadAllLines("C:\\Android\\projects\\TerrariaFileParser\\ItemIDs.txt");
            for (int i = 1; i < lines.Length + 1; i++)
            {
                string s = lines[i - 1];
                s = "" + i + "|" + s;
                lines[i - 1] = s;
                Console.WriteLine(s);
            }
            System.IO.File.WriteAllLines("C:\\Android\\projects\\TerrariaFileParser\\NewItemIDs.txt", lines);
        }

        private static void ParsePrefixes()
        {

            string[] lines = System.IO.File.ReadAllLines("C:\\Android\\projects\\TerrariaFileParser\\PrefixIDs.txt");
            for (int i = 1; i < lines.Length + 1; i++)
            {
                string s = lines[i - 1];
                s = "" + i + "|" + s;
                lines[i - 1] = s;
                Console.WriteLine(s);
            }
            System.IO.File.WriteAllLines("C:\\Android\\projects\\TerrariaFileParser\\NewPrefixIDs.txt", lines);
        }

        private static void AlphabetizeItems()
        {
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\teernisse\\Desktop\\items.txt");
            Array.Sort(lines);
            System.IO.File.WriteAllLines("C:\\Users\\teernisse\\Desktop\\alphabetizedItems.txt", lines);
        }
    }
}
