/*
 Grouping Data using Query Syntax
 */
using System;
using System.Linq;

namespace Query_Syntax
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books =
                        {
                new Book(){Id=1,Title="C#",Auther="Amal "},
                new Book(){Id=2,Title="C",Auther="Ali"},
                new Book(){Id=3,Title="C++",Auther="Ali"},
                new Book(){Id=4,Title="C#",Auther="Fatma"},
                new Book(){Id=5,Title="php",Auther="Said"},
                new Book(){Id=6,Title="sql",Auther="Amal "},
                new Book(){Id=7,Title="java",Auther="Ahmed"}
            };
            var list = from item
                       in books
                       group item by item.Auther;
            foreach(var item in list)
            {
                Console.WriteLine("**********Auther :{0}**********", item.Key);
                foreach(var book in item)
                {
                    Console.WriteLine("Id={0}\nTitle={1}\n", book.Id, book.Title);
                   
                }
            }
            Console.ReadKey();
        }
    }
}
