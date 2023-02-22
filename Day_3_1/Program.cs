using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("t1.dat");
            Console.Write("Введіть текст для файлу: ");
            sw.WriteLine(Console.ReadLine());
            sw.Close();
            Console.WriteLine("Файл успішно створений!");
            Console.ReadKey();
        }
    }
}
