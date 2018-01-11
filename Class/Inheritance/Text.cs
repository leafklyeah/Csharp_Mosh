using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.Class.Inheritance
{
    public class Text:Presentation
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperLink(string url)
        {
            Console.WriteLine("The added link is "+url);
        }
    }

}
