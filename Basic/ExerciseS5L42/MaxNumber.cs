using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L42
{
    class MaxNumber
    {
        static void MainMaxNumber()
        {
            Console.WriteLine("Please enter 1st number");
            var number1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number");
            var number2 = Convert.ToInt64(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("The max value is "+number1);
            }
            else
            {
                Console.WriteLine("The max value is " + number2);

            }

        }
    }
}
