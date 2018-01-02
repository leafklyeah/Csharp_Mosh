using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L55
{
    class reverseName
    {
        static void MainReverse()
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            var nameChar = name.ToCharArray();
            Array.Reverse(nameChar);
            foreach(var c in nameChar)
                Console.Write(c);
            Console.WriteLine();
        }
    }
}
