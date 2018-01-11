using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp_Mosh
{
    class PathTutorial
    {
        static void MainPath()
        {
            var path = @"C:\Users\KarenZhang\Downloads\test1.txt";
            Console.WriteLine("The path extension: "+ Path.GetExtension(path));
            Console.WriteLine("The path filename: " + Path.GetFileName(path));
            Console.WriteLine("The path filename without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("The path directory name: " + Path.GetDirectoryName(path));


        }
    }

}
