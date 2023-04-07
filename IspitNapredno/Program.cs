using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitNapredno
{
    delegate void NarudzbaNarucena(DateTime datumIVrijeme);

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Narudzba1 narudzba1 = new Narudzba1("Jabuka");
            Narudzba1 narudzba2 = new Narudzba1("Banana");
            Distributer1 distributer = new Distributer1();

            
            narudzba1.NarudzbaPredana += Narudzba_NarudzbaPredana;
            narudzba2.NarudzbaPredana += Narudzba_NarudzbaPredana;
            distributer.NarudzbaUIsporuci += Distributer_NarudzbaUIsporuci;


            narudzba1.KreirajNarudzbu();
            narudzba2.KreirajNarudzbu();

            Console.WriteLine("Datum naručivanja:");
            foreach (Narudzba1 narudzba in new Narudzba1[] { narudzba1, narudzba2 })
            {
                Console.WriteLine($"{narudzba.Naziv}: {narudzba.DatumNarudzbe}");
            }

            
            distributer.KrecemSDostavom();

            Console.ReadKey();
        }

        private static void Narudzba_NarudzbaPredana(Narudzba1 narudzba)
        {
            Console.WriteLine($"Narudžba {narudzba.Naziv} je naručena.");
        }

        private static void Distributer_NarudzbaUIsporuci(DateTime datumIVrijeme)
        {
            Console.WriteLine($"Kamion je krenuo u dostavu u {datumIVrijeme}.");
        }

    }

}
