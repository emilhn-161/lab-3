using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Order
    {
        public Customer Customer { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }

        public Order(Customer customer, Book book, int quantity)
        {
            Customer = customer;
            Books.Add(book);
            Quantity = quantity;
            Date = DateTime.Now;
            TotalPrice = book.Price * quantity;
        }

        public override string ToString()
        {
            return $"Sifariş: {Customer.FullName} — {Date} — {TotalPrice} AZN — Kitab: {Books[0].Title} (x{Quantity})";
        }
    }
}
