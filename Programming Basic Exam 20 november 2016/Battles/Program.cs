using System;

namespace Battles
{
    public class Program
    {
        public static void Main()
        {
            var numPokemonsFirstPlayer = int.Parse(Console.ReadLine());
            var numPokemonsSecondPlayer = int.Parse(Console.ReadLine());
            var maxBattlesCountConstraint = int.Parse(Console.ReadLine());
            int battlesCount = 0;
            var end = false;

            for (int firstPlayerPokemon = 0; firstPlayerPokemon < numPokemonsFirstPlayer; firstPlayerPokemon++)
            {
                if (end == true)
                {
                    break;
                }

                for (int SecondPlayerPokemon = 0; SecondPlayerPokemon < numPokemonsSecondPlayer; SecondPlayerPokemon++)
                {
                    battlesCount += 1;

                    Console.Write("({0} <-> {1}) ", firstPlayerPokemon, SecondPlayerPokemon);

                    if (battlesCount == maxBattlesCountConstraint)
                    {
                        end = true;
                        break;
                    }
                }
            }
        }
    }
}
