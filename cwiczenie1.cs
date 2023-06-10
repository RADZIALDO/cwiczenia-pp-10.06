using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pot, wykl, wyn = 1;
            Console.WriteLine("Podaj podstawę potęgi: ");
            pot = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wykładnik potęgi: ");
            wykl = int.Parse(Console.ReadLine());

            wyn = Potega(pot, wykl);

            Console.Write($"Wynik potęgowania: {wyn}");
            

            Console.ReadLine();
        }
        static int Potega(int p, int w)
        {
            if (w == 1)
                return p;
            int wynik = Potega(p, w - 1);
            return p * wynik;
        }
    }
}
