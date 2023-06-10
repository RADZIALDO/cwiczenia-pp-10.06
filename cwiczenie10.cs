using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba >= 100)
                WypiszCyfry(liczba);
            else
                Console.WriteLine("Liczba ma mniej niż 3 cyfry");

            Console.ReadKey();
        }
        static void WypiszCyfry(int liczba)
        {
            Console.WriteLine($"Poszczególne cyfry liczby {liczba} to: ");

            string cyfry = "";

            while(liczba > 0)
            {
                int cyfra = liczba % 10;
                cyfry = cyfra + " " + cyfry;
                liczba /= 10;
            }
            Console.WriteLine(cyfry);
        }
    }
}
