using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_dogadaji
{
    public class RepozitorijProizvoda
    {

        public List<Proizvod> Proizvodi = new List<Proizvod>();

        public RepozitorijProizvoda() 
        {
            Proizvodi.Add(new Proizvod(){ Id = 1, Naziv = "Čokolada" });
            Proizvodi.Add(new Proizvod(){ Id = 2, Naziv = "Kruh" });
            Proizvodi.Add(new Proizvod(){ Id = 3, Naziv = "Jogurt" });
        }

        public void DodajProizvod(string naziv)
        {
            int sljedeciId = Proizvodi.Max(x => x.Id) + 1;
            Proizvodi.Add(new Proizvod { Id = 4, Naziv = naziv });
        }
    }
}
