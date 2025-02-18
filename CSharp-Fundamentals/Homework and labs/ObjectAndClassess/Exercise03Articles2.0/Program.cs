﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise03Articles2._0
{
    class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < number; i++)
            {
                string[] currArg = Console.ReadLine().Split(", ");
                string title = currArg[0];
                string content = currArg[1];
                string author = currArg[2];

                Article article = new Article(title, content, author);
                articles.Add(article);


            }
            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;


        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }



        public override string ToString()
        {
            return ($"{Title} - {Content}: {Author}");
        }

    }
}



