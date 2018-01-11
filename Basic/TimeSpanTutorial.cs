using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class TimeSpanTutorial
    {
        static void MainTimeSpan()
        {
            //Creating
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("The duration is "+duration);

            //Properties
            Console.WriteLine("The minite is "+timespan.Minutes);
            Console.WriteLine("The total minutes is "+timespan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: "+timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Substract Example: "+timespan.Subtract(TimeSpan.FromMinutes(2)));

            //Convert
            Console.WriteLine("ToString: "+timespan.ToString());
            Console.WriteLine("Parse: "+TimeSpan.Parse("01:02:03"));
        

        }
    }
}
