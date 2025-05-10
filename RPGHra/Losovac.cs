using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHra
{
    class Losovac
    {
        Random randomCislo = new Random();

        public int VylosovatMonstrum()
        {
            return randomCislo.Next(15);
        }
    }
}
