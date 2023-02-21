using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть відрізок a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть відрізок b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть відрізок c: ");
            double c = double.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine($"Трикутник зі сторонами a = {a}, b = {b}, c = {c} можливий!");
            }
            else
                Console.WriteLine("Неможливо створити трикутник!");
            Console.ReadLine();
        }
    }
}
