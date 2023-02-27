using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перший символ: ");
            char firstSymbol = char.Parse(Console.ReadLine());
            int first = Convert.ToByte(firstSymbol);

            Console.Write("Введіть другий символ: ");
            char secondSymbol = char.Parse(Console.ReadLine());
            int second = Convert.ToByte(secondSymbol);

            Console.WriteLine($"\nКод символу \"{firstSymbol}\" = {first}"+
                              $"\nКод символу \"{secondSymbol}\" = {second}");
            if(first == second)
            {
                Console.WriteLine("Символи однакові!");
                Console.ReadLine();
                return;
            }
            if(first > second)
            {
                Console.WriteLine($"Код символу '{firstSymbol}' більший за код символу '{secondSymbol}'");
            }
            else
                Console.WriteLine($"Код символу '{secondSymbol}' більший за код символу '{firstSymbol}'");
            Console.ReadLine();
        }
    }
}
