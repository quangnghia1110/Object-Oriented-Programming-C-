using System;
namespace quanlysinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhập số lượng sinh viên hiện có: ");
            n = int.Parse(Console.ReadLine());
            Student[] _student = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh viên thứ "+(i + 1).ToString());
                _student[i] = new Student();
                _student[i].Nhap();
            }
            Console.WriteLine("----------Danh sách sinh viên----------");
            for (int i = 0; i < n; i++)
            {
                _student[i].Xuat();
            }
            Console.ReadKey();

        }
    }
}