using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double a = 2.3 , b = -4;
            double vuraz = 25.3 - a * b / 87 - 32;
            Console.WriteLine($"Значення виразу 25.3 - a * b / 87 - 32," +
                              $" \nпри a = {a}, b = {b} дорівнює {vuraz}");
            Console.ReadLine();
        }
    }
}
