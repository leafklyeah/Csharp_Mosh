using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class ArrayTutorial
    {
        static void MainArray()
        {
            //length
            var number = new int[] { 2, 3, 9, 4, 1 };
            Console.WriteLine("The length is "+number.Length);

            //indexof
            var index = Array.IndexOf(number, 9);
            Console.WriteLine("The index of 9 is: "+index);

            //clear
            Array.Clear(number, 0, 2);
            Console.WriteLine("effect of clear");
            foreach(var n in number)
                Console.WriteLine(n);

            //copy
            int[]another = new int[3];
            Array.Copy(number, another, 3);
            Console.WriteLine("effect of copy");
            foreach(var n in another)
                Console.WriteLine(n);

            //sort
            Array.Sort(number);
            Console.WriteLine("Effect of sort");
            foreach(var n in number)
                Console.WriteLine(n);

            //reverse
            Array.Reverse(number);
            Console.WriteLine("Effecr of reverse");
            foreach(var n in number)
                Console.WriteLine(n);


        
            

        }
    }
}
