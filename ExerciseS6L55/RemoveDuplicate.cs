using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L55
{
    class RemoveDuplicate
    {
        static void MainRemove()
        {
            var number = new List<int> { };
            while (true)
            {
                Console.WriteLine("Please enter a number");
                var input = Console.ReadLine();
                if (input.ToUpper() == "QUIT")
                    break;
                number.Add( Convert.ToInt32(input));
            }

            var result = number.Distinct();

            foreach(var n in result)
                Console.WriteLine(n);
        }
    }
}
