using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L55
{
    class SmallestNumber
    {
        static void MainSmallest()
        {
            Console.WriteLine("Please enter a list of comma seperated number");
            var input = Console.ReadLine();
            var number = input.Split(',').Select(s => int.Parse(s)).ToList();
            while (number.Count < 5)
            {
                Console.WriteLine("The number is empty or less than 5 units, please retry");
                input = Console.ReadLine();
                number = input.Split(',').Select(s => int.Parse(s)).ToList();
            }

            number.Sort();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
