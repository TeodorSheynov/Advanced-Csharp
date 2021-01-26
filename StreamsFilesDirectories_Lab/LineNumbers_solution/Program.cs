using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers_solution
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader=new StreamReader("../../../text.txt"))
            {
                StringBuilder stringBuilder = new StringBuilder();
                int row = 1;
                string line = reader.ReadLine();
                while (line!=null)
                {
                    int symbolCount = 0;
                    int lettersCount = 0;
                    
                    
                    stringBuilder.Append($"Line {row}: ");
                    stringBuilder.Append(line);
                    for (int i = 0; i < line.Length; i++)
                    {
                        char current = line[i];
                        if (char.IsPunctuation(current))
                        {
                            symbolCount++;
                        }
                        else if(char.IsLetter(current))
                        {
                            lettersCount++;
                        }
                    }
                    stringBuilder.Append($" ({lettersCount})/({symbolCount})");
                    stringBuilder.Append(Environment.NewLine);
                    row++;
                    line = reader.ReadLine();

                }
                using StreamWriter writer = new StreamWriter("../../../Outputer.txt");
                {
                    writer.WriteLine(stringBuilder.ToString().TrimEnd());
                }
            }
        }
    }
}
