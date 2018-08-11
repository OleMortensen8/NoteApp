using System;
using System.Data.Entity;

namespace NoteApp
{
    public class ConsoleEntries : DbContext {
        public DbSet<Model.Post> Posts { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                var context = new ConsoleEntries();
                var post = new Model.Post() {
                   Title = Console.ReadLine(),
                   Body = Console.ReadLine(),
                   DateWritten = DateTime.Now
                };
                context.Posts.Add(post);
                context.SaveChanges();
                foreach (var entry in context.Posts)
                {
                    Console.WriteLine(entry.Title + " " + entry.Body + "\n" + entry.DateWritten);
                }
            }
        }
    }
}
