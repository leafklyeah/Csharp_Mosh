using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.Class.AccessModifier
{
    class AccessModifier
    {
        static void MainAccessModifier()
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1990,6,1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
