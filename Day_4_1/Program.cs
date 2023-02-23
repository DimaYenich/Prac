using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зчитується файл z4.dat");
            StreamReader sr = new StreamReader("z4.dat");
            string text = sr.ReadToEnd();  
            Console.WriteLine("Вміст файлу: " + text);
            Console.WriteLine($"Кількість символів у файлі: {text.Length}");
            if (text.Length % 2 == 0)
                Console.WriteLine("Кількість символів парна. Виводиться 2");
            else
                Console.WriteLine("Кількість символів не парна. Виводиться 1");
            Console.ReadLine();
        }
    }
}
