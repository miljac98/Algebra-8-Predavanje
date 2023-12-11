using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    // Custom EventArgs klasa
    public class ProizvodEventArgs : EventArgs
    {
        public int BrojProizvoda { get; }

        public ProizvodEventArgs(int brojProizvoda)
        {
            BrojProizvoda = brojProizvoda;
        }
    }

    internal class Proizvodac
    {
        // Događaj koji će se pozivati kada proizvođač proizvede neki proizvod
        public event EventHandler<ProizvodEventArgs> ProizvodProizveden;

        // Metoda za proizvodnju proizvoda
        public void Proizvodi()
        {
            Random random = new Random();
            int brojProizvoda = random.Next(1, 101);

            Console.WriteLine($"Proizvođač je proizveo {brojProizvoda} proizvoda.");

            // Pozivamo događaj i šaljemo informaciju o proizvedenom broju proizvoda
            OnProizvodProizveden(new ProizvodEventArgs(brojProizvoda));
        }

        // Metoda koja poziva događaj
        protected virtual void OnProizvodProizveden(ProizvodEventArgs e)
        {
            ProizvodProizveden?.Invoke(this, e);
        }
    }
}
