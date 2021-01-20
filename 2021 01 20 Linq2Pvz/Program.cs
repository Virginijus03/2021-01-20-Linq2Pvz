using System;
using System.Collections.Generic;
using System.Linq;

namespace _2021_01_20_Linq2Pvz
{
    class Program
    {
        static List<string> miestai = new List<string> { "Vilnius", "Alytus", "Kaunas", "Klaipeda" };
        static List<int> skaiciai = new List<int> { 3, 5, 7, 8, 10, };

        static void Main(string[] args)
        {
            Console.WriteLine("miestas{0}", string.Join(", ", miestai.Where(m => m.StartsWith("K"))));

            Console.WriteLine("Ar yra miestas Kaunas? {0}", miestai.Any(m => m == "Kaunas") ? "Taip" : "Ne");

            Console.WriteLine("Ar yra miestas Utena? {0}", miestai.Any(m => m == "Utena") ? "Taip" : "Ne");

            var surusiuotiMiestasNuoAIkiZ = miestai.OrderBy(z => z);

            Console.WriteLine("Surusiuoti miestai {0}", string.Join(",", miestai.OrderBy(z => z)));

            Console.WriteLine("Skaiciai suma{0}", skaiciai.Sum());

            Console.WriteLine("Skaiciai minimali reiksme{0}", skaiciai.Min());

            Console.WriteLine("Skaiciai maksimali reiksme{0}", skaiciai.Max());


        }
    }
}
