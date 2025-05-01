using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHra
{
    class Vesnice
    {
        public void DoplnitZivoty(int aktualniZivoty, int[] maxZivoty, int aktualniMince, int postava)
        {
            if (aktualniMince < 20)
            {
                Console.WriteLine("Chtěli jste se nechat ošetřit, ale zapomněli jste že nemáte dostatek mincí a místní lékař vás vyhnal z vesnice.");
                Thread.Sleep(3000);
                Console.WriteLine("Musíte proto pokračovat dále.");
                Console.WriteLine("\n[Stiskněte klávesu ENTER pro pokračování.]");
                Console.ReadLine();
            } else if (aktualniZivoty == maxZivoty[postava - 1] - 1)
            {
                Console.WriteLine("Lékař vás vyšetřil, ale vy ošetření nepotřebujete. Nic jste tedy nemuseli platit.");
            }
            else
            {
                aktualniMince -= 20;
                if (aktualniZivoty >= maxZivoty[postava - 1] - 1 && aktualniZivoty <= maxZivoty[postava - 1] - 9)
                {
                    aktualniZivoty = maxZivoty[postava - 1];
                } else
                {
                    aktualniZivoty += 10;
                }
                Console.WriteLine("Byl jste úspěšně ošetřen a teď jste zdravý jako rybička.");
                Thread.Sleep(2000);
                Console.WriteLine("Vaše životy jsou teď " + aktualniZivoty + " HP.");
                Thread.Sleep(1000);
                Console.WriteLine("Váš rozpočet je nyní " + aktualniMince + " mincí.");
                Thread.Sleep(1000);
            }
        }

        public void VylepsitZivoty(int[] maxZivoty, int aktualniMince, int postava)
        {
            if (aktualniMince < 20)
            {
                Console.WriteLine("Vzali jste si posilovací ovoce ale neměli jste čím zaplatit.");
                Thread.Sleep(2000);
                Console.WriteLine("Místní farmáři vás chytili, omráčili, ovoce vám sebrali a vyvezli vás z vesnice.");
                Thread.Sleep(3000);
                Console.WriteLine("Musíte proto pokračovat dále.");
                Console.WriteLine("\n[Stiskněte klávesu ENTER pro pokračování.]");
                Console.ReadLine();
            }
            else
            {
                aktualniMince -= 20;
                maxZivoty[postava - 1] += 5;
                Console.WriteLine("Koupil jste si speciální ovoce z místního sadu, snědl ho a vaše odolnost se zlepšila.");
                Thread.Sleep(3000);
                Console.WriteLine("Vaše maximální životy jsou teď " + maxZivoty[postava - 1] + " HP.");
                Thread.Sleep(1000);
                Console.WriteLine("Váš rozpočet je nyní " + aktualniMince + " mincí.");
                Thread.Sleep(1000);
            }
        }

        public void VylepsitManu(int[] maxMana, int aktualniHP, int aktualniMince, int postava)
        {
            if (aktualniMince < 30)
            {
                Console.WriteLine("Čaroděj vám dal lektvar na zlepšení schopností, ale vy jste neměl čím zaplatit.");
                Thread.Sleep(2000);
                Console.WriteLine("A tak na vás čaroděj seslal kletbu, účinky lektvaru zneutralizoval, přemístil vás na louku za vesnicí a ubral vám 5 HP.");
                aktualniHP -= 5;
                Thread.Sleep(3000);
                Console.WriteLine("Musíte proto pokračovat dále.");
                Console.WriteLine("\n[Stiskněte klávesu ENTER pro pokračování.]");
                Console.ReadLine();
            }
            else
            {
                aktualniMince -= 30;
                maxMana[postava - 1] += 5;
                Console.WriteLine("Místní čaroděj vám dal lektvar a vaše schopnosti se zlepšily.");
                Thread.Sleep(2000);
                Console.WriteLine("Vaše maximální mana je teď " + maxMana[postava - 1] + ".");
                Thread.Sleep(1000);
                Console.WriteLine("Váš rozpočet je nyní " + aktualniMince + " mincí.");
                Thread.Sleep(1000);
            }
        }

        public void VylepsitUtok(int[] utok, int aktualniMince, int postava)
        {
            if (aktualniMince < 35)
            {
                Console.WriteLine("Trenér vás chtěl učit ale vy jste neměl čím zaplatit a tak vás vyhnal z města.");
                Thread.Sleep(2000);
                Console.WriteLine("Musíte proto pokračovat dále.");
                Console.WriteLine("\n[Stiskněte klávesu ENTER pro pokračování.]");
                Console.ReadLine();
            }
            else
            {
                aktualniMince -= 35;
                utok[postava - 1] += 10;
                Console.WriteLine("Zkušený trenér vás úspěšně vycvičil a nyní jste silnější.");
                Thread.Sleep(2000);
                Console.WriteLine("Váš útok je nyní " + utok[postava - 1] + " DMG.");
                Thread.Sleep(1000);
                Console.WriteLine("Váš rozpočet je nyní " + aktualniMince + " mincí.");
                Thread.Sleep(1000);
            }
        }
    }
}
