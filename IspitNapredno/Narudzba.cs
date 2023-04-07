using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IspitNapredno
{
    internal class Narudzba
    {
        public delegate void PredajNarudzbu(Narudzba narudzba);

        public event PredajNarudzbu NarudzbaPredana;
        public string Naziv { get; set; }
        
        public void KreirajNarudzbu()
        {
            Console.WriteLine("Narudzba {0} je narucena", this.Naziv);
            NarudzbaPredana?.Invoke(this);
        }

    }
}
