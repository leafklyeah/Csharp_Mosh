using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Mosh.Class.Indexer
{
    class IndexerTutorial
    {
        static void MainIndexer()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Karen";
            Console.WriteLine(cookie["name"]);
        }
    }
}
