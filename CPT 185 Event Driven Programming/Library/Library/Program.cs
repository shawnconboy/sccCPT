using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace LibraryProgram
{
    public class Library
    {
        public static List<Book> books = new List<Book>();
        public static List<Member> members = new List<Member>();

        static void Main(string[] args)
        {
            int userChoice = 0;

            // program loop. if 5, program closes.
            while (userChoice != 5)
            {
                // show menu / header type shit. ya feeee me?
                Header();

                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        ShowBookList();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        ShowMemberList();
                        break;
                    case 4:
                        AddMember();
                        break;
                }
            }
            Footer();
        }

        // book section
        // *******************************************
        // header for addBook method
        private static void AddBookHeader()
        {
            Console.Clear();
            Console.WriteLine("Add A Book");
            Console.WriteLine("_________________________");
            Console.WriteLine();
        }

        // add book method
        private static void AddBook()
        {
            string title;
            string author;
            decimal price;

            AddBookHeader();
            Console.WriteLine("Enter the book's title\n");
            title = Console.ReadLine();

            AddBookHeader();
            Console.WriteLine("Enter the book's author\n");
            author = Console.ReadLine();

            AddBookHeader();
            Console.WriteLine("Enter the book's price\n");
            price = decimal.Parse(Console.ReadLine());

            Book newBook = new Book(title, author, price);
            books.Add(newBook);

            AddBookHeader();
            Console.WriteLine("Book added successfully.");
            Console.ReadLine();
        }

        private static void ShowBookList()
        {
            Console.Clear();
            Console.WriteLine("Books Inventory");
            Console.WriteLine();
            Console.WriteLine($"{"Title",-20}{"Author",-20}{"Price"}");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine();

            if (books.Count == 0)
            {
                Console.WriteLine("No books in inventory yet.");
            }
            else
            {
                foreach (Book book in books)
                {
                    Console.WriteLine($"{book.Title,-20}{book.Author,-20}{book.Price.ToString()}");
                }
            }

            Console.ReadLine();
        }

        // member section
        // *******************************************

        private static void AddMemberHeader()
        {
            Console.Clear();
            Console.WriteLine("Add A Customer");
            Console.WriteLine("_________________________");
            Console.WriteLine();
        }

        // add member method
        private static void AddMember()
        {
            string name;
            string phone;
            decimal balance;

            AddMemberHeader();
            Console.WriteLine("Enter Customer name\n");
            name = Console.ReadLine();

            AddMemberHeader();
            Console.WriteLine("Enter customer phone\n");
            phone = Console.ReadLine();

            AddMemberHeader();
            Console.WriteLine("Enter customer balance\n");
            balance = decimal.Parse(Console.ReadLine());

            Member newMember = new Member(name, phone, balance);
            members.Add(newMember);

            AddMemberHeader();
            Console.WriteLine("Member added!");
            Console.ReadLine();
        }
        private static void ShowMemberList()
        {
            Console.Clear();
            Console.WriteLine("Customer List");
            Console.WriteLine();
            Console.WriteLine($"{"Name",-20}{"Phone",-20}{"Balance"}");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine();

            if (members.Count == 0)
            {
                Console.WriteLine("No customers in system yet.");
            }
            else
            {
                foreach (Member member in members)
                {
                    Console.WriteLine($"{member.Name,-20}{member.Phone,-20}{member.Balance.ToString()}");
                }
            }
            Console.ReadLine();
        }

        // header method
        private static void Header()
        {
            Console.Clear();
            Console.WriteLine("Spartanburg Community College Book Store");
            Console.WriteLine();
            Console.WriteLine("Select an option");
            Console.WriteLine("1. See Books");
            Console.WriteLine("2. Add A Book");
            Console.WriteLine("3. See Members");
            Console.WriteLine("4. Add A Member");
            Console.WriteLine();
        }

        // footer method
        private static void Footer()
        {
            Console.Clear();
            Console.WriteLine("Program Ended. Thank You");
            Console.ReadLine();
        }
    }

    // classes shawtaay

    // book class.. duh.
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }

    // member (customer)
    public class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public Member(string name, string phone, decimal balance)
        {
            Name = name;
            Phone = phone;
            Balance = balance;
        }
    }
}