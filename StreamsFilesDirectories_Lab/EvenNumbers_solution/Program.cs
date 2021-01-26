using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenNumbers_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] symbolsToReplace= { '-', ',', '.', '!', '?' };
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
              
                int row = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line==null)
                    {
                        break;
                    }
                    if (row%2==0)
                    {
                        line=Replace(symbolsToReplace, line);
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }
                    row++;
                }
            }
        }

        private static string Reverse(string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = line.Split(' ').ToArray();
            for (int i = words.Length-1;  i >=0  ; i--)
            {
                stringBuilder.Append(words[i]);
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString().TrimEnd();
        }

        private static string Replace(char[] symbolsToReplace, string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (symbolsToReplace.Contains(currentSymbol))
                {
                    stringBuilder.Append('@');
                }else
                {
                    stringBuilder.Append(currentSymbol);
                }
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
