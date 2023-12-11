using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9_1_5
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            string[] rijeci = recenica.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            //rijeci = rijeci.Select(r => RemoveSpecialCharacters(r)).ToArray();
            rijeci = rijeci
                .Select(str => new string(str
                .Where(c => Char.IsLetterOrDigit(c))
                .ToArray())).ToArray();

            var brojPonavljanja = rijeci
                .GroupBy(r => r, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.Count());

            Console.WriteLine("Broj ponavljanja svake riječi u rečenici:");

            foreach (var par in brojPonavljanja)
            {
                Console.WriteLine($"Riječ '{par.Key}' se pojavljuje {par.Value} puta.");
            }
            Console.ReadLine();
        }


        //static string RemoveSpecialCharacters(string str)
        //{
        //    return new string(str.Where(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)).ToArray());
        //}


    }
}
