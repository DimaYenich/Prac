using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зчитується файл z4.dat");
            StreamReader sr = new StreamReader("z4.dat");
            string textInFile = sr.ReadToEnd();

            Console.Write("Введіть сполучення для пошуку: ");
            string spol = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < textInFile.Length - 1; i++)
            {
                if (textInFile.ToLower().Substring(i, 2) == spol.ToLower())
                {
                    count++;
                }
            }
            Console.WriteLine($"Вміст файлу: \"{textInFile}\"");

            Console.WriteLine($"Кількість сполучень \"{spol}\" у файлі: {count}");
            StreamWriter sw = new StreamWriter("z4-1.rez");
            sw.WriteLine($"Кількість сполучень \"{spol}\" у файлі z4.dat: {count}");
            sw.Close();
            Console.ReadLine();
        }
    }
}
