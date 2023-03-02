using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[11];
            string forWrite = null;
            Random rn = new Random();//30-78
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(rn.Next(30, 78)).ToString();
                forWrite += array[i]+ "\n";
            }
            WriteFile("z8.dat",forWrite, "Масив збережено у файл z8.dat.");

            Console.Write("\nВведіть символ вас цікавить: ");
            char symbol = char.Parse(Console.ReadLine());
            int count = 0;
            string position = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == symbol.ToString())
                {
                    count++;
                    position += i + " ";
                }
                    
            }
            if (count != 0)
                forWrite = ($"Позиції: {position}; кількість {count}");
            else
                forWrite = ("Символ не знайдено!");
            WriteFile("z8.rez", forWrite, "Кількість збережна у файл z8.rez");
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
