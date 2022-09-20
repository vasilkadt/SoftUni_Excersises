using System;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
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
            return $"{Title} -{Content}:{Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(',');
                string arg1 = command[0];
                string arg2 = command[1];
                string arg3 = command[2];

                if(arg1=="title"||arg1=="content"||arg1=="author")
                {
                    break;
                }

                Article article = new Article(arg1, arg2, arg3);
                articles.Add(article);
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
