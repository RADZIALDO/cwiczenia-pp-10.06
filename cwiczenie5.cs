using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x: ");
            int x = int.Parse(Console.ReadLine());

            double edox = 1;
            for (int i = 1; i <= n; i++)
            {
                edox += (Math.Pow(x,i) / Silnia(i));
            }

            Console.WriteLine($"e^x = {edox}");
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
