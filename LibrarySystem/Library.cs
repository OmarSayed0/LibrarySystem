using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Library
    {
        private Book[] books = new Book[MaxBooks];
        private const int MaxBooks = 100;
        private int bookCount = 0;
        private Book[] BorrowedBooks = new Book[50];
        private int borrowedBookCount = 0;

        public void AddBook(Book book)
        {
            if (bookCount < books.Length)
            {
                books[bookCount++] = book;
                Console.WriteLine($" Added: {book.Title}");
            }
            else
            {
                Console.WriteLine(" Library is full!");
            }
        }
        public void RemoveBook(string title)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i] != null && books[i].Title == title)
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write($" Removed: {books[i].Title}");
                    Console.ResetColor();
                    Console.WriteLine();
                    books[i] = books[--bookCount]; // Replace with last book
                    books[bookCount] = null; // Clear last slot
                    return;
                }
            }
            Console.WriteLine(" Book not found.");
        }
        public void DisplayBooks()
        {
            Console.WriteLine("\n Library Collection:");
            for (int i = 0; i < bookCount; i++)
            {
                Console.Write($" {i + 1}.  ");
                books[i].Display();
            }
        }
        public void BorrowBook(string title)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i] != null && books[i].Title == title)
                {
                    if (books[i].IsAvailable)
                    {
                        books[i].IsAvailable = false;
                        Console.WriteLine($" Borrowed: {books[i].Title}");
                        BorrowedBooks[borrowedBookCount] = books[i];
                        borrowedBookCount++;
                        return;
                    }
                    else
                    {
                        Console.WriteLine(" Book is already borrowed.");
                        return;
                    }
                }
            }
        }
        public void ReturnBook(string title)
        {
            for (int i = 0; i < borrowedBookCount; i++)
            {
                if (BorrowedBooks[i] != null && BorrowedBooks[i].Title == title)
                {
                    BorrowedBooks[i].IsAvailable = true;
                    Console.WriteLine($" Returned: {BorrowedBooks[i].Title}");
                    /*books[bookCount++] = BorrowedBooks[i];*/
                    BorrowedBooks[i] = BorrowedBooks[--borrowedBookCount]; // Replace with last book
                    BorrowedBooks[borrowedBookCount] = null; // Clear last slot
                    return;
                }
            }
            Console.WriteLine(" Book not found.");
        }
    }
}
