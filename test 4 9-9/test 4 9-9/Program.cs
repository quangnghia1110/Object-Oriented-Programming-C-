using System;
namespace BT3
{
    /*Ho Si Hung
    * 19211TT0047
    * 29/05/2020
    */
    class Program
    {
        static void Main(string[] args)
        {
            Author Test = new Author("Nguyen Van Anh", 'm');
            Test.Email = "NguyenA23asd";
            Author Test1 = new Author("Pham Bao Huong Giang", 'f',
           DateTime.ParseExact("08/08/1995", "dd/MM/yyyy", null), "12#2#2");
            //Xuất thông tin Test
            Console.WriteLine(Test.Print());
            Console.WriteLine("Create Email : {0}",
           Test.CreateEmail("tdc.edu.vn"));
            Console.WriteLine("Age : {0} ", Test.GetAge());
            Console.WriteLine("Ngay sinh : {0:d}", Test.Birthday);
            Console.WriteLine("---------------------------------");
            //Xuất thông tin Test1
            Test1.Gender = 'i';
            Console.WriteLine(Test1.Print());
            Console.WriteLine("Create Email : {0}",
           Test1.CreateEmail("tdc.edu.vn"));
            Console.WriteLine("Age : {0} ", Test1.GetAge());
            Console.WriteLine("Ngay sinh : {0:d}", Test1.Birthday);
            Console.WriteLine("---------------------------------");
            //Xuất thông tin Test2
            Author Test2 = new Author("Duong Dai Thanh Cong", 'm',
           "duongdaithanhcong@gmail");
            Console.WriteLine(Test2.Print());
            Console.WriteLine("Create Email : 
       { 0}
            ",Test2.CreateEmail("tdc.edu.vn"));
        Console.WriteLine("Age : {0} ", Test2.GetAge());
            Console.WriteLine("Ngay sinh : {0:d}", Test2.Birthday);
            Console.ReadKey();
        }
    }