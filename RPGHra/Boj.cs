using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHra
{
    class Boj
    {
        public void BojujSMonstrem(int pocetMonster, int utok, ref int monstrumHP1, ref int monstrumHP2, ref int monstrumHP3, string postava, int cisloPostavy, ref int mana, ref int postavaHP, int monstrumUtok)
        {
            do
            {
                ConsoleKeyInfo bojVyber;
                bool spravneZadani;
                Console.WriteLine("Jste na tahu:");
                Console.WriteLine("[MEZERNÍK - Zaútočit]");
                Console.WriteLine("[ENTER - Zaútočit a použít speciální útok]");
                Console.WriteLine("[H - Schovat se a oživit]");

                bojVyber = Console.ReadKey(true);
                switch (bojVyber.Key)
                {
                    case ConsoleKey.Spacebar:
                        if (pocetMonster == 1)
                        {
                            monstrumHP1 -= utok;
                            Console.WriteLine(postava + " útočí silou " + utok + " DMG.");
                            Console.WriteLine("Monstru zbývá " + monstrumHP1 + " HP.");
                        }
                        else if (pocetMonster == 2)
                        {
                            monstrumHP1 -= utok / 2;
                            monstrumHP2 -= utok / 2;
                            Console.WriteLine(postava + " útočí silou " + utok + " DMG na obě monstra.");
                            Console.WriteLine("Oboum monstrům zbývá " + monstrumHP1 + " HP.");
                        }
                        else if (pocetMonster == 3)
                        {
                            monstrumHP1 -= utok / 3;
                            monstrumHP2 -= utok / 3;
                            monstrumHP3 -= utok / 3;
                            Console.WriteLine(postava + " útočí silou " + utok + " DMG na všechna monstra.");
                            Console.WriteLine("Všem třem monstrům zbývá " + monstrumHP1 + " HP.");
                        }
                        Thread.Sleep(3000);
                        break;
                    case ConsoleKey.Enter:
                        if (pocetMonster == 1)
                        {
                            monstrumHP1 -= utok;
                            Console.WriteLine(postava + " útočí silou " + utok + " DMG.");
                            switch (cisloPostavy)
                            {
                                case 0:
                                    if (mana >= 8)
                                    {
                                        mana -= 8;
                                        monstrumHP1 -= 10;
                                        Console.WriteLine("Udeřili jste druhým útokem a monstru jste ubrali dalších 10 HP.");
                                        Console.WriteLine("Monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 1:
                                    if (mana >= 8)
                                    {
                                        mana -= 8;
                                        Console.WriteLine("Použili jste omračovací útok, monstrum bude další 3 kola dávat o 5 DMG méně.");
                                        Console.WriteLine("Monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 2:
                                    if (mana >= 12)
                                    {
                                        mana -= 12;
                                        Console.WriteLine("Použili jste posilovací lektvar a další 2 kola pohltíte 10 DMG od všech nepřátel.");
                                        Console.WriteLine("Monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 3:
                                    if (mana >= 8)
                                    {
                                        mana -= 12;
                                        postavaHP += 25;
                                        Console.WriteLine("Po útoku jste měli čas vypít oživovací lektvar a oživit se o 25 HP.");
                                        Console.WriteLine("Monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstru zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                            }
                        }
                        else if (pocetMonster == 2)
                        {
                            monstrumHP1 -= utok / 2;
                            monstrumHP2 -= utok / 2;
                            Console.WriteLine(postava + " útočí silou " + utok + " DMG.");
                            switch (cisloPostavy)
                            {
                                case 0:
                                    if (mana >= 8)
                                    {
                                        mana -= 8;
                                        monstrumHP1 -= 10;
                                        monstrumHP2 -= 10;
                                        Console.WriteLine("Udeřili jste druhým útokem a monstrům jste ubrali dalších 10 HP.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 1:
                                    if (mana >= 8)
                                    {
                                        mana -= 8;
                                        Console.WriteLine("Použili jste omračovací útok, monstrům bude další 3 kola dávat o 5 DMG méně.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 2:
                                    if (mana >= 12)
                                    {
                                        mana -= 12;
                                        Console.WriteLine("Použili jste posilovací lektvar a další 2 kola pohltíte 10 DMG od všech nepřátel.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 3:
                                    if (mana >= 8)
                                    {
                                        mana -= 12;
                                        postavaHP += 25;
                                        Console.WriteLine("Po útoku jste měli čas vypít oživovací lektvar a oživit se o 25 HP.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                            }
                        }
                        else if (pocetMonster == 3)
                        {
                            monstrumHP1 -= utok / 3;
                            monstrumHP2 -= utok / 3;
                            monstrumHP3 -= utok / 3;
                            Console.WriteLine(postava + " útočí silou " + utok + " DMG.");
                            switch (cisloPostavy)
                            {
                                case 0:
                                    if (mana >= 8)
                                    {
                                        mana -= 8;
                                        monstrumHP1 -= 10;
                                        monstrumHP2 -= 10;
                                        monstrumHP3 -= 10;
                                        Console.WriteLine("Udeřili jste druhým útokem a monstrům jste ubrali dalších 10 HP.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 1:
                                    if (mana >= 8)
                                    {
                                        mana -= 8;
                                        Console.WriteLine("Použili jste omračovací útok, monstrům bude další 3 kola dávat o 5 DMG méně.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 2:
                                    if (mana >= 12)
                                    {
                                        mana -= 12;
                                        Console.WriteLine("Použili jste posilovací lektvar a další 2 kola pohltíte 10 DMG od všech nepřátel.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                                case 3:
                                    if (mana >= 8)
                                    {
                                        mana -= 12;
                                        postavaHP += 25;
                                        Console.WriteLine("Po útoku jste měli čas vypít oživovací lektvar a oživit se o 25 HP.");
                                        Console.WriteLine("Monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                        Console.WriteLine("Použili jste pouze základní a monstrům zbývá " + monstrumHP1 + " HP.");
                                    }
                                    break;
                            }
                        }
                        Thread.Sleep(3000);
                        break;
                    case ConsoleKey.H:
                        if (mana >= 4)
                        {
                            mana -= 4;
                            Console.WriteLine("Schovali jste se do malé jeskyně poblíž a oživili své životy o 10 HP.");
                            Console.WriteLine("Stálo vás to 4 many.");
                        }
                        else
                        {
                            Console.WriteLine("Na oživení nemáte dostatek many.");
                            Console.WriteLine("Během toho se monstrum dostalo blíže a zaútočilo.");
                        }
                        Thread.Sleep(3000);
                        break;
                }

                if (monstrumHP1 == 0)
                {
                    break;
                }

                Console.WriteLine("Na tahu je monstrum.");
                Thread.Sleep(1000);
                if (monstrumHP2 != -1 && monstrumHP3 == -1)
                {
                    postavaHP -= monstrumUtok * 2;
                    Console.WriteLine("Monstrum útočí silou " + monstrumUtok * 2 + " DMG.");
                }
                else if (monstrumHP2 != -1 && monstrumHP3 != -1)
                {
                    postavaHP -= monstrumUtok * 3;
                    Console.WriteLine("Monstrum útočí silou " + monstrumUtok * 3 + " DMG.");
                }
                else
                {
                    postavaHP -= monstrumUtok;
                    Console.WriteLine("Monstrum útočí silou " + monstrumUtok + " DMG.");
                }
                Thread.Sleep(2000);
                Console.WriteLine("Zbývá vám " + postavaHP + " HP.");
                Thread.Sleep(1000);
            } while (monstrumHP1 <= 0 || postavaHP <= 0);

            if (monstrumHP1 == 0)
            {
                if (monstrumHP2 != -1)
                {
                    Console.WriteLine("Úspěšně jste porazili monstrum! Vaše cesta může pokračovat.");
                } else
                {
                    Console.WriteLine("Úspěšně jste porazili monstra! Vaše cesta může pokračovat.");
                }
            }
            else
            {
                if (monstrumHP2 != -1)
                {
                    Console.WriteLine("Monstru jste se neubránil a vaše postava mu podlehla.");
                }
                else
                {
                    Console.WriteLine("Tato monstra na vás byla zřejmě příliš silná a vy jste se neubránil.");
                }
            }
        }

        public void BojujSBossem(int utok, int bossHP, string postava, string boss, int cisloPostavy, int mana, ref int postavaHP, int bossUtok)
        {
            Losovac losovac = new Losovac();

            int aktualniHP = bossHP;
            int aktualniMana = mana;

            int infekce = losovac.VylosovatInfekci();

            do
            {
                Console.WriteLine("Na tahu je monstrum.");
                Thread.Sleep(1000);
                postavaHP -= bossUtok;
                Console.WriteLine(boss + " útočí silou " + bossUtok + " DMG.");
                Thread.Sleep(1000);
                Console.WriteLine("Jeho útok vás infikoval kvůli infekci ztrácíte dalších " + infekce + " HP.");
                Thread.Sleep(2000);
                Console.WriteLine("Zbývá vám " + postavaHP + " HP.");
                Thread.Sleep(1000);

                ConsoleKeyInfo bojVyber;
                bool spravneZadani;
                Console.WriteLine("Jste na tahu:");
                Console.WriteLine("[MEZERNÍK - Zaútočit]");
                Console.WriteLine("[ENTER - Zaútočit a použít speciální útok]");
                Console.WriteLine("[H - Schovat se a oživit]");

                bojVyber = Console.ReadKey(true);
                switch (bojVyber.Key)
                {
                    case ConsoleKey.Spacebar:
                        aktualniHP -= utok;
                        Console.WriteLine(postava + " útočí silou " + utok + " DMG na bosse.");
                        Console.WriteLine("Bossovi zbývá " + aktualniHP + " HP.");
                        Thread.Sleep(3000);
                        break;
                    case ConsoleKey.Enter:
                        aktualniHP -= utok;
                        Console.WriteLine(postava + " útočí silou " + utok + " DMG.");
                        switch (cisloPostavy)
                        {
                            case 0:
                                if (aktualniMana >= 8)
                                {
                                    aktualniMana -= 8;
                                    aktualniHP -= 10;
                                    Console.WriteLine("Udeřili jste druhým útokem a bossovi jste ubrali dalších 10 HP.");
                                    Console.WriteLine("Bossovi zbývá " + aktualniHP + " HP.");
                                }
                                else
                                {
                                    Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                    Console.WriteLine("Použili jste pouze základní a bossovi zbývá " + aktualniHP + " HP.");
                                }
                                break;
                            case 1:
                                if (aktualniMana >= 8)
                                {
                                    aktualniMana -= 8;
                                    Console.WriteLine("Použili jste omračovací útok, bossovi bude další 3 kola dávat o 5 DMG méně.");
                                    Console.WriteLine("Bossovi zbývá " + aktualniHP + " HP.");
                                }
                                else
                                {
                                    Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                    Console.WriteLine("Použili jste pouze základní a bossovi zbývá " + aktualniHP + " HP.");
                                }
                                break;
                            case 2:
                                if (aktualniMana >= 12)
                                {
                                    aktualniMana -= 12;
                                    Console.WriteLine("Použili jste posilovací lektvar a další 2 kola pohltíte 10 DMG od všech nepřátel.");
                                    Console.WriteLine("Bossovi zbývá " + aktualniHP + " HP.");
                                }
                                else
                                {
                                    Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                    Console.WriteLine("Použili jste pouze základní a bossovi zbývá " + aktualniHP + " HP.");
                                }
                                break;
                            case 3:
                                if (aktualniMana >= 8)
                                {
                                    aktualniMana -= 12;
                                    postavaHP += 25;
                                    Console.WriteLine("Po útoku jste měli čas vypít oživovací lektvar a oživit se o 25 HP.");
                                    Console.WriteLine("Bossovi zbývá " + aktualniHP + " HP.");
                                }
                                else
                                {
                                    Console.WriteLine("Nemáte dostatek many na speciální útok.");
                                    Console.WriteLine("Použili jste pouze základní a bossovi zbývá " + aktualniHP + " HP.");
                                }
                                break;
                        }
                        Thread.Sleep(3000);
                        break;
                    case ConsoleKey.H:
                        if (aktualniMana >= 4)
                        {
                            mana -= 4;
                            Console.WriteLine("Schovali jste se do malé jeskyně poblíž a oživili své životy o 10 HP.");
                            Console.WriteLine("Stálo vás to 4 many.");
                        }
                        else
                        {
                            Console.WriteLine("Na oživení nemáte dostatek many.");
                            Console.WriteLine("Během toho se " + boss + " dostal blíže a zaútočil.");
                        }
                        Thread.Sleep(3000);
                        break;
                }

                if (aktualniHP == 0)
                {
                    break;
                }
                infekce += losovac.VylosovatInfekci();
            } while (aktualniHP <= 0 || postavaHP <= 0);

            if (aktualniHP == 0)
            {
                Console.WriteLine("Úspěšně jste porazili bosse a pročistili jste celé království od monster!");
            }
            else
            {
                Console.WriteLine("Boss byl příliš silný a tak jste bohužel království nezachránili.");
            }
        }
    }
}
