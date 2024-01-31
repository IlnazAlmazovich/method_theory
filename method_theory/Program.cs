using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace method_theory
{
    internal class Program
    {
        //Создать метод для поиска максимального элемента в массиве
        static int max(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;

                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(0,100);
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine($"Mаксимальный элемент в массиве = {max(arr1)}");
            Console.ReadKey();
        }
    }
}
