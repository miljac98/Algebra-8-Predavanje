using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unos riječi
            Console.Write("Unesite riječ: ");
            string rijec = Console.ReadLine();

            // Unos rečenice
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();


            // Razdvajanje rečenice na riječi
            string[] rijeci = recenica.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            // Brojanje ponavljanja unesene riječi
            int brojPonavljanja = rijeci.Count(x => x.Equals(rijec, StringComparison.OrdinalIgnoreCase));

            // Ispis rezultata
            Console.WriteLine($"Riječ '{rijec}' se pojavljuje {brojPonavljanja} puta u rečenici.");
            Console.ReadLine();
        }
    }
}
