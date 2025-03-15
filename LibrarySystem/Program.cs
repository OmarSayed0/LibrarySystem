namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library management system v1.0 ");
            Console.WriteLine(
                """
                Please select type of user :

                    1.Librarian(L) 
                    2.Member(M)
                """);

            char userType = Console.ReadLine()[0];

            switch (userType)
            {
                case 'L':
                    Console.WriteLine("Welcome Librarian");
                    break;
                case 'M':
                    Console.WriteLine("Welcome Member");
                    break;
                default:
                    Console.WriteLine("Invalid user type");
                    break;
            }



        }
    }
}
