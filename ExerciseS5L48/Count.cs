using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L48
{
    class Count
    {
        static void MainCount()
        {
            
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                count+=(i % 3 == 0)? 1 : 0;

            }
            Console.WriteLine(count);
        }
    }
}
