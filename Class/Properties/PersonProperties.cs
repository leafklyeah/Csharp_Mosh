using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.Class.Properties
{
    public class PersonProperties
    {
        //public DateTime Birthdate { get; set; }
        public DateTime Birthdate { get; private set; } //set will be readonly, and property should be on the top

        public PersonProperties(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
       
        public int Age {   //calculate proptery on the buttom
            get {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 356;
                return years;
            } }
    }
}
