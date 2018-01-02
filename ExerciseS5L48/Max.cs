using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L48
{
    class Max
    {
        static void MainMax()
        {
            Console.WriteLine("Please enter a series of number seperated by comma");
            var result = Console.ReadLine();
            int[] series = result.Split(',').Select(str => int.Parse(str)).ToArray();
            Console.WriteLine(series.Max());

        }
    }
}
