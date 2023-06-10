using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę x: ");
            int x = int.Parse(Console.ReadLine());

            int n = 0;
            int siln = Silnia(n);

            while (siln <= x)
            {
                if(siln == x)
                {
                    Console.WriteLine($"Liczba {x} jest silnią liczby {n}");
                    Console.ReadKey();
                    return;
                }
                n++;
                siln = Silnia(n);
            }

            Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby");

            Console.ReadKey();
        }
        static int Silnia(int si)
        {
            if ((si == 0) || (si == 1))
                return 1;
            else
                return si * Silnia(si - 1);
        }
    }
}
