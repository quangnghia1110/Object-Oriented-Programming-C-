
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapQLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien quanLySinhVien = new SinhVien();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nCHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Thêm sinh viên.                               **");
                Console.WriteLine("**  2. Hiển thị danh sách sinh viên.                 **");
                Console.WriteLine("**  3. Tìm kiếm sinh viên theo ID.                   **");
                Console.WriteLine("**  4. Xóa sinh viên theo ID.                        **");
                Console.WriteLine("**  5. Thoát                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhập tùy chọn: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n1. Thêm sinh viên.");
                        quanLySinhVien.NhapSinhVien();
                        Console.WriteLine("\nThêm sinh viên thành công!");
                       
                        break;
                        
                    case 2:
                        Console.Clear();
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n2. Hiển thị danh sách sinh viên.");
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sách sinh viên trống!");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Tìm kiếm sinh viên theo ID.");
                            Console.Write("\nNhập ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            quanLySinhVien.FindByID(id);
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                            Console.WriteLine("Sinh viên có mã số {0} đã được tìm thấy", id);
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sách sinh viên trống!");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Xóa sinh viên theo ID.");
                            Console.Write("\nNhập ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (quanLySinhVien.DeleteById(id))
                            {
                                quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                                Console.WriteLine("\nSinh viên có id = {0} đã bị xóa.", id);
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy sinh viên phù hợp với mã số cần xóa");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sách sinh viên trống!");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\nBạn đã chọn thoát khỏi chương trình!");
                        return;
                    default:
                        Console.WriteLine("Bạn đã nhập sai số, chỉ nhập giá trị từ 1 đến 5");
                        break;
                }
            }
        }
    }
}