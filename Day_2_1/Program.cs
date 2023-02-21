using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть першу текстову велечину: ");
            string first = Console.ReadLine();
            
            Console.Write("\nВведіть першу текстову велечину: ");
            string second = Console.ReadLine();

            string resoult = first + " " + second;

            Console.WriteLine("\nТретя величина яка вкладає в себе дві" +
                              " \nпопередні має такий вигляд: " + resoult);
            Console.ReadLine();
        }
    }
}
