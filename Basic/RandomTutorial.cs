using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class RandomTutorial
    {
        static void MainRandomTutorial()
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(random.Next(1, 10));
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
                Console.Write((char)random.Next(97, 122));  //random character
            Console.WriteLine();

            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a'+random.Next(0, 26));  //same to above method
            var password = new string(buffer);
            Console.WriteLine(password);





        }
    }
}
