using System;
using System.Linq;

namespace _5._HTML
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string content = Console.ReadLine();
            string comments = string.Empty;
            Console.WriteLine($"<h1>\r\n    {articleTitle}\r\n</h1>");
            Console.WriteLine($"<article>\r\n    {content}\r\n</article>");

            while ((comments = Console.ReadLine()) != "end of comments")
            {
                    
                Console.WriteLine($"<div>\r\n    {comments}\r\n</div>");    


            }
        }
    }
}