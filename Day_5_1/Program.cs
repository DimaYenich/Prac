using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forWrite = null;
            Random random = new Random();
            int[] Array = new int[100];
            int maxElement = 0, minElement = 0, count = 0 ;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(0,1000);
                if(i==0)
                {
                    minElement = Array[i];
                    maxElement = Array[i];
                }
                if (Array[i] > maxElement) 
                {
                    maxElement = Array[i];
                }
                if (Array[i] < minElement) 
                {
                    minElement = Array[i];
                }
                if (Array[i] == 5)
                    count++;
                forWrite += $"\nArray[{i}] = {Array[i]}";
                Console.Write(forWrite);
            }
            StreamWriter sw = new StreamWriter("z5.dat");
            sw.WriteLine(forWrite);
            sw.Close();
            Console.WriteLine($"\nКількість цифр '5' в масиві:{count}"+
                              $"\nНайбільший елемент в масиві: {maxElement}" +
                              $" \nНайменший елемент в масиві: {minElement}" +
                              $"\nСума найбільшого та наймешного елемента: " +
                              $"{maxElement+minElement}");
            Console.ReadLine();
        }
    }
}
