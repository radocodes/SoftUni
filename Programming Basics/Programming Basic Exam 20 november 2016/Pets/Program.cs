using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var allDaysLeft = int.Parse(Console.ReadLine());
            var allFoodKG = int.Parse(Console.ReadLine());
            var dogFoodKG = double.Parse(Console.ReadLine());
            var catFoodKG = double.Parse(Console.ReadLine());
            var turtleFoodGrams = double.Parse(Console.ReadLine());
            var dogFoodNeeded = dogFoodKG * allDaysLeft;
            var catFoodNeeded = catFoodKG * allDaysLeft;
            var turtleFoodNeeded = (1.0 * (turtleFoodGrams * allDaysLeft)) / 1000;
            var foodSumKG = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

            if (allFoodKG >= foodSumKG)
            {
                var diff = allFoodKG - foodSumKG;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(diff));
            }
            else
            {
                var diff = foodSumKG - allFoodKG;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(diff));
            }
        }
    }
}
