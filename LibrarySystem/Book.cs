using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }


        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true;
        }
        public void Display()
        {
            string status = IsAvailable ? "Available" : "Borrowed";
            Console.WriteLine($"{Title} by {Author}, {Year} - {status}");
        }
    }
}
