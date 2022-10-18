using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace bookAuthors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Author myAuthor1 = new Author("Ngô Quang Nghĩa", "ngoquangnghia111003@gmai.com", 'm');
            Book myBook1 = new Book("Lập trình", myAuthor1, 50000);
            Console.WriteLine(myBook1.toString());
            Book mybook2 = NhapThongTinBook();
            Console.WriteLine(mybook2.toString());
            Console.Write("Nhập số lượng book: ");
            int n = int.Parse(Console.ReadLine());
            Book[] mybook = new Book[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Book {0}: ", i + 1);
                mybook[i] = NhapThongTinBook();

            }
            Console.WriteLine("Danh sách vừa nhập");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mybook[i].toString());

            }
            Console.Write("Nhập vào tên book cần tìm: ");
            for (int i = 0; i < n; i++)
            {
                string findName = Console.ReadLine();
                List<Book> find = mybook[i].FindName(findName);
                if (find!=null)
                    Console.WriteLine(mybook[i].toString());
            }
        }
        private static Author NhapThongTinAuthor()
        {
            Console.Write("Nhập họ tên: ");
            string strname = Console.ReadLine();
            char gender = '\0';
            do
            {
                Console.Write("Nhập giới tính: ");
                char.TryParse(Console.ReadLine(), out gender);
            } while (Author.IsValidGender(gender) == false);
            string stremail = "";
            do
            {
                Console.Write("Nhập email: ");
                stremail = Console.ReadLine();
            } while (Author.IsValidEmail(stremail) == false);
            Author temp = new Author(strname, stremail, gender);
            return temp;
        }

        public static Book NhapThongTinBook()
        {
            Console.Write("Nhập tên book: ");
            string bookName = Console.ReadLine();
            Author author;
            Console.WriteLine("Nhập thông tin author");
            author = NhapThongTinAuthor();
            Console.Write("Nhập giá sách: ");
            double bookPrice = double.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng sách: ");
            int bookqty = int.Parse(Console.ReadLine());
            Book temp = new Book(bookName, author, bookPrice, bookqty);
            return temp;
        }
    }
}

