using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
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
