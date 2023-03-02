using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_3_1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
=======
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
>>>>>>> 05f458a8a5230a6d325ea9da014e68a23d033404
        }
    }
}
