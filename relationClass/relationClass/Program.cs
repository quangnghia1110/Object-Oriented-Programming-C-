using System;
using System.Text;

namespace relationClass
{
   class Program
    {
        static void Main(string[] agrs)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Date date = new Date(11,10,2003);
            //Console.WriteLine(date.toString());
            Student student = new Student(21110559,"Ngô Quang Nghĩa",date);
            Console.WriteLine(student.toString());  
            Console.ReadKey();
        }
    }
}