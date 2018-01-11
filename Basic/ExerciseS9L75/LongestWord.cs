using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Csharp_Mosh.ExerciseS9L75
{
    class LongestWord
    {
        static void MainLongestWord()
        {
            var files=File.ReadAllText(@"C:\Users\KarenZhang\Downloads\test.txt");
            var words = files.Split(' ');
            string longestWord=words[0];
            for(int i=1;i<words.Length;i++)
            {
                if (longestWord.Length < words[i].Length)
                    longestWord = words[i];

            }

            Console.WriteLine("The longest word is: "+longestWord);
        }
    }
}
