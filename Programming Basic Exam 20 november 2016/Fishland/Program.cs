using System;

namespace Fishland
{
    public class Program
    {
        public static void Main()
        {
            var skumria = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var palamudKG = double.Parse(Console.ReadLine());
            var safridKG = double.Parse(Console.ReadLine());
            var midiKG = int.Parse(Console.ReadLine());

            var palamudPrice = skumria + skumria * 0.60;
            var palamudSum = palamudPrice * palamudKG;

            var safridPrice = caca + caca * 0.80;
            var safridSum = safridPrice * safridKG;

            var midiSum = midiKG * 7.50;

            var sumAll = palamudSum + safridSum + midiSum;

            Console.WriteLine("{0:f2}", sumAll);
        }
    }
}
