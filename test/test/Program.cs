using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_HocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> lstSV = new List<SinhVien>();
            Boolean flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("1. Nhap thong tin cho n sinh vien.");
                Console.WriteLine("2. In danh sach sinh vien");
                Console.WriteLine("3. In phieu bao diem cho tung sinh vien");
                Console.WriteLine("4. Thoat he thong");
                Console.Write("Hay lua chon di: ");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Write("Nhap so sinh vien: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Sinh vien {0}", i + 1);
                            lstSV.Add(NhapSinhVien());
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        if (lstSV.Count == 0)
                            Console.WriteLine("Chua co sinh vien");
                        else
                        {
                            foreach (SinhVien i in lstSV)
                            {
                                Console.WriteLine(i.toString());
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Phieu diem cac sinh vien");
                        if (lstSV.Count == 0)
                            Console.WriteLine("Chua co sinh vien");
                        else
                        {
                            foreach (SinhVien i in lstSV)
                            {
                                i.InPhieuBaoDiem();
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Nhap lai tu 1-4");
                        Console.ReadKey();
                        break;
                }
            }

        }

        static SinhVien NhapSinhVien()
        {
            Console.Write("Nhap ten sinh vien: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap ma so sinh vien: ");
            string mssv = Console.ReadLine();
            Console.Write("Nhap lop: ");
            string lop = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            string khoa = Console.ReadLine();
            SinhVien temp = new SinhVien(ten, mssv, lop, khoa);
            Console.Write("Sinh vien co bao nhieu mon: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mon {0}", i + 1);
                temp.ThemMonHoc();
            }
            return temp;
        }
    }
}