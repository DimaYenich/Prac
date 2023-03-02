using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[2, 5];
            int maxEl = 0;
            int minEl = 0;
            string textForWrite = null;
            Random rn = new Random();
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = rn.Next(0, 1000);
                    textForWrite += Array[i, j] + "\t";
                    if(i == 0 && j == 0)
                    {
                        minEl = Array[i, j];
                    }
                    if (Array[i, j] < minEl)
                        minEl = Array[i, j];
                    if (Array[i, j] > maxEl)
                        maxEl = Array[i, j];
                }
                textForWrite += "\n";
                Console.WriteLine();
            }
            Console.Write(textForWrite);
            WriteFile("z6-2.dat", textForWrite, "Масив записано у файл z6-2.dat");
            textForWrite = $"\nНайбільший елемент в масиві: {maxEl}" + 
                           $"\nНаймеший елемент в масиві: {minEl}";
            Console.WriteLine(textForWrite);
            WriteFile("z6-2.rez", textForWrite, "Дані про найбільший та найменший елемент" +
                                                " в масиві записано у файл z6-2.rez");
            Console.ReadLine();
        }
        static void WriteFile(string fileName, string fileText, string povidom)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(fileText);
            sw.Close();
            Console.WriteLine(povidom);
        }
    }
}
