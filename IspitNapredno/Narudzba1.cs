using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitNapredno
{
    internal class Narudzba1
    {
        public string Naziv { get; set; }
        public DateTime DatumNarudzbe { get; private set; }

        public event PredajNarudzbu NarudzbaPredana;
        public delegate void PredajNarudzbu(Narudzba1 narudzba);

        public Narudzba1(string naziv)
        {
            Naziv = naziv;
        }

        public void KreirajNarudzbu()
        {

            DatumNarudzbe = DateTime.Now;
            NarudzbaPredana?.Invoke(this);
        }
    }
}
