using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace method_theory_2
{
    internal class Program
    {
        //Создать метод который проверяет является число чётным
        static  bool number(int a)
        {
            if (a % 2 == 0 )
            {
                
                return true;
            }
            else
            {
              
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int s = Convert.ToInt32(Console.ReadLine());    
            bool res = number(s);
            Console.WriteLine(number(s));
            Console.ReadKey();
        }
    }
}
