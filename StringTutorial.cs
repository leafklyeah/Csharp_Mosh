using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class StringTutorial
    {
        static void MainString()
        {
            //trim
            var fullname = "Karen Zhang ";
            Console.WriteLine("The Trim: "+fullname.Trim());
            Console.WriteLine("The Upper: " + fullname.Trim().ToUpper());

            //Indexof, substring
            var index = fullname.IndexOf(' ');
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index + 1);
            Console.WriteLine("My Firstname is "+firstname);
            Console.WriteLine("My Lastname is "+lastname);

            //Spliy
            var name = fullname.Split(' ');
            Console.WriteLine("My Firstname is " + name[0]);
            Console.WriteLine("My Firstname is " + name[1]);

            //Replace
            Console.WriteLine(fullname.Replace("Karen", "Ye") );
            Console.WriteLine(fullname.Replace(" ", ""));

            //isnullorempty
            if(string.IsNullOrEmpty(null))
                Console.WriteLine("invalid");

            //convert
            var str = "25";
            var strnumber = Convert.ToInt32(str);

            var strstr = strnumber.ToString("C");
            Console.WriteLine(strstr);
            

        }
    }
}
