using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n, k, m;

            do
            {
                Console.Write("Podaj liczbę nie mniejszą od 5. n = ");
                n = long.Parse(Console.ReadLine());
            } while (!(n >= 5));

            do
            {
                Console.Write("Podaj liczbę nie mniejszą od 5. k = ");
                k = long.Parse(Console.ReadLine());
            }while (!(k >= 5));

            m = ((Silnia(n) - Silnia(k)) / Silnia(k));

            Console.WriteLine($"m = {m}");



            Console.ReadKey();
        }
        static long Silnia(long si)
        {
                if ((si == 0) || (si == 1))
                    return 1;
                else
                    return si * Silnia(si - 1);
        }
    }
}
