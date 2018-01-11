using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class IfElseSwitchCase
    {
        static void MainIfElse()
        {
            bool isGoldenCustomer = false;
            float price = (isGoldenCustomer) ? 12.99f : 29.99f;
            Console.WriteLine(price);
        }
    }
}
