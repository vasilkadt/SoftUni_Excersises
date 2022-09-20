using System;

namespace _02._Articles
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
        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }
        public void ToString()
        {
            Console.WriteLine($"{this.Title} -{this.Content}:{this.Author}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(':');
                string arg1 = command[0];
                string arg2 = command[1];

                if (arg1 == "Edit")
                {
                    article.Edit(arg2);
                }
                else if (arg1 == "ChangeAuthor")
                {
                    article.ChangeAuthor(arg2);
                }
                else if (arg1 == "Rename")
                {
                    article.Rename(arg2);
                }
            }
            article.ToString();
        }
    }
}
