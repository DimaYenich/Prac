using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зчитується файл z4.dat");
            StreamReader sr = new StreamReader("z4.dat");
            string textInFile = sr.ReadToEnd();
            sr.Close();
            int maxCode = Convert.ToByte(textInFile[0]);
            Console.Write("\nСимвол\tЙого код\n\n");

            string textForWrite = null;
            for (int i = 0; i < textInFile.Length; i++)
            {
                if (maxCode < Convert.ToByte(textInFile[i]))
                    maxCode = Convert.ToByte(textInFile[i]);
                textForWrite += textInFile[i] + "\t" + Convert.ToByte(textInFile[i]) + "\n";
            }
            Console.Write(textForWrite);

            Console.WriteLine($"\nНайбільший код має \'{Convert.ToChar(maxCode)}\'" +
                              $" з кодом {maxCode}");
            StreamWriter sw = new StreamWriter("z4-2.rez");

            sw.WriteLine(textForWrite + $"\nНайбільший код має \'{Convert.ToChar(maxCode)}\'" +
                                        $" з кодом {maxCode}");
            sw.Close();
            Console.ReadLine();
        }
    }
}
