using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Mosh.Class.Constructor;

namespace Csharp_Mosh.Class
{
    class ConstructorTutorial
    {
        static void MainFields()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promotion(); //this method re-initailize the order list, so the data lost and count will change to 0
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
