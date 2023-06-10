using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());

            int odwroconaLiczba = OdwrLiczb(liczba);

            Console.WriteLine($"Liczba po odwroceniu cyfr: {odwroconaLiczba}");

            Console.ReadKey();
        }
        static int OdwrLiczb(int liczba) 
        {
            int odwroconaLiczba = 0;

            while(liczba > 0)
            {
                int cyfra = liczba % 10;
                odwroconaLiczba = (odwroconaLiczba * 10) + cyfra;
                liczba /= 10;
            }
            return odwroconaLiczba;
        }
    }
}
