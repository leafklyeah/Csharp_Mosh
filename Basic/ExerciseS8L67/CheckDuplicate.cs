using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L67
{
    class CheckDuplicate
    {
        static void MainDuplicate()
        {
            Console.WriteLine("Please enter a series of number seperated by hyphen");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Environment.Exit(0);
            }

            var number = input.Split('-');
            var numberList = new List<int> { };
            foreach (var n in number)
                numberList.Add(Convert.ToInt32(n));
            for (int i = 0; i < numberList.Count; i++)
            {
                for (int j = i+1; j < numberList.Count; j++)
                {
                    if (numberList[i] == numberList[j])
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }

                }

            }
        }
    }
}

