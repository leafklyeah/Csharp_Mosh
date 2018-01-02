using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L42
{
    class LandscapePortrait
    {
        static void MainLandscape()
        {
            Console.WriteLine("Please enter the width of image");
            var width = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter the height of image");
            var height = Convert.ToInt64(Console.ReadLine());
            if (height > width)
            {
                Console.WriteLine("The image is portrait");
            }
            else
            {
                Console.WriteLine("The image is landscape");
            }


        }
    }
}
