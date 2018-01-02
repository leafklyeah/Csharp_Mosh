using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.ExerciseS5L67
{
    class HourSetting
    {
        static void MainHourSetting()
        {

            try
            {
                Console.WriteLine("Please enter a time value in the 24-hour time format (eg. 19:00)");
                var input = Console.ReadLine();
                DateTime time = Convert.ToDateTime(input);
                Console.WriteLine("ok");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Time");
            }
       
        }
    }
}
