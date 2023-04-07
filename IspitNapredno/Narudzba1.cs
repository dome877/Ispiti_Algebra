using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitNapredno
{
    internal class Narudzba1
    {
        public delegate void PredajNarudzbu(Narudzba1 narudzba);

        public event PredajNarudzbu NarudzbaPredana;
        public string Naziv { get; set; }

        public void KreirajNarudzbu()
        {
            Console.WriteLine("Narudzba {0} je narucena", this.Naziv);
            NarudzbaPredana?.Invoke(this);
        }
    }
}
