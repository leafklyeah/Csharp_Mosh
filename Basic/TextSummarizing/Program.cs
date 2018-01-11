using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Mosh.TextSummarizing;

namespace Csharp_Mosh.TextSummarizing
{
    class Program
    {
        static void MainText()
        {
            var sentence = "This is going to be a really really really really really long word";
            var result=SummarizMethod.SummarizeMethod(sentence,30);
            Console.WriteLine(result);
        }
    }

}
