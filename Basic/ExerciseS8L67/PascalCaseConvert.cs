using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L67
{
    class PascalCaseConvert
    {
        static void MainPascal()
        {
            Console.WriteLine("Please enter a few words separated by a space");
            var input = Console.ReadLine();
            var words = input.Split(' ');
            var pascalCase = new List<string> { };

            foreach (var n in words)
            {
                var firstChar = n.Substring(0, 1).ToUpper();
                var leftChar = n.Substring(1).ToLower();
                pascalCase.Add(firstChar + leftChar);
            }
            foreach (var p in pascalCase)
                Console.Write(p);
            Console.WriteLine();
        }
    }
}
