using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace _2._Articles
{
    class Articlev2
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public Articlev2(string title, string content, string author)
        {
            this.Author = author;
            this.Title = title;
            this.Content = content;
        }

        public override string ToString()
        {
            string result = ($"{Title} - {Content}: {Author}");

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Articlev2> articles = new List<Articlev2>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var title = input[0];
                var content = input[1];
                var author = input[2];

                Articlev2 article = new Articlev2(title, content, author);

                articles.Add(article);
            }

            var lastInput = Console.ReadLine();

            List<Articlev2> filteredList = new List<Articlev2>();

            switch (lastInput)
            {
                case "title":
                    filteredList = articles.OrderBy(articles => articles.Title).ToList();
                    break;
                case "content":
                    filteredList = articles.OrderBy(articles => articles.Content).ToList();
                    break;
                case "author":
                    filteredList = articles.OrderBy(articles => articles.Author).ToList();
                    break;

            }

            foreach (Articlev2 item in filteredList)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}