using System.Runtime.InteropServices;

namespace RPGHra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monstra = { "kostlivec", "zombík", "upír", "vlkodlak", "ghúl", "drak", "goblin", "troll", "skřet", "harpyje", "bazilišek", "nemrtvý mág", "duch", "chiméra", "démon", "ohnivý elementál" };
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

            int volbaPostavy;
            bool spravneZadani;

            Dictionary<string, string> miniBossDefinice = new Dictionary<string, string>();
            miniBossDefinice.Add(miniBoss[0], "obrovská, nezastavitelná bestie");
            miniBossDefinice.Add(miniBoss[1], "vládce démonů a černé magie");

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
        }
    }
}
