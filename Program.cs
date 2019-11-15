using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testing_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dodawanie:" + Add(a, b));
            Console.ReadKey();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
