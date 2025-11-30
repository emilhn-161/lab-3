using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var osho = new Author("Osho");
            var tolstoy = new Author("Lev Tolstoy");
            var ronda = new Author("Ronda Bern");
            var fyodor = new Author("Fyodor Dostoyevski");



            var philosophy = new Genre("Fəlsəfə");
            var classic = new Genre("Klassik");
            var personal = new Genre("Motivasiya");



            var books = new List<Book>
{
new Book("Svaboda", osho, philosophy, 12, 15),
new Book("Voyna i Mir", tolstoy, classic, 18, 20),
new Book("Put Jizni", tolstoy, classic, 14, 10),
new Book("The Secret", ronda, personal, 10, 25),
new Book("Prestuplenie i Nakazanie", fyodor, classic, 16, 12)
};


            foreach (var b in books)
                b.Author.Books.Add(b);



            var customers = new List<Customer>
{
new Customer("Emil Najafov"),
new Customer("Ali Mammadov")
};


            Console.WriteLine("\n--- BÜTÜN KİTABLAR ---");
            foreach (var b in books) Console.WriteLine(b);



            Console.WriteLine("\n--- KITAB REDAKTƏ (The Secret) ---");
            var editBook = books.First(b => b.Title == "The Secret");
            editBook.Price = 12;
            editBook.Stock = 30;
            Console.WriteLine(editBook);


            Console.WriteLine("\n--- KITAB SIL (Put Jizni) ---");
            var deleteBook = books.First(b => b.Title == "Put Jizni");
            books.Remove(deleteBook);
            foreach (var b in books) Console.WriteLine(b);


            Console.WriteLine("\n--- Yeni Sifariş ---");
            var order1 = new Order(customers[0], books[0], 2);
            Console.WriteLine(order1);



            Console.WriteLine("\n--- Tolstoy'un Kitabları ---");
            foreach (var b in tolstoy.Books) Console.WriteLine(b);



            Console.WriteLine("\n--- Klassik Janrı Kitabları ---");
            foreach (var b in books.Where(x => x.Genre == classic)) Console.WriteLine(b);



        }
    }
}
