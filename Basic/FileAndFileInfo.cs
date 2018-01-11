using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //for file and fileinfo

namespace Csharp_Mosh
{
    class FileAndFileInfo
    {
        static void MainFile()
        {
            var path = @"C:\Users\KarenZhang\Downloads\test1.txt";
            File.Copy(@"C:\Users\KarenZhang\Desktop\test.txt", @"C:\Users\KarenZhang\Downloads\test.txt", true);
            if (File.Exists(path))
            {
                Console.WriteLine("There is a test1 in downloads file");
            }
            var content = File.ReadAllText(path);
            File.Delete(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            if (fileInfo.Exists)
            {
                Console.WriteLine("Exist");
            }
            fileInfo.Delete();


        }
    }
}
