using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.TextSummarizing
{
    public class SummarizMethod
    {
        public static string SummarizeMethod(string text, int maxLength=20)
        {
            var totalLength = 0;
            var summarize=new List<string> { };
            if (text.Length <= maxLength)
                return text;

            var words = text.Split(' ');
            foreach(var word in words)
            {
                totalLength += word.Length + 1;
                if (totalLength > maxLength)
                    break;
                summarize.Add(word);
            }

            return String.Join(" ", summarize) + "...";


        }
    }
}
