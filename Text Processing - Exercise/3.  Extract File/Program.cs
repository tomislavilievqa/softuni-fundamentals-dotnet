using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _3.__Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = Console.ReadLine();

            int startingIndexOfTheFileName = path.LastIndexOf('\\');
            int startingIndexOfTheFileExtension = path.IndexOf('.');
            
            string fileName = path.Substring(startingIndexOfTheFileName+1,startingIndexOfTheFileExtension - startingIndexOfTheFileName - 1);
            string extension = path.Substring(startingIndexOfTheFileExtension+1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}