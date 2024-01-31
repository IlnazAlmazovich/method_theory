using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_theory_3
{
    internal class Program
    {
        //создать метод для сортировки списка
        static List<int> Slist(List<int> l)
        {
            l.Sort();
            return l;
        }
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                l1.Add(random.Next(0, 100));
                Console.WriteLine(l1[i]);
            }
            Slist(l1);
            Console.WriteLine("Отсортированный список:");
            foreach (int s in l1)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
