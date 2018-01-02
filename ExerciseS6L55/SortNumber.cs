using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L55
{
    class SortNumber
    {
        static void MainSort()
        {
            var numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a unique numbers below");
                int n= Convert.ToInt32(Console.ReadLine());
                while (Array.IndexOf(numbers, n) >= 0)
                {
                    Console.WriteLine("This number has been input, please retry");
                    n = Convert.ToInt32(Console.ReadLine());
                };
                numbers[i] = n;
            }

            Array.Sort(numbers);
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}
