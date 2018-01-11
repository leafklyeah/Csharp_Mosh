using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh
{
    class StringBuilderTutorial
    {
        static void MainStringBuilder()
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10)
                   .Replace('-', '+')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("The first chat is "+builder[0]);
        }
    }
}
