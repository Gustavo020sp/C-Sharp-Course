using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício2_Entities.Entities;

namespace Exercício2_Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(DateTime.Parse("21/05/2018 13:05:44"),
                "Traveling to new zealand",
                "I'm going to visit this wonderful country!", 12);

            post1.AddComment(c1);
            post1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post post2 = new Post(DateTime.Parse("28/07/2018"), 
                "Good night guys", 
                "See you tomorrow", 5);

            post2.AddComment(c3);
            post2.AddComment(c4);

            Console.WriteLine(post1.ToString());
            Console.WriteLine();
            Console.WriteLine(post2.ToString());

            Console.ReadLine();
        }
    }
}
