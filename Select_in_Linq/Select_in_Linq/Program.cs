//Select Name that length is more than 3 letters

using System;
using System.Collections.Generic;
using System.Linq;

namespace Select_in_Linq
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>() { "Amal", "Fatma", "Ali", "Mai", "Ahmed", "Karam", "amr" };

            //Query Syntax
            var Result = from item
                       in Names
                       where item.Length>3
                       select item;
            Console.WriteLine("*******Query Syntax*******");

            foreach (var name in Result)
            {
                Console.WriteLine(name);
            }

            //Non-Query Syntax
            Console.WriteLine("\n*******Non-Query Syntax*******");

            var result = Names.Where(item => item.Length > 3);
            foreach (var name in Result)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
