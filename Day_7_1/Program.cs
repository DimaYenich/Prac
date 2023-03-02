using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("z7.dat");
            string allLines = sr.ReadToEnd();
            Console.WriteLine("Зчитаний текст з файлу: " + $"\"{allLines}\"");
            sr.Close();
            string symbols = null;
            string forWrite = null;
            for (int i = 1; i < allLines.Length; i++)
            {
                if (i%3==0)
                {
                    symbols += allLines[i-1];
                }
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                forWrite += symbols[i]+" ";
            }
            //Console.WriteLine("Кожен третій символ з файлу\"z7.dat\" :" + forWrite);
            WriteFile("z7-1.rez", "Кожен третій символ з файлу\"z7.dat\" : " + forWrite,
                      "Символи збережено у файл z7-1.rez");

            Console.Write("Введіть символ який хочете підрахувати: ");
            int count = 0;
            char countSymbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == countSymbol)
                    count++;
            }
            WriteFile("z7-2.rez", $"Кількість символів \"{countSymbol}\": " + count,
                      "Кількість збережно у файл z7-2.rez");
            //Console.WriteLine($"Кількість символів \"{countSymbol}\": " + count);
            Console.ReadLine();
        }
        static void WriteFile(string fileName, string fileText, string povidom)
        {
            Console.WriteLine(fileText);
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(fileText);
            sw.Close();
            Console.WriteLine(povidom);
        }
    }
}
