using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp_Mosh
{
    class DirectoryAndDirectoryInfo
    {
        static void MainDirectory()
        {
            Directory.CreateDirectory(@"C:\Users\KarenZhang\Downloads\test1");
            //var files=Directory.GetFiles(@"C: \Users\KarenZhang\Downloads", "*.txt", SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C: \Users\KarenZhang\Downloads", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var direcoryInfo = new DirectoryInfo("...");
            direcoryInfo.GetFiles();
            direcoryInfo.GetDirectories();

        }
    }

}
