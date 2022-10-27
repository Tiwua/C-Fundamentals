using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            string[] input;

            for (int i = 1; i <= n; i++)
            {

                input = Console.ReadLine().Split(", ");

                var article = new Article(input[0], input[1], input[2]);

                articles.Add(article);

            }
            string order = Console.ReadLine();

            if (order == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();

            }
            else if (order == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();


            }
            else if (order == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();


            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));


        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }


            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }

    }
}