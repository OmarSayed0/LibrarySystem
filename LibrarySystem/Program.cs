namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            Console.WriteLine("Welcome to Library management system v1.0 ");
        MainMenu:;
            Console.WriteLine(
                """
                Please select type of user :

                    1.Librarian(L) 
                    2.Member(M)
                """);

            char userType = Console.ReadLine().ToUpper()[0];
            switch (userType)
            {
                case 'L':
                    Librarian librarian = new Librarian();
                    Console.WriteLine("Enter your name : ");
                    librarian.Name = Console.ReadLine();
                    Console.WriteLine("Enter your employee number : ");
                    librarian.EmployeeNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Welcome " + librarian.Name);


                    while (true)
                    {
                        Console.WriteLine(
    """

                        Please select operation :
                            1.Add Book(A) 
                            2.Remove Book(R)
                            3.Display Books(D)
                            4.Exit(E)
                        """);
                        char option = Console.ReadLine().ToUpper()[0];
                        switch (option)
                        {
                            case 'A':
                                Console.WriteLine("Enter book title : ");
                                string title = Console.ReadLine();
                                Console.WriteLine("Enter book author : ");
                                string author = Console.ReadLine();
                                Console.WriteLine("Enter book year : ");
                                int year = int.Parse(Console.ReadLine());
                                Book book = new Book(title, author, year);
                                librarian.AddBook(library, book);
                                break;
                            case 'R':
                                Console.WriteLine("Enter book title : ");
                                string titleToRemove = Console.ReadLine();
                                librarian.RemoveBook(library, titleToRemove);
                                break;
                            case 'D':
                                library.DisplayBooks();
                                break;
                            case 'E':
                                Console.WriteLine("MainMenu Loading...");
                                goto MainMenu;
                                break;
                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }
                    }

                case 'M':
                    LibraryUser Member = new LibraryUser();
                    Console.WriteLine("Enter your name : ");
                    Member.Name = Console.ReadLine();

                    Console.WriteLine("Welcome " + Member.Name);


                    while (true)
                    {
                        Console.WriteLine(
                        """

                        Please select operation :
                            
                            1.Display Books(D)
                            2.Borrow Book(B)
                            3.Return Book(R)
                            4.Exit(E)
                        """);
                        char option = Console.ReadLine().ToUpper()[0];
                        switch (option)
                        {
                            case 'D':
                                library.DisplayBooks();
                                break;
                            case 'B':
                                Console.WriteLine("Enter book title : ");
                                string titleToBorrow = Console.ReadLine();
                                Member.BorrowBook(library, titleToBorrow);
                                break;
                            case 'R':
                                Console.WriteLine("Enter book title : ");
                                string titleToReturn = Console.ReadLine();
                                Member.ReturnBook(library, titleToReturn);
                                break;

                            case 'E':
                                Console.WriteLine("MainMenu Loading...");
                                goto MainMenu;
                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }
                    }

                default:
                    Console.WriteLine("Invalid user type");
                    break;
            }



        }
    }
}
