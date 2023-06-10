using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kwotaPocz, oprocent, liczbaMies, oszczednosci, podatek = 0.19;

            Console.Write("Podaj kwotę wpłacaną na konto: ");
            kwotaPocz = double.Parse(Console.ReadLine());
            Console.Write("Podaj oprocentowanie konta w skali roku: ");
            oprocent = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę miesięcy oszczędzania: ");
            liczbaMies = double.Parse(Console.ReadLine());

            oszczednosci = (kwotaPocz * ((oprocent/100)/12) * liczbaMies);
            oszczednosci -= (podatek * oszczednosci);

            Console.Write($"Liczba miesięcy oszczędzania: {liczbaMies}; kwota oszczędności: {oszczednosci}");

            Console.ReadKey();
        }
    }
}
