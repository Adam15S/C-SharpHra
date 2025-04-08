namespace RPGHra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monstra = { "kostlivec", "zombík", "upír", "vlkodlak", "ghúl", "drak", "goblin", "troll", "skřet", "harpyje", "bazilišek", "nemrtvý mág", "duch", "chiméra", "démon", "ohnivý elementál" };
            string[] miniBoss = { "behemot", "archidémon" };
            Dictionary<string, string> miniBossDefinice = new Dictionary<string, string>();
            miniBossDefinice.Add(miniBoss[0], "obrovská, nezastavitelná bestie");
            miniBossDefinice.Add(miniBoss[1], "vládce démonů a černé magie");
            int[] monstraHP = { 40, 35, 50, 30, 45, 65, 35, 70, 40, 50, 55, 45, 35, 55, 45, 60 };
            int[] monstraDMG = { 9, 8, 13, 10, 11, 12, 9, 7, 8, 10, 14, 12, 11, 12, 13, 12 };
            int[] miniBossHP = { 80, 70 };
            int[] miniBossDMG = { 15, 17 };
            string boss = "Plaguevile";
            int bossHP = 90, bossDMG = 20;
        }
    }
}
