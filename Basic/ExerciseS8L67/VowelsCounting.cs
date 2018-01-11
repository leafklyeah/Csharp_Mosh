using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L67
{
    class VowelsCounting
    {
        static void MainVowelCounting()
        {
            Console.WriteLine("Please enter a english word");
            var input = Console.ReadLine();
            int i = 0;
            foreach(var l in input)
            {
                if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
                    i++;
            }
            Console.WriteLine(i);
        }
    }
}
