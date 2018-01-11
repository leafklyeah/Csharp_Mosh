using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp_Mosh.ExerciseS9L75
{
    class ReadFile
    {
        static void MainReadFile()
        {
            var files=File.ReadAllText(@"C:\Users\KarenZhang\Downloads\test.txt");
            Console.WriteLine(files.Length);
        }
    }
}
