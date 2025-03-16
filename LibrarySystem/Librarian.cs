using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Librarian : User
    {
        public int EmployeeNumber { get; set; }
        
        public void AddBook(Library library, Book book)
        {
            library.AddBook(book);
        }
        public void RemoveBook(Library library, string title)
        {
            library.RemoveBook(title);
        }
    }
}
