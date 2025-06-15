using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHra
{
    class Boj
    {
        public void BojujSMonstrem(int pocetMonster, int utok, int monstrumHP1, int monstrumHP2, int monstrumHP3, string postava, int cisloPostavy, int mana, int postavaHP)
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
                case ConsoleKey.H:
                    if (pocetMonster == 1)
                    {
                        monstrumHP1 -= utok;
                        Console.WriteLine(postava + " útočí silou " + utok + " DMG.");
                        Console.WriteLine("Monstru zbývá " + monstrumHP1 + " HP.");
                    } else if (pocetMonster == 2)
                    {
                        monstrumHP1 -= utok / 2;
                        monstrumHP2 -= utok / 2;
                        Console.WriteLine(postava + " útočí silou " + utok + " DMG na obě monstra.");
                        Console.WriteLine("Oboum monstrům zbývá " + monstrumHP1 + " HP.");
                    } else if (pocetMonster == 3)
                    {
                        monstrumHP1 -= utok / 3;
                        monstrumHP2 -= utok / 3;
                        monstrumHP3 -= utok / 3;
                        Console.WriteLine(postava + " útočí silou " + utok + " DMG na všechna monstra.");
                        Console.WriteLine("Všem třem monstrům zbývá " + monstrumHP1 + " HP.");
                    }
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
                                } else
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
                    break;
                case ConsoleKey.Spacebar:
                    if (mana >= 4)
                    {
                        mana -= 4;
                        Console.WriteLine("Schovali jste se do malé jeskyně poblíž a oživili své životy o 10 HP.");
                        Console.WriteLine("Stálo vás to 4 many.");
                    } else
                    {
                        Console.WriteLine("Na oživení nemáte dostatek many.");
                        Console.WriteLine("Během toho se monstrum dostalo blíže a zaútočilo.");
                    }
                break;

            }
        }
    }
}
