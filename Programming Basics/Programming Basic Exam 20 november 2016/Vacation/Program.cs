using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldPeople = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transportKind = Console.ReadLine();
            var oldPeopleSum = 0.0;
            var studentsSum = 0.0;
            var transportSum = 0.0;
            switch (transportKind)
            {
                case "train":
                     oldPeopleSum = oldPeople * 24.99;
                     studentsSum = students * 14.99;
                    transportSum = (oldPeopleSum + studentsSum) * 2;
                    if (oldPeople + students >= 50)
                    {
                        transportSum = transportSum / 2;
                    }
                    break;
                case "bus":
                    oldPeopleSum = oldPeople * 32.50;
                    studentsSum = students * 28.50;
                    transportSum = (oldPeopleSum + studentsSum) * 2;
                    break;
                case "boat":
                    oldPeopleSum = oldPeople * 42.99;
                    studentsSum = students * 39.99;
                    transportSum = (oldPeopleSum + studentsSum) * 2;
                    break;
                case "airplane":
                    oldPeopleSum = oldPeople * 70.00;
                    studentsSum = students * 50.00;
                    transportSum = (oldPeopleSum + studentsSum) * 2;
                    break;
            }
            var hotel = nights * 82.99;
            var commission = (transportSum + hotel) * 0.10;
            var allSum = transportSum + hotel + commission;

            Console.WriteLine("{0:f2}", allSum);
        }
    }
}
