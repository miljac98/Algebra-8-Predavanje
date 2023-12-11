using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9_1_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Unesite riječ: ");
            string rijec = Console.ReadLine();

            Console.Write("Unesite znak: ");
            char znak = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Prijelaz u novi red nakon unosa znaka


            int brojac = 0;

            foreach (char karakter in rijec)
            {
                if (karakter == znak)
                {
                    brojac++;
                }
            }

            Console.WriteLine($"Znak '{znak}' se pojavljuje {brojac} puta u riječi '{rijec}'.");
            Console.ReadLine();
        }

    }
}
