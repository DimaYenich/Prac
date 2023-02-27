using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_3_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишіть текст для запису:");
            StreamWriter sw = new StreamWriter("t.rez");
            Console.Write("Введіть текст для файлу: ");
            sw.WriteLine(Console.ReadLine());
            sw.Close();
        }
    }
}
