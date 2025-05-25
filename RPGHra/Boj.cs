using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHra
{
    class Boj
    {
        public void BojujSMonstrem()
        {
            ConsoleKeyInfo bojVyber;
            bool spravneZadani;
            Console.WriteLine("Jste na tahu:");
            Console.WriteLine("[MEZERNÍK - Zaútočit]");
            Console.WriteLine("[ENTER - Zaútočit a použít speciální útok]");
            Console.WriteLine("[H - Schovat se a oživit]");

            bojVyber = Console.ReadKey(true);
            Console.WriteLine(bojVyber.Key);
            // H, Enter, Spacebar
        }
    }
}
