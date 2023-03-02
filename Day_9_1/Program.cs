using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int count = 0;
            int[] ar = new int[1];
            string forWrite = null;

            do
            {
                Console.WriteLine("\nКількість чисел: "+count);
                if (count % 4 == 0 && count != 0)
                    Console.Write("Кількість кратна 4. Можна почати рахувати відрізки (введіть 0)! \n");
                Console.Write("Введіть число: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 200)
                {
                    forWrite += n.ToString() + "\n";
                    count++;
                }
                else
                    if (n == 0)
                        break;
                else
                        Console.WriteLine("Число повине бути більше 1 та менше 200.");
                if (count % 4 == 0 && n == 0)
                    break;
            } while (n != 0);

            if (count % 4 != 0)
            {
                Console.WriteLine("Кількість не кратна 4! Вихід з програми!");
                Console.ReadLine();
                return;
            }

            if (forWrite != null)
                WriteFile("z9.dat",forWrite,"Числа збережено у файл z9.dat.");
            else
                Console.WriteLine("Ви нічого не ввели, збереження не відбулось!");
            if (forWrite == null)
            {
                Console.WriteLine("Ввід завершено!");
                Console.ReadLine();
                return;
            }
            

            string[] number = forWrite.Split('\n');
            string newForWrite = null;
            Array.Resize(ref ar,number.Length-1);
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(number[i]);
            }
            int point = 0;
            while(point == 0 || point <= ar.Length-4)
            {
                newForWrite += "Довжина відрізків: " + Math.Round(f(ar[point], ar[point + 1], ar[point + 2], ar[point + 3]),2);
                //Console.WriteLine(newForWrite);
                point += 3;
            }
            WriteFile("z9.rez",newForWrite,"Збережено!");
            Console.ReadLine();
        }
        static double f(double x1, double x2, double y1, double y2)
        {

            return Math.Sqrt( Math.Pow((x1-x2),2)+ Math.Pow((y1 - y2),2));
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
