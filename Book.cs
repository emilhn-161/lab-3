using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Book(string title, Author author, Genre genre, double price, int stock)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Title} — {Author.Name} — {Genre.Name} — {Price} AZN — {Stock} stok";
        }
    }
}