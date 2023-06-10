using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz liczbę n: ");
            int n = int.Parse(Console.ReadLine());
            ZnajdzPare(n);

            Console.ReadKey();
        }
        static void ZnajdzPare(int m)
        {
            Console.WriteLine($"Pary liczb naturalnych o sumie {m}");

            for (int i = 1; i <= (m / 2); i++) 
            {
                int secon = m - i;
                Console.WriteLine($"{i}, {secon}");
            }
        }
    }
}
