using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L42
{
    class Capturespeed
    {
        static void MainCaptureSpeed()
        {
            Console.WriteLine("Please enter the speed limit");
            var speedlimit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter the car speed");
            var carspeed = Convert.ToInt64(Console.ReadLine());
            long dermeritPoint= (carspeed - speedlimit) / 5;
            if (carspeed <= speedlimit)
            {
                Console.WriteLine("ok!");
            }
            else if(dermeritPoint<=12){
                Console.WriteLine("The dermerit point is "+dermeritPoint);
            }
            else
            {
                Console.WriteLine("The license suspended");
            }


            }
        }
    }

