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
            List<string> article = Console.ReadLine().Split(", ").ToList();

            Article resultArticle = new Article(article[0], article[1], article[2]);
            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                string partToAdjust = command[1];

                if (action == "Edit")
                {
                    resultArticle.Edit(partToAdjust);
                }

                else if (action == "ChangeAuthor")
                {
                    resultArticle.ChangeAuthor(partToAdjust);
                }

                else if (action == "Rename")
                {
                    resultArticle.Rename(partToAdjust);
                }
            }

            Console.WriteLine(resultArticle);
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

            public void Edit(string content)
            {
                Content = content;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public void Rename(string title)
            {
                Title = title;
            }
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }

    }
}