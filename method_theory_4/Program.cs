using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace method_theory_4
{
    internal class Program
    {
        //создать методы для прочтения и записи текста из файла
        static string Read(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }

        static void Write(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(text);
            }
        }

        static void Main(string[] args)
        {
            string read = "fff.txt";
            string write = "ggvp.txt";

            Console.WriteLine("Введите текст: ");
            string a = Console.ReadLine();
            Write(a, write);

            Console.WriteLine($"Текст из файла:\n{Read(read)}"); 
            Console.ReadKey();
        }
    }
}
