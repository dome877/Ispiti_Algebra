using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitNapredno
{
    internal class Distributer1
    {
        public event NarudzbaNarucena NarudzbaUIsporuci;

        public void KrecemSDostavom()
        {
            NarudzbaUIsporuci?.Invoke(DateTime.Now);
        }
    }
}
