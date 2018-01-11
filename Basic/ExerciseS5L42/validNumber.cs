using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class validNumber
    {
        static void MainValidNumber()
        {
            try
            {
                Console.WriteLine("Please enter the number between 1 to 10");
                var number = Convert.ToInt32(Console.ReadLine());
                if(number<=10 && number >= 1)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }


        }
            catch (Exception)
            {

                Console.WriteLine("Invalid");

            }

}
    }
}
