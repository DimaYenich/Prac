using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть імя файлу для зчитування" +
                                     "(t1.dat або t2.dat): ");
            StreamReader sr = new StreamReader(Console.ReadLine());
            Console.WriteLine("Вміст файлу: " + sr.ReadToEnd());
            Console.ReadLine();
        }
    }
}
