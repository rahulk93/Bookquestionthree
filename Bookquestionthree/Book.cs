using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookquestionthree
{
    class Book
    {
        //These three below are auto-implemented properties.
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        //This below is parameterless constructor.
        public Book()
        {
            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***"); //The sententce or piece of program on the left is Welcoming message.
        }

        //This below is paramteriesed constructor which has three parameters (title, author, publisher).
        public Book (string tle, string au, string pub)
        {
            tle = Title;
            au = Author;
            pub = Publisher;
        }


    }
}
