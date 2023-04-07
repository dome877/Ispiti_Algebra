﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitNapredno
{
    internal class Distributer
    {
        public event NarudzbaNarucena NarudzbaUIsporuci;
        public void KrecemSDostavom()
        {
            Console.WriteLine("Narudzba je istovarena u kamion i krenula {0}");
            NarudzbaUIsporuci?.Invoke(DateTime.Now);
        }
    }
}
