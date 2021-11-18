using System;
using System.Linq;

namespace Lab3_2
{
    public struct Book
    {
        private string nameBook;
        private string nameAuthor;
        private string isbn;

        public Book(string nB, string nA, string isbn)
        {
            this.nameBook = nB;
            this.nameAuthor = nA;
            this.isbn = isbn;
        }

        public string getNameBook()
        {
            return this.nameBook;
        }

        public string getNameAuthor()
        {
            return this.nameAuthor;
        }

        public string getISBN()
        {
            return this.isbn;
        }


        public override string ToString()
        {
            string result = $"Name: {nameBook} , Author: {nameAuthor} , ISBN: {isbn}";
            return result;
        }
    }

    class Library
    {
        private Book[] books = new Book[100];
        private int counter = 0;

        public Library() { }

        public Library(Book book)
        {
            books[counter++] = book;
        }

        public void addBook(Book book)
        {
            books[counter++] = book;
        }

        public string searchBook(string s)
        {
            string result = $"{s} is not found";

            for (int i = 0; i < counter; i++)
            {
                string book = books[i].ToString();
                if (book.Contains(s))
                {
                    result = "Your book: " + book;
                    return result;
                }
            }

            return result;
        }

        public void viewAllBooks()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine((i + 1) + ": " + books[i].ToString());
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book csharp = new Book("C# and .NET", "S. Uuganbayr , B. Bolormaa", "11111111");
            Book clang = new Book("C language", "S. Uuganbayr", "22222222");

            Library lib = new Library();
            lib.addBook(csharp);
            lib.addBook(clang);

            Console.WriteLine(lib.searchBook("C#"));
        }

    }
}