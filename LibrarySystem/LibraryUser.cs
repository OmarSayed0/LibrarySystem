using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class LibraryUser : User
    {

        public void BorrowBook(Library library, string title)
        {
            library.BorrowBook(title);
        }
        public void ReturnBook(Library library, string title)
        {
            library.ReturnBook(title);
        }

    }
}
