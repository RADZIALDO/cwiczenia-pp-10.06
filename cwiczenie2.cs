using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj ile kolejnych wyrazów wypisać: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ciag: ");
            for (int i = a; i >= 0; i--) 
            {
                Console.WriteLine(Fibb(i));
            }


            
            Console.ReadKey();
        }
        static int Fibb(int n)
        {
            if (n == 0)
                return 0;
            else if ((n == 1) || (n == 2)) 
            {
                return 1;
            }
            else
            {
                return Fibb(n - 1) + Fibb(n - 2); 
            }
        }
    }
}
