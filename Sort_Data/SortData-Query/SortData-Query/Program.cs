using System;
using System.Linq;

namespace SortData_Query
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
                new Book(){Id=7,Title="C#",Auther="Amal "},
                new Book(){Id=1,Title="C",Auther="Ali"},
                new Book(){Id=3,Title="C++",Auther="Ali"},
                new Book(){Id=2,Title="C#",Auther="Fatma"},
                new Book(){Id=5,Title="php",Auther="Said"},
                new Book(){Id=6,Title="sql",Auther="Amal "},
                new Book(){Id=4,Title="java",Auther="Ahmed"}
            };
            var List = from item
                       in books
                       orderby item.Id
                       select item;

            foreach(var item in List)
            {
                Console.WriteLine("Id={0}\nTitle={1}\nAuther={2}", item.Id, item.Title, item.Auther);
                Console.WriteLine("---------------------------");
            }
            Console.ReadKey();
        }
    }
}
