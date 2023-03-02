using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forWrite = null;
            int[] array = new int[10];
            Random rn = new Random();
            Console.WriteLine("Початковий масив має вигляд: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rn.Next(0, 10);
                forWrite += $"Array[{i}] = " + array[i]+"\n";
            }
            WriteFile("z7.rez", forWrite, "Масив записано у файл \"z7.rez\"\n");//Початковий масив
            
            //За зростям 
            forWrite = null;    
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                forWrite += $"Array[{i}] = " + array[i] + "\n";
            }
            WriteFile("z7-z.rez", "Відсортований масив за зростанням:\n" + forWrite, 
                      "Масив записано у файл z7-z.rez\n");

            //За спаданям
            forWrite = null;
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                forWrite += $"Array[{i}] = " + array[i] + "\n";
            }
            WriteFile("z7-s.rez", "Відсортований масив за спаданням:\n" + forWrite, 
                      "Масив записано у файл z7-s.rez\n");
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
