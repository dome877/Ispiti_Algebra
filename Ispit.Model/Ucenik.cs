using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public void Starost()
        {
            Console.WriteLine("Starost je {0}",DateTime.Now.Year - DatumRodjenja.Year);
        }
        public string IspisProsjeka()
        {
            if (Prosjek>=1 && Prosjek <= 1.49)
            {
                return "Nedovoljan";
            }
            else if (Prosjek >= 1.50 && Prosjek <= 2.49)
            {
                return "Dovoljan";
            }
            else if (Prosjek >= 2.50 && Prosjek <= 3.49)
            {
                return "Dobar";
            }
            else if (Prosjek >= 3.50 && Prosjek <= 4.49)
            {
                return "Vrlo Dobar";
            }
            else if (Prosjek >= 4.50 && Prosjek <= 5)
            {
                return "Odličan";
            }
            else
            {
                return "nije dobar raspon unesen";
            }
        }
    }
}
