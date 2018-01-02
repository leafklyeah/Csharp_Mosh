using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L48
{
    class Factorial
    {
        static void MainFactorial()
        {
            Console.WriteLine("Please enter a number");
            var number = Convert.ToInt64(Console.ReadLine());
            var i = number;
            double factor = 1;
            while (i > 0)
            {
                factor*= i;
                i--;
            }
            Console.WriteLine("{0}!={1}",number,factor);
        }
    }
}
