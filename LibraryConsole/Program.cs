

namespace LibraryConsole
{
    internal class Program
    {
        public static List<Book> bookList = new List<Book>();
        public static List<Member> memberList = new List<Member>();

        // program's main method
        static void Main(string[] args)
        {
            int userChoice = 0;

            // main program loop
            while (userChoice != 5)
            {
                DisplayHeader();
                userChoice = int.Parse(Console.ReadLine());
                

                // bad values
                if (userChoice > 5 || userChoice < 1)
                {
                    DisplayTitle();
                    Console.WriteLine("Sorry. Invalid Option.");
                    Console.ReadKey();
                }

                // see book inventory
                if (userChoice == 1)
                {
                    DisplayTitle();
                    // if no books in inventory, print message
                    if (bookList.Count == 0)
                    {
                        Console.WriteLine("No books in inventory.");
                    }
                    else
                    {
                        // list each book
                        foreach (Book book in bookList)
                        {
                            Console.WriteLine($"{book.Title,-20}{book.Author,-20}{book.Genre,-15}");
                        }
                    }
                    Console.ReadLine();
                }

                // add a book
                if (userChoice == 2)
                {
                    int bookId = 0;
                    string title = "";
                    string author = "";
                    string genre = "";
                    bool isAvailable = true;

                    DisplayTitle();

                    Console.WriteLine("Enter Book ID");
                    bookId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter book title");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter book author");
                    author = Console.ReadLine();

                    Console.WriteLine("Enter book genre");
                    genre = Console.ReadLine();

                    Book newBook = new Book(bookId,title,author,genre,isAvailable);

                    bookList.Add(newBook);
                }

                // show members
                if (userChoice == 3)
                {
                    // account for no members currently
                    if (memberList.Count == 0)
                    {
                        Console.WriteLine("No Members currently.");
                    }
                    else
                    {
                        foreach (Member member in memberList)
                        {
                            Console.WriteLine($"{member.Name,-20}{member.Number,-15}");
                        }
                    }
                }
            
                // add a member
                if (userChoice == 4)
                {
                    int memberId = 0;
                    string name = "";
                    string number = "";
                }
            }

            Console.Clear();
            Console.WriteLine("Program Ended.");
            Console.ReadKey();
        }

        private static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Library Of The Geeks\n");
        }

        private static void DisplayHeader()
        {
            Console.Clear();

            Console.WriteLine("Library Of The Geeks\n");
            Console.WriteLine("1. See Book Inventory");
            Console.WriteLine("2. Add A Book");
            Console.WriteLine("3. See Members");
            Console.WriteLine("4. Add A Member");
            Console.WriteLine("5. Exit Program\n");
            Console.WriteLine("Choose An Option");
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public bool IsAvailable { get; set; }

            // constructor
            public Book(int bookId, string title, string author, string genre, bool isAvailable)
            {
                BookID = bookId;
                Title = title;
                Author = author;
                Genre = genre;
                IsAvailable = isAvailable;
            }
        }

        public class Member
        {
            public int MemberID { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
            public List<Book> CheckedOut { get; set; }

            public Member(int memberId, string name, string number, List<Book> checkedOut)
            {
                MemberID = memberId;
                Name = name;
                Number = number;
                CheckedOut = checkedOut;
            }
        }
    }
}
