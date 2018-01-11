using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L55
{
    class FacebookName
    {
        static void MainFacebook()
        {
            var name = new List<string> { };
            string input;
            while(true)
            {
                Console.WriteLine("Please enter the name who like your post");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                name.Add(input);

            };

            switch (name.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} like your post", name[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", name[0], name[1]);
                    break;
                default:
                    Console.WriteLine("{0},{1} and {2} others like your post", name[0], name[1], name.Count-2);
                    break;

            }


        }
    }
}
