using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    internal class Potrosac
    {
        // Pretplata na događaj proizvođača
        public void PretplatiSeNaProizvodnju(Proizvodac proizvodac)
        {
            proizvodac.ProizvodProizveden += ProizvodProizvedenHandler;
        }

        // Metoda koja se poziva kada proizvođač proizvede proizvod
        private void ProizvodProizvedenHandler(object sender, ProizvodEventArgs e)
        {
            Console.WriteLine($"Potrošač je primio proizvod: {e.BrojProizvoda}");
        }
    }
}
