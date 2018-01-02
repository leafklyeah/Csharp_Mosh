using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L48
{
    class randomNumberGuess
    {
        static void Mainrandom()
        {
            var random = new Random();
            var key = random.Next(1, 10);
            Console.WriteLine(key);
            for(int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Please guess a number from 1 to 10");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == key)
                {
                    Console.WriteLine("You won");
                    break;
                }
                Console.WriteLine("You lost");
            }
        }
    }
}
