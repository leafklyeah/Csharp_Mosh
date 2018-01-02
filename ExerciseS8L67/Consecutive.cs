using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L67
{
    class Consecutive
    {
        static void MainConsecutive()
        {
            Console.WriteLine("Please enter a list of number seperated by hyphen");
            var input = Console.ReadLine();
            var number = input.Split('-');
            var numberList = new List<int> { };
            foreach (var n in number)
                numberList.Add(Convert.ToInt32(n));

            numberList.Sort();
            bool result = true;
            for (int i = 1; i < numberList.Count; i++)
            {
                if (numberList[i-1] != numberList[i]-1)
                {
                    Console.WriteLine("Not Consecutive");
                    result = false;
                    break;
                }

            }
            if (result)
            {
                Console.WriteLine("Conseutive");
            }
        }
    }
}

   
