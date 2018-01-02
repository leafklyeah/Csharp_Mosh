using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class ForLoop
    {
        static void MainForLoop()
        {
            var name = "Karen Zhang";
            var numbers = new int[] { 1, 2, 3, 4 };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach(var charactor in name)
            //{
            //    Console.WriteLine(charactor);
                
            //}

            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
