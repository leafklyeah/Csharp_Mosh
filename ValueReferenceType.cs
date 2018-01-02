using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    public class Children
    {
        public int Age;
    }
    class ValueReferenceType
    {
        
        static void MainValueReferenceType()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));  //value type

            var aa = new int[3] { 1, 2, 3 };
            var bb = aa;
            bb[0] = 0;
            Console.WriteLine(string.Format("aa: {0}, bb: {1}", aa[0], bb[0])); //reference type

            string aaa = "aaa";
            string bbb = aaa;
            bbb = "bbb";
            Console.WriteLine(string.Format("aaa: {0}, bbb: {1}", aaa, bbb)); //value type

            var number = 1;
            Increment(number);
            Console.WriteLine(number); //value type

            var child = new Children() { Age = 10 };
            MakeOld(child);
            Console.WriteLine(child.Age); //reference type

        }

        static void Increment(int number)
        {
            number += 1;
        }

        static void MakeOld(Children children)
        {
            children.Age += 10;
        } 
    }
}
