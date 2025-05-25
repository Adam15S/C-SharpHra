using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace RPGHra
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monstra = { "Kostlivec", "Zombík", "Upír", "Vlkodlak", "Ghúl", "Drak", "Goblin", "Troll", "Skřet", "Harpyje", "Bazilišek", "Nemrtvý mág", "Duch", "Chiméra", "´Démon", "Ohnivý elementál" };
            string[] monstraObrazek = { "  .-\"      \"-.\r\n /            \\\r\n|              |\r\n|,  .-.  .-.  ,|\r\n| )(_o/  \\o_)( |\r\n|/     /\\     \\|\r\n(_     ^^     _)\r\n \\__|IIIIII|__/\r\n  | \\IIIIII/ |\r\n  \\          /\r\n   `--------`",
            "  .-\"\"\"-.\r\n / -   - \\\r\n|  o _ o  |\r\n|   (_)   |\r\n \\  '='  /\r\n /`-----'\\\r\n/         \\\r\n|         |\r\n\\___)  (___/\r\n",
            "  /^\\\r\n /   \\\r\n| () () |\r\n \\  ^  /\r\n  |||||\r\n  |||||\r\n /_| |_\\\r\n(  U U  )",
            "  /^ ^\\\r\n / 0 0 \\\r\n V\\ Y /V\r\n  / - \\\r\n |    \\\r\n || (__\\",
            "   .-\"      \"-.\r\n  /            \\\r\n |  .----.----. |\r\n | |  ()  () | |\r\n |  \\   ^^   /  |\r\n  \\  '--''--'  /\r\n   '-.______.–'\r\n    /  ||||  \\\r\n   (_/      \\_)",
            "           __====-_  _-====___\r\n   _--^^^#####//      \\\\#####^^^--_\r\n _-^##########// (    ) \\\\##########^-_\r\n-############//  |\\^^/|  \\\\############-\r\n_/###########((   |||||   ))###########\\_\r\n/#############\\\\  |||||  //#############\\\r\n-###############\\\\ ||| //###############-\r\n  -##############\\\\/^\\\\/##############-\r\n   -#############/// \\\\\\#############-\r\n     ^^^^^^^^^^^^     ^^^^^^^^^^^^",
            "   ___\r\n  /   \\\r\n |     |\r\n | o o |  \r\n |  ^  | \r\n | '-' |\r\n  \\___/ \r\n   | | |\r\n   | | |\r\n  /   \\ \r\n /     \\",
            "    _____\r\n   /     \\\r\n  /  o o  \\\r\n /    ^    \\\r\n|    ===    |\r\n|   /   \\   |\r\n \\_________/\r\n   /  |  \\\r\n  /   |   \\\r\n /    |    \\\r\n/_____|_____\\",
            "       ,      ,\r\n      /(.-\"\"-.)\\\r\n  |\\  \\/      \\/  /|\r\n  | \\ / =.  .= \\ / |\r\n  \\( \\   o\\/o   / )/\r\n   \\_, '-/  \\-' ,_/\r\n     /   \\__/   \\\r\n     \\ \\__/\\__/ /\r\n   ___\\ \\|--|/ /___\r\n /`    \\      /    `\\\r\n/       '----'       \\",
            "        ,     ,\r\n       (\\____/)\r\n        (_oo_)\r\n  .-.__/      \\___.-.\r\n (   |  |\\/\\/|  |   )\r\n  \\__/  ||  ||  \\__/\r\n    |   ||  ||   |\r\n    \\  _||_ ||_  /\r\n     \\____)|(___/\r\n     /    /  \\   \\\r\n    (_/\\/     \\/\\/)\r\n     /           \\",
            "           /^\\/^\\\r\n         _|__|  O|\r\n\\/     /~     \\_/ \\\r\n \\____|__________/  \\\r\n        \\_______      \\\r\n                `\\     \\                 \\\r\n                  |     |                  \\\r\n                 /      /                    \\\r\n                /     /                       \\\\\r\n              /      /                         \\ \\\r\n             /     /                            \\  \\\r\n           /     /             _----_            \\   \\\r\n          /     /           _-~      ~-_         |   |\r\n         (      (        _-~    _--_    ~-_     _/   |\r\n          \\      ~-____-~    _-~    ~-_    ~-_-~    /\r\n            ~-_           _-~          ~-_       _-~\r\n               ~--______-~                ~-___-~",
            "           _____\r\n         /      \\ \r\n        |  () () | \r\n         \\   ^   / \r\n          ||||| |\r\n        __|||||_|__\r\n      /   /     \\   \\\r\n     /___|       |___\\\r\n      |  |       |  |\r\n      |  |_______|  |\r\n     /__/       \\__\\\r\n    /  /|       |\\  \\\r\n   /__/ |_______| \\__\\\r\n       (__)   (__)",
            "        .------.\r\n      .'        `.\r\n     /     __     \\\r\n    |    .'__`.    |\r\n    |   /::::::\\   |\r\n    |   \\::::::/   |\r\n    |    `'--'`    |\r\n    |             ||\r\n    |   _______   ||\r\n    |  /       \\  ||\r\n    | |         | ||\r\n    | |         | ||\r\n    |_|_________|_||\r\n   /_|_|_|_|_|_|_|_\\\r\n     ||         ||\r\n     ||         ||\r\n     ()         ()",
            "           ___====-_  _-====___\r\n       _--^^^#####//      \\\\#####^^^--_\r\n    _-^##########// (    ) \\\\##########^-_\r\n   -############//  |\\^^/|  \\\\############-\r\n _/############//   (@::@)   \\\\############\\_\r\n/#############((     \\\\//     ))#############\\\r\n-###############\\\\    (oo)    //###############-\r\n-#################\\\\  / U \\  //#################-\r\n-###################\\\\/  ^  \\//###################-\r\n_#/|##########/\\######(  (_)  )######/\\##########|\\#_\r\n |/ |#/\\#/\\#/\\/  \\#/\\##\\  |  |  /##/\\#/  \\/\\#/\\#/\\#| \\|\r\n `  |/  V  V  `   V  \\#\\| |  | |/#/  V   '  V  V  \\|  '\r\n    `   `  `      `   / | |  | | \\   '      '  '   '\r\n                     (  | |  | |  )\r\n                    __\\ | |  | | /__\r\n                   (vvv(VVV)(VVV)vvv)",
            "           / \\  //\\\r\n     |\\___/|      \\\r\n     /0  0  \\      |\r\n    (    ^   )     |\r\n     \\__=__/     / |\r\n      /     \\   |  |\r\n     |     |   /  /\r\n    /| | | |\\_/  /\r\n   /_|_|_|_|/  /\r\n  /__|_|_|_|  (\r\n /_/        \\  \\\r\n(_|  |___|  |_) \\\r\n   \\_______/    )\r\n    |_||_|     /\r\n   (___||___)='\r\n     |  ||  |\r\n     |  ||  |\r\n    (__)(__)",
            "       (     )\r\n      (       )\r\n     (         )      )  )\r\n      |       |     (  (  (\r\n      |       |     )  )  )\r\n     /|  .-.  |\\   (  (  (\r\n    / | (   ) | \\   )  )  )\r\n   /  |  '-'  |  \\  (  (  (\r\n  /   |       |   \\  )  )  )\r\n /    |       |    \\ (  (  (\r\n/     |       |     )  )  )\r\n      /       \\\r\n     /         \\\r\n    (___________)\r\n        |  |\r\n        |  |\r\n        |  |\r\n       /    \\\r\n      (      )\r\n       `----'"};
            int[] monstraHP = { 40, 35, 50, 30, 45, 65, 35, 70, 40, 50, 55, 45, 35, 55, 45, 60 };
            int[] monstraDMG = { 9, 8, 13, 10, 11, 12, 9, 7, 8, 10, 14, 12, 11, 12, 13, 12 };
            string[] miniBoss = { "behemot", "archidémon" };
            int[] miniBossHP = { 80, 70 };
            int[] miniBossDMG = { 15, 17 };
            string[] postavy = { "Tharion", "Morgha", "Korvak", "Nyssara" };
            int[] postavyMaxHP = { 50, 50, 55, 60 };
            int[] postavyHP = { 50, 45, 35, 50 };
            int[] maxMana = { 40, 45, 35, 50 };
            int[] mana = { 25, 30, 35, 35 };
            int[] mince = { 45, 40, 60, 60 };
            int[] utok = { 31, 30, 21, 11};
            string boss = "Plaguevile";
            int bossHP = 90, bossDMG = 20;

            int aktualniHP = 0, aktualniMana = 0, aktualniMince = 0, aktualniLevel = 1, aktualniZkusenosti = 0, aktualniUtok = 0;

            int volbaPostavy, vesniceVyber, vylosovaneMonstrum;
            char potvrzeniVyberu;
            bool spravneZadani = false, zmenaPostavy = false, potvrdit = false, znovu = true;

            Dictionary<string, string> miniBossDefinice = new Dictionary<string, string>();
            miniBossDefinice.Add(miniBoss[0], "obrovská, nezastavitelná bestie");
            miniBossDefinice.Add(miniBoss[1], "vládce démonů a černé magie");

            Vypisovac vypisovac = new Vypisovac();
            Vesnice vesnice = new Vesnice();
            Losovac losovac = new Losovac();
            Boj boj = new Boj();

            Console.WriteLine("Vítejte ve hře");
            Console.WriteLine(" __      __                             .__                ");
            Console.WriteLine("/  \\    /  \\_____ _______  ____________ |__|______   ____ ");
            Console.WriteLine("\\   \\/\\/   /\\__  \\\\_  __ \\/  ___/\\____ \\|  \\_  __ \\_/ __ \\ ");
            Console.WriteLine(" \\        /  / __ \\|  | \\/\\___ \\ |  |_> >  ||  | \\/\\  ___/ ");
            Console.WriteLine("  \\__/\\  /  (____  /__|  /____  >|   __/|__||__|    \\___  >");
            Console.WriteLine("       \\/        \\/           \\/ |__|                   \\/ \n\n");

            Console.WriteLine("Seznam postav:");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i + " - " + postavy[i - 1]);
            }

            do
            {
                Console.WriteLine("\nVyberte vaši postavu: ");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out volbaPostavy))
                        Console.WriteLine("Neplatné zadání, zadejte číslo vaší postavy: ");
                    if (volbaPostavy < 1 || volbaPostavy > 4)
                    {
                        Console.WriteLine("Vyberte pouze čísla postav z nabídky: ");
                        spravneZadani = false;
                    }
                    else
                    {
                        spravneZadani = true;
                    }
                } while (spravneZadani == false);

                vypisovac.VypisPostavu(volbaPostavy, postavy, postavyMaxHP, postavyHP, maxMana, mana, mince, utok);
                Console.WriteLine("\nChcete si zvolit tuto postavu? [P - potvrdit, Z - změnit]");
                do
                {
                    while (!char.TryParse(Console.ReadLine(), out potvrzeniVyberu))
                        Console.WriteLine("Neplatné zadání, zadejte písmeno P nebo Z: ");
                    if (potvrzeniVyberu == 'P' || potvrzeniVyberu == 'p')
                    {
                        potvrdit = true;
                        zmenaPostavy = false;
                    }
                    else if (potvrzeniVyberu == 'Z' || potvrzeniVyberu == 'z')
                    {
                        potvrdit = true;
                        zmenaPostavy = true;
                    }
                    else
                    {
                        Console.WriteLine("Neplatné zadání, zadejte písmeno P nebo  Z: ");
                        potvrdit = false;
                    }
                } while (potvrdit != true);
            } while (zmenaPostavy == true);

            Console.Write("\nNačítání");
            aktualniHP = postavyHP[volbaPostavy - 1];
            aktualniMana = mana[volbaPostavy - 1];
            aktualniMince = mince[volbaPostavy - 1];
            aktualniUtok = utok[volbaPostavy - 1];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Ve stínu hor stojí Warspire — vesnice na pokraji zkázy.");
            Thread.Sleep(4000);
            Console.WriteLine("Staré legendy ožívají a temnota se blíží.");
            Thread.Sleep(3000);
            Console.WriteLine("Jsi poslední nadějí porazit nepřítele.");
            Thread.Sleep(3000);
            Console.WriteLine("Tvá cesta na záchranu vesnice Warspire začíná...");
            Console.WriteLine("\n[Stiskněte klávesu ENTER pro pokračování.]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Tvoje cesta začíná v tvé rodné vesnici — Grimharrow.\n");
            Console.WriteLine("                     ^  ^  ^       @@@\r\n                   /|\\/|\\/|\\     @@@@@@@\r\n                  /_|__|__|_\\     @@@\r\n                 |  _     _  |     |\r\n                 | | |   | | |    / \\\r\n                 |_|_|___|_|_|   /___\\\r\n                /    (_)    \\    | | |\r\n               /  []     []  \\   |_|_|\r\n              |     ___      |  /=====\\\r\n              |    /___\\     |  |     |\r\n         ___  |______________|__|     |__\r\n        /   \\ |  _______  | |  |     |  \\\r\n       |     || |       | | |  |     |   |\r\n   ~ ~ |  [] || |       | | |  |     |   | ~ ~\r\n  ~ ~ ~|_____|_\\|_______|_|_|__|_____|___| ~ ~");
            Thread.Sleep(4000);
            Console.WriteLine("\nZde jsi momenálně v bezpečí, ale ne nadlouho.");
            Thread.Sleep(3000);
            Console.WriteLine("Vesnice jsou místem, kde můžeš vylepšit své schopnosti.");
            Thread.Sleep(3000);
            Console.WriteLine("Warspire tě ale čeká, tak nezahálej dlouho!");

            do
            {
                Console.WriteLine("\n[Možnosti vesnice:]");
                Console.WriteLine("[-----------------]");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[1 - Doplnit životy (dostupné po prvním boji)]");
                Console.ResetColor();
                Console.WriteLine("[2 - Vylepšit maximální životy]");
                Console.WriteLine("[3 - Vylepšit maximální manu]");
                Console.WriteLine("[4 - Vylepšit útok]");
                Console.WriteLine("[5 - Opustit vesnici]");
                do
                {
                    while (!int.TryParse(Console.ReadLine(), out vesniceVyber))
                        Console.WriteLine("Neplatné zadání, zadejte číslo dle výběru: ");
                    if (vesniceVyber < 1 || vesniceVyber > 4)
                    {
                        Console.WriteLine("Vyberte pouze čísla postav z nabídky: ");
                        spravneZadani = false;
                    }
                    if (vesniceVyber == 1)
                    {
                        Console.WriteLine("První volba není dostupná, vyberte jinou:");
                        spravneZadani = false;
                    }
                    else
                    {
                        spravneZadani = true;
                    }
                } while (spravneZadani == false);

                znovu = true;

                switch (vesniceVyber)
                {
                    case 2:
                        do
                        {
                            Console.WriteLine("Vylepšení maximálních životů vás bude stát 20 mincí a bude vylepšeno o 5 HP. Chcete pokračovat? [A/N]");
                            while (!char.TryParse(Console.ReadLine(), out potvrzeniVyberu))
                                Console.WriteLine("Neplatné zadání, zadejte číslo dle výběru: ");
                            if (potvrzeniVyberu == 'A' || potvrzeniVyberu == 'N' || potvrzeniVyberu == 'a' || potvrzeniVyberu == 'n')
                            {
                                spravneZadani = true;
                            }
                            else
                            {
                                Console.WriteLine("Zadejte písmeno A nebo N pro pokračování:");
                                spravneZadani = false;
                            }
                        } while (spravneZadani == false);
                        if (potvrzeniVyberu == 'N' || potvrzeniVyberu == 'n')
                        {
                            break;
                        }
                        vesnice.VylepsitZivoty(ref postavyMaxHP, ref aktualniMince, volbaPostavy, ref znovu);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Vylepšení maximální many vás bude stát 30 mincí a bude vylepšeno o 5. Chcete pokračovat? [A/N]");
                            while (!char.TryParse(Console.ReadLine(), out potvrzeniVyberu))
                                Console.WriteLine("Neplatné zadání, zadejte číslo dle výběru: ");
                            if (potvrzeniVyberu == 'A' || potvrzeniVyberu == 'N' || potvrzeniVyberu == 'a' || potvrzeniVyberu == 'n')
                            {
                                spravneZadani = true;
                            }
                            else
                            {
                                Console.WriteLine("Zadejte písmeno A nebo N pro pokračování:");
                                spravneZadani = false;
                            }
                        } while (spravneZadani == false);
                        if (potvrzeniVyberu == 'N' || potvrzeniVyberu == 'n')
                        {
                            break;
                        }
                        vesnice.VylepsitManu(ref maxMana, ref aktualniHP, ref aktualniMince, volbaPostavy, ref znovu);
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Vylepšení útoku vás bude stát 35 mincí a bude vylepšeno o 10 DMG. Chcete pokračovat? [A/N]");
                            while (!char.TryParse(Console.ReadLine(), out potvrzeniVyberu))
                                Console.WriteLine("Neplatné zadání, zadejte číslo dle výběru: ");
                            if (potvrzeniVyberu == 'A' || potvrzeniVyberu == 'N' || potvrzeniVyberu == 'a' || potvrzeniVyberu == 'n')
                            {
                                spravneZadani = true;
                            }
                            else
                            {
                                Console.WriteLine("Zadejte písmeno A nebo N pro pokračování:");
                                spravneZadani = false;
                            }
                        } while (spravneZadani == false);
                        if (potvrzeniVyberu == 'N' || potvrzeniVyberu == 'n')
                        {
                            break;
                        }
                        vesnice.VylepsitUtok(ref utok, ref aktualniMince, volbaPostavy, ref znovu);
                        break;
                    case 5:
                        znovu = false;
                        break;
                    default:
                        znovu = true;
                        break;
                }
            } while (znovu == true);

            vylosovaneMonstrum = losovac.VylosovatMonstrum();

            Console.Clear();
            Console.WriteLine("S prvním světlem opouštíš Grimharrow.");
            Thread.Sleep(2000);
            Console.WriteLine("Cesty jsou tiché, až příliš.");
            Thread.Sleep(2000);
            Console.WriteLine("Jen pár kroků za starou hranicí narazíš na to, co místní jen šeptem nazývali...");
            Thread.Sleep(4000);
            Console.WriteLine(monstraObrazek[vylosovaneMonstrum]);
            Console.WriteLine(monstra[vylosovaneMonstrum] + ".");
            Thread.Sleep(2000);
            Console.WriteLine("Je to tvůj první boj.");
            Thread.Sleep(2000);
            Console.WriteLine("Jsi připraven?");
            Console.WriteLine("\n[Stiskněte klávesu ENTER pro pokračování.]");
            Console.ReadLine();
            Console.Clear();
            boj.BojujSMonstrem();


            /***
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Doplnění životů vás bude stát 20 mincí a bude doplněno 10 HP. Chcete pokračovat? [A/N]");
                        while (!char.TryParse(Console.ReadLine(), out potvrzeniVyberu))
                            Console.WriteLine("Neplatné zadání, zadejte číslo dle výběru: ");
                        if (potvrzeniVyberu == 'A' || potvrzeniVyberu == 'N' || potvrzeniVyberu == 'a' || potvrzeniVyberu == 'n')
                        {
                            spravneZadani = true;
                        }
                        else
                        {
                            Console.WriteLine("Zadejte písmeno A nebo N pro pokračování:");
                            spravneZadani = false;
                        }
                    } while (spravneZadani == false);
                    if (potvrzeniVyberu == 'N' || potvrzeniVyberu == 'n')
                    {
                        break;
                    }
                    vesnice.DoplnitZivoty(aktualniHP, postavyMaxHP, aktualniMince, volbaPostavy);
                    break;
            }
            ***/
        }
    }
}
