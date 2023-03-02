using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Зчитування файлу z5-2.dat
            StreamReader sr = new StreamReader("z5-2.dat");
            string textInFile = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine("Файл \"z5-2.dat\" зчитано! \nПочатковий текст: "+ textInFile);

            string textForWrite = null;
            for (int i = 0; i < textInFile.Length; i++)
            {
                textForWrite += (Convert.ToChar(Convert.ToByte(textInFile[i])+1));
            }
            Console.WriteLine("\nТекст після додання до кожного коду символу 1: " + textForWrite);

            //Запис тексту в файл z5-2.rez
            WriteFile("z5-2.rez",textForWrite, "Текст записано в файл \"z5-2.rez\".");

            string textForRecode = null;
            Console.Write($"Бажаєте розшифрувати текст: {textForWrite} (1 - так, 2 - ні): ");
            int yesOrNo = int.Parse(Console.ReadLine());
            if (yesOrNo == 1)
            {
                for (int i = 0; i < textForWrite.Length; i++)
                {
                    textForRecode += (Convert.ToChar(Convert.ToByte(textForWrite[i]) - 1));
                }
                Console.WriteLine("\nРозкодований текст має такий вигляд: "+textForRecode);
                WriteFile("z5 - 3.rez", textForRecode, "Текст записано у файл \"z5 - 3.rez\".");
            }
            else
                return;

            Console.ReadLine();
        }
        static void WriteFile(string fileName, string fileText, string povidom)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(fileText);
            sw.Close();
            Console.WriteLine(povidom);
        }
    }
}
