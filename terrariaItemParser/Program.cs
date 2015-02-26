using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrariaItemParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("C:\\Android\\projects\\TerrariaItemParser\\ItemIDs.txt");
            for (int i = 1; i < lines.Length + 1; i++)
            {
                string s = lines[i - 1];
                s = "" + i + "|" + s;
                lines[i - 1] = s;
                Console.WriteLine(s);
            }
            System.IO.File.WriteAllLines("C:\\Android\\projects\\TerrariaItemParser\\NewItemIDs.txt", lines);
        }
    }
}
