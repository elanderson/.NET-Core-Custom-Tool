using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileCount = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), 
                                                     "*.*", 
                                                     SearchOption.AllDirectories).Count();
            Console.WriteLine($"{Directory.GetCurrentDirectory()} continas {fileCount} files");
        }
    }
}
