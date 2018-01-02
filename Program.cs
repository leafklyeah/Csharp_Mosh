using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Mosh.Math; //for using calculator class, coz it is in the Math folder

namespace Csharp_Mosh
{
    class Program
    {
        
        static void TryMain(string[] args)
        {
            try
            {
            
                var number = "1234";
                //byte a = Convert.ToByte(number);
                int a = Convert.ToInt32(number);
                Console.WriteLine(a);

                var person = new Person();
                person.firstName = "Karen";
                person.lastName = "Zhang";
                person.Introduction();

                var result = Calculator.Add(1, 2);
                Console.WriteLine(result);

                var names = new string[3] { "Jack", "Karen", "Valerie"};
                var numbers = new int[3];

                numbers[0] = 0;
                numbers[1] = 1;
                numbers[2] = 2;


                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                string namestring = string.Join(",", names);
                Console.WriteLine(namestring);


            }
            catch (Exception)
            {

                Console.WriteLine("The number can't be converted");
            }
        }
    }
}
