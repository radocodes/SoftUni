using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numPokemons1player = int.Parse(Console.ReadLine());
            var numPokemons2player = int.Parse(Console.ReadLine());
            var maxNumBattles = int.Parse(Console.ReadLine());
            int countBattles = 0;
            var brkBig = 0;
            for (int pokemon1 = 1; pokemon1 <= numPokemons1player; pokemon1++)
            {
                if (brkBig == 1)
                {
                    break;
                }
                for (int pokemon2 = 1; pokemon2 <= numPokemons2player; pokemon2++)
                {
                    countBattles += 1;
                    Console.Write("({0} <-> {1}) ", pokemon1, pokemon2);
                    if (countBattles == maxNumBattles)
                    {
                        brkBig = 1;
                        break;
                    }
                }
            }
        }
    }
}
