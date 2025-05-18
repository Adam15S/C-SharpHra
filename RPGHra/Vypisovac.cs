using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHra
{
    class Vypisovac
    {
        public void VypisPostavu(int cisloPostavy, string[] postavy, int[] postavyMaxHP, int[] postavyHP, int[] maxMana, int[] mana, int[] mince, int[] utok)
        {
            cisloPostavy = cisloPostavy - 1;
            Console.WriteLine("\nPopis postavy:");
            Console.WriteLine("--------------");
            Console.WriteLine("Jméno: " + postavy[cisloPostavy]);
            Console.WriteLine("Max. životy: " + postavyMaxHP[cisloPostavy]);
            Console.WriteLine("Životy na začátku: " + postavyHP[cisloPostavy]);
            Console.WriteLine("Max. mana: " + maxMana[cisloPostavy]);
            Console.WriteLine("Mana na začátku: " + mana[cisloPostavy]);
            Console.WriteLine("Počet mincí na začátku: " + mince[cisloPostavy]);
            Console.WriteLine("Level na začátku: 1");
            Console.WriteLine("Zkušenosti na začátku: 0");
            Console.WriteLine("Útok: " + utok[cisloPostavy]);
            Console.Write("Schopnosti: Útok = " + utok[cisloPostavy] + "; Oživení: +10 HP, cena: 4 many; Speciální útok: ");
            if (cisloPostavy == 0)
            {
                Console.WriteLine("Dodatačné poškození všem nepřátelům 10 HP, trvání: následující 1 kolo, cena: 8 man");
            }
            if (cisloPostavy == 1)
            {
                Console.WriteLine("Oslabení útoku nejsilnějšího nepřátele o 5 DMG, trvání: následující 3 kola, cena: 8 man");
            }
            if (cisloPostavy == 2)
            {
                Console.WriteLine("Pohlcení 10 DMG z útoků od všech nepřátel, trvání: 2 kola, cena: 12 man");
            }
            if (cisloPostavy == 3)
            {
                Console.WriteLine("Oživení +25 HP, cena: 8 man");
            }
        }
    }
}
