using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookAuthors
{
    class Book
    {

        private List<Book>
            ListBook = null;

        public Book()
        {
            ListBook = new List<Book>();
        }
        private string name;
        private Author author;
        private double price;
        private int qty;
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }
        internal Author Author { get => author; set => author = value; }
        public Book(string name, Author author, double price, int qty=0)
        {
            Name = name;
            Author = author;
            Price = price;
            Qty = qty;
        }

        ~Book()
        {

        }
        public List<Book> FindName(string findName)
        {
            List<Book> find = new List<Book>();
            if (ListBook != null && ListBook.Count > 0)
            {
                foreach (Book book in ListBook)
                {
                    if (book.Name.ToUpper().Contains(name.ToUpper()))
                    {
                        find.Add(book);
                    }
                }
            }
            return find;
        }
        public string toString()
        {
            string s=$"Book[name={Name},Author[name={author.Name},email={author.Email},gender={author.Gender}],price={Price},qty={Qty}]";
            return s;
        }

        

       
    }
}
