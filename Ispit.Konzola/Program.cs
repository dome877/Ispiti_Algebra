using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit.Model;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Ucenik> listaUcenika = new List <Ucenik>();
            for (int i = 0;i < 3;i++)
            {
                Ucenik ucenik = new Ucenik();
                Console.Write("Unesite ime učenika: ");
                ucenik.Ime = Console.ReadLine();
                Console.Write("Unesite prezime učenika: ");
                ucenik.Prezime = Console.ReadLine();
                Console.Write("Unesite datum rođenja učenika u formatu godina.mjesec.dan : ");
                ucenik.DatumRodjenja=DateTime.Parse(Console.ReadLine());
                Console.Write("Unesite prosjek učenika (mora biti od 1 do 5) i pisati zarez a ne točku! : ");
                ucenik.Prosjek = double.Parse(Console.ReadLine());

                listaUcenika.Add(ucenik);

                Console.WriteLine(ucenik.Prosjek);
            }
            foreach (Ucenik u in listaUcenika)
            {
                Console.WriteLine("Podatci o uceniku: {0} {1}", u.Ime, u.Prezime);
                u.Starost();
                Console.WriteLine("Prosjek je: {0} {1}", u.IspisProsjeka(),u.Prosjek);
            }
            Console.ReadKey();
        }
    }
}
