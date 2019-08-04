using System;

namespace SoftUni_Camp
{
    public class Program
    {
        public static void Main()
        {
            var numberOfGroups = int.Parse(Console.ReadLine());
            var car = 0.0;
            var microbus = 0.0;
            var smallBus = 0.0;
            var BigBus = 0.0;
            var train = 0.0;
            var allPeople = 0.0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                var membersInGroup = int.Parse(Console.ReadLine());

                if (membersInGroup < 6)
                {
                    car += membersInGroup;
                }

                else if (membersInGroup > 5 && membersInGroup < 13)
                {
                    microbus += membersInGroup;
                }

                else if (membersInGroup > 12 && membersInGroup < 26)
                {
                    smallBus += membersInGroup;
                }

                else if (membersInGroup > 25 && membersInGroup < 41)
                {
                    BigBus += membersInGroup;
                }

                else if (membersInGroup > 40)
                {
                    train += membersInGroup;
                }

                allPeople += membersInGroup;
            }

            car = car / allPeople * 100;
            microbus = microbus / allPeople * 100;
            smallBus = smallBus / allPeople * 100;
            BigBus = BigBus / allPeople * 100;
            train = train / allPeople * 100;

            Console.WriteLine("{0:F2}%", car);
            Console.WriteLine("{0:F2}%", microbus);
            Console.WriteLine("{0:F2}%", smallBus);
            Console.WriteLine("{0:F2}%", BigBus);
            Console.WriteLine("{0:F2}%", train);
        }
    }
}
