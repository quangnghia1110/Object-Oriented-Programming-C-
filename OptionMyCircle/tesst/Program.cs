using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircle[] lstCircle = new MyCircle[0];
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("1. Nhap mang cac circle.");
                Console.WriteLine("2. In ra cac circle co dien tich >= 100.");
                Console.WriteLine("3. Thoat");
                Console.Write("Chon 1 so: ");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Write("Nhap so luong muon them: ");
                        int n = int.Parse(Console.ReadLine());
                        NhapMangCircle(ref lstCircle, n);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Cac circle co dien tich >= 100");
                        InCircleArea100(lstCircle);
                        Console.ReadKey();
                        break;
                    case "3":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Nhap sai so, nhap lai tu 1 - 3");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static public void InCircleArea100(MyCircle[] lst)
        {
            if (lst.Length == 0)
                Console.WriteLine("Khong co phan tu trong mang");
            else
            {
                bool flag = true;
                for (int i = 0; i < lst.Length; i++)
                {
                    if (lst[i].GetArea() >= 100)
                    {
                        flag = false;
                        Console.WriteLine(lst[i].ToString());
                    }
                }
                if (flag == true)
                    Console.WriteLine("Khong co phan tu nao");
            }
        }

        static public void NhapMangCircle(ref MyCircle[] lstCircle, int n)
        {
            int pastLength = lstCircle.Length;
            Array.Resize(ref lstCircle, lstCircle.Length + n);
            for (int i = pastLength; i < pastLength + n; i++)
                lstCircle[i] = NhapMotCircle();
        }

        static public MyCircle NhapMotCircle()
        {
            Console.Write("Nhap toa do x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhap ban kinh r: ");
            int r = int.Parse(Console.ReadLine());
            MyCircle temp = new MyCircle(x, y, r);
            return temp;
        }
    }
}
