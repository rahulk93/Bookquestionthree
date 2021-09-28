using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookquestionthree
{
    class Program
    {
        static void Main(string[] args)
        {
            //The thing below is new object created.
            Book b1 = new Book();

            Console.Write("\nEnter Book Title: ");
            b1.Title = Console.ReadLine();

            Console.Write("Enter Book Author: ");
            b1.Author = Console.ReadLine();

            Console.Write("Enter Book Publisher: ");
            b1.Publisher = Console.ReadLine();

            Console.WriteLine("\n******************************************");
            Console.WriteLine("The following new book has been processed:");
            Console.WriteLine("Book Title: {0}\nAuthor: {1}\nPublisher: {2}", b1.Title, b1.Author, b1.Publisher);

            Console.ReadKey();

            //This programme is very useful in Book stores or in public libraries. The developer of this programme is Rahul Khatri.
        }
    }
}
