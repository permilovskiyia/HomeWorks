using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = c;
            c = b; b = a; a = d;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
