using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class DateTimeTutorial
    {
        static void MainDateTime()
        {
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: "+now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm:ss"));

        

        }
    }
}
