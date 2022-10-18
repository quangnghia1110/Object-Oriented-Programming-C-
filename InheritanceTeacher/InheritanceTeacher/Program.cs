using System;
using System.Text;

namespace InheritanceTeacher
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            GVCN gvcn1=new GVCN("Ngô Quang Nghĩa","84974117373","Sài Gòn",2003, 3.0,3000000,"Lập trình C#", 1500000);
            Console.WriteLine("Năm về hưu: "+gvcn1.tinhTuoiVeHuu());
            Console.WriteLine(gvcn1.toString());
            Console.WriteLine("Lương của giảng viên: "+gvcn1.tinhLuong());
            Console.ReadKey();
        }
    }
}