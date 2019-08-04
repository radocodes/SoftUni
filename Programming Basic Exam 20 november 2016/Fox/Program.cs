using System;

namespace Fox
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var asterix1 = 1;
            var middlePartUp = (2 * n + 3) - 4;
            var asterix2Left = ((2 * n + 3) - n - 4) / 2;
            var middlePartinMiddle = n;
            var line1 = 1;
            var middlePartDown = (2 * n + 3) - 4;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('*', asterix1));
                Console.Write("\\");
                Console.Write(new string('-', middlePartUp));
                Console.Write("/");
                Console.Write(new string('*', asterix1));

                asterix1++;
                middlePartUp = middlePartUp - 2;
                Console.WriteLine();
            }

            for (int row = 1; row <= n / 3; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', asterix2Left));
                Console.Write("\\");
                Console.Write(new string('*', middlePartinMiddle));
                Console.Write("/");
                Console.Write(new string('*', asterix2Left));
                Console.Write("|");

                asterix2Left++;
                middlePartinMiddle = middlePartinMiddle - 2;
                Console.WriteLine();
            }

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('-', line1));
                Console.Write("\\");
                Console.Write(new string('*', middlePartDown));
                Console.Write("/");
                Console.Write(new string('-', line1));

                line1++;
                middlePartDown = middlePartDown - 2;
                Console.WriteLine();
            }
        }
    }
}
