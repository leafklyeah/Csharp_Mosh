using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.Class.Properties
{
    class PropertiesTutorial
    {
        static void MainProperties()
        {
            var person = new PersonProperties(new DateTime(1990, 6, 1));
            //person.Birthdate = new DateTime(1990, 6, 1);
            Console.WriteLine(person.Age);
        }
    }
}
