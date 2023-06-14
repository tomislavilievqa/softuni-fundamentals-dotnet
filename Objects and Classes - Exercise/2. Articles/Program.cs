using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace _2._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;
        }
        public string Edit(string content)
        {

            return this.Content;
        }
        public string ChangeAuthor(string author)
        {
            return this.Author;
        }
        public string Rename(string title)
        {
            return this.Title;
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
            List<string> input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<Article> articles = new List<Article>();

            var title = input[0];
            var content = input[1];
            var author = input[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (commands[0])
                {
                    case "Edit":
                        article.Content = commands[1];
                        article.Edit(content);
                        break;
                    case "ChangeAuthor":
                        article.Author = commands[1];
                        article.Edit(author);
                        break;
                    case "Rename":
                        article.Title = commands[1];
                        article.Edit(title);
                        break;
                    default:
                        break;

                }
            }

            articles.Add(article);

            foreach (Article item in articles)
            {
                Console.WriteLine(item);
            }

        }
    }
}