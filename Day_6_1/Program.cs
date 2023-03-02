using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textForWrite = null;
            int[] Array1D = new int[100];
            int[,] Array2D = new int[10,10];
            Random random = new Random();

            //Заповнення першого масиву
            for (int i = 0; i < Array1D.Length; i++)
            {
                textForWrite += ($"Array[{i}] = ") + (Array1D[i] = random.Next(0, 1000)) + "\n";
            }
            Console.Write(textForWrite);
            WriteFile("z6.dat", textForWrite, "Масив збережено у файл z6.dat!");
            textForWrite = null;

            //Заповнення другого масиву
            for (int i = 0; i < Array2D.GetLength(0); i++)
            {
                for (int j = 0; j < Array2D.GetLength(1); j++)
                {
                    textForWrite += $"[{i},{j}] = " + (Array2D[i, j] = random.Next(0, 1000)) + "\t";
                    //Console.Write($"[{i},{j}] = "+(Array2D[i, j] = random.Next(0, 1000))+"\t");
                }
                textForWrite += "\n";
                Console.WriteLine();
            }
            Console.Write(textForWrite);
            WriteFile("z6-1.dat", textForWrite, "Масив збережено у файл z6 - 1.dat");

            int index = 0;
            int count = 0;
            for (int i = 0; i < Array2D.GetLength(0); i++)
            {
                for (int j = 0; j < Array2D.GetLength(1); j++)
                {
                    if (Array1D[index] == Array2D[i, j])
                        count++;
                    index++;
                }
            }
            Console.WriteLine("Кількість спільних елементів: " + count);
            
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
