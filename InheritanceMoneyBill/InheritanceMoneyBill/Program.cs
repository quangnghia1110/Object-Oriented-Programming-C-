using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMoneyBill
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            BienLai b = new BienLai(500, 275,"Ngô Quang Nghĩa",52,1);
            Console.WriteLine(b.toString());
            BienLai bienlai=NhapThongTinBienLai();
            Console.WriteLine(bienlai.toString());
            Console.Write("\n**Nhập số lượng biên lai: ");
            int n = int.Parse(Console.ReadLine());
            BienLai[] bienlai1=new BienLai[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*Biên lai {0}", i + 1);
                bienlai1[i] = NhapThongTinBienLai();
            }
            Console.WriteLine("\n***THÔNG TIN VỪA NHẬP***");
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(bienlai1[i].toString());
                Console.WriteLine(",Tiền Điện: "+ bienlai1[i].tinhTien());
                sum = sum + bienlai1[i].tinhTien();
            }
            Console.Write("\n***Tổng tiền mà người quản lý thu được từ các biên lai là: ");
            Console.Write(sum+" VNĐ***");

            
            
            

        }
        private static BienLai NhapThongTinBienLai()
        {
            Console.Write("Nhập số mới: ");
            int soMoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cũ: ");
            int soCu = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ và tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập số nhà: ");
            int soNha = int.Parse(Console.ReadLine());
            Console.Write("Nhập mã số: ");
            int maSo = int.Parse(Console.ReadLine());
            BienLai bL=new BienLai(soMoi, soCu,hoTen,soNha,maSo);
            return bL;
        }
       
    }
}
