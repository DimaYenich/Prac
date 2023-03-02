using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 5];
            int[] arrayForSG = new int[10];
            double sum = 0, serAref = 0;
            string textForWrite = null;

            Random rn = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rn.Next(1, 10);
                    
                    textForWrite += array[i, j]+" ";
                    sum += array[i, j];
                }
                textForWrite += "\n";
            }
            WriteFile("z8.rez", textForWrite, "Масив записано у файл z8.rez\n");
            WriteFile("z8-sum.rez", "Сума всіх елементів: " + sum, "Суму записано у файл z8-sum.rez\n");

            WriteFile("z8-sa.rez","Середнє арефметичне всіх елементів : " + (serAref = sum / array.Length),
                      "Середнє арефметичне записане в файл z8-sa.rez\n");

            WriteFile("z8-sg.rez","Середнє геометричне всіх елементів дорівнює: "
                      + Math.Round(GeometricMean(array),2).ToString(),
                      "Середнє геометричне записано у файл z8-sg.rez\n");
            Console.WriteLine("Необхідні файли створено!");
            
            Console.ReadLine();
        }
        public static double GeometricMean(int[,] nums)
        {
            int product = 1;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    product *= nums[i, j];
                }

            }
            return Math.Pow(product, 1.0 / nums.Length);
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
