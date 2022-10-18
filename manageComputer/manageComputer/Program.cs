using System;
using System.Net;
using System.Text;

namespace manageComputer
{
    class Program
    { 
        static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Computer computer1 = new Computer("Macbook","Usa",1);
            Console.WriteLine(computer1.toString());
            Computer computer2=NhapThongTinMayTinh();
            Console.WriteLine(computer2.toString());
            Console.Write("Nhập số lượng máy tính: ");
            int n=int.Parse(Console.ReadLine());
            
            Computer[] computers = new Computer[n];
            int dem = 0;
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Máy tính thứ "+(i+1).ToString());
                computers[i]=NhapThongTinMayTinh();
                dem++;
            }
            
            Console.WriteLine("**Danh sách vừa nhập**");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(computers[i].toString());
            }

            Console.Write("**Theo thống kê số máy có thời gian bảo hành là 1 năm là: ");
            int dem1 =0;
            for(int i = 0; i < n; i++)
            {
                if(computers[i].KiemTraThoiGianBaoHanh() == 1)
                {
                    dem1++;
                }
            }
            Console.WriteLine(dem1);
            

            Console.WriteLine("**Danh sách các máy tính có xuất sứ từ Mỹ");
            for (int i=0;i<n;i++)
            {
                if (computers[i].KiemTraXuatXu()==1)
                {
                    
                    Console.WriteLine(computers[i].toString());
                    
                }
                else
                {
                    Console.WriteLine("Không có máy tính nào xuất xứ từ mỹ");
                }
            }


            Console.Write("**Số lượng máy tính hiện có: ");
            Console.WriteLine(dem);
        }
        
        private static Computer NhapThongTinMayTinh()
        {
            Console.Write("Nhập loại máy: ");
            string loaiMay1 = Console.ReadLine();
            Console.Write("Nhập nơi sản xuất: ");
            string noiSanXuat1 = Console.ReadLine();
            Console.Write("Nhập thời gian bảo hành: ");
            int thoiGianBaoHanh1 = int.Parse(Console.ReadLine());
            Computer temp=new Computer(loaiMay1,noiSanXuat1,thoiGianBaoHanh1);
            return temp;
        }
    }

}