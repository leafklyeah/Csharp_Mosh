using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L48
{
    class Sum
    {
        static void MainSum()
        {
            long sum = 0;
            string number;
            do
            {
                Console.WriteLine("Please enter the number");
                number = Console.ReadLine();
                if (number == "ok")
                    break;
                sum += Convert.ToInt64(number);
            }
            while (number != "ok");
           
            Console.WriteLine(sum);
        }
    }
}
