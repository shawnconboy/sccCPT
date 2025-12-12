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
                }
            }
            Footer();
        }

        private static void Footer()
        {
            Console.Clear();
            Console.WriteLine("Program Ended. Thank You");
            Console.ReadLine();
        }

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

            Book newBook = new Book(title,author,price);
            books.Add(newBook);

            AddBookHeader();
            Console.WriteLine("Book added successfully.");
            Console.ReadLine();
        }

        private static void AddBookHeader()
        {
            Console.Clear();
            Console.WriteLine("Add A Book");
            Console.WriteLine("_________________________");
            Console.WriteLine();
        }

        private static void ShowBookList()
        {
            Console.Clear();
            Console.WriteLine("Books Inventory");
            Console.WriteLine();
            Console.WriteLine($"{"Title",-20}{"Author",-20}{"Price"}");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine();


            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title,-20}{book.Author,-20}{book.Price.ToString()}");
            }

            Console.ReadLine();
        }

        private static void Header()
        {
            Console.Clear();
            Console.WriteLine("Library of South Carolina");
            Console.WriteLine();
            Console.WriteLine("Select an option");
            Console.WriteLine("1. See Books");
            Console.WriteLine("2. Add A Book");
            Console.WriteLine();
        }
    }

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
}