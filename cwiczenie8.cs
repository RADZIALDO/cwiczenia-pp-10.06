using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pomyśl liczbę z zakresu 1-20.");
            int min = 1;
            int max = 20;

            while(true)
            {
                int uzytkownik = (min + max) / 2;
                Console.WriteLine($"Czy Twoja liczba to {uzytkownik}(Wpisz: 1-mniejsza, 2-wieksza, 3-odgadlem)");

                int wpiszL = int.Parse( Console.ReadLine() );

                if(wpiszL == 3)
                {
                    Console.WriteLine($"Zgadłem! Twoja liczba to {uzytkownik}");
                    break;
                }else if(wpiszL == 1)
                {
                    max = uzytkownik - 1;
                }else if(wpiszL == 2)
                {
                    min = uzytkownik + 1;
                }
                else
                {
                    Console.WriteLine("Wpisz: 1-mniejsza, 2-wieksza, 3-odgadlem");
                }
            }
            
            Console.ReadKey();
        }
    }
}
