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
          
            while(Console.ReadLine().ToLower() != "quit")
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Body: ");
            string body = Console.ReadLine();
            if (title && body)
            {
                sendInputBySQL(title, body);
            }
            
            
        }

        public void sendInputBySQL(String title, String body)
        {
            var context = new ConsoleEntries();
            var post = new Model.Post()
            {
                Title = title,
                Body = body,
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
