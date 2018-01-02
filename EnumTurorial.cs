using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisterAirMail=2,
        Express=3
    }

    class EnumTutorial
    {
        static void MainEnumTutorial()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(Convert.ToInt32(method));

            var methodId = 1;
            Console.WriteLine((ShippingMethod)methodId);

            var methodName = "string";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
