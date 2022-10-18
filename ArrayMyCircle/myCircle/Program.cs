using System;
using System.Text;
namespace myCircle1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            myPoint mP = new myPoint(3, 4);
            myCircle mC = new myCircle(45,mP);
            Console.WriteLine(mC.toString());

            Console.Write("Nhập số lượng circle: ");
            int n = int.Parse(Console.ReadLine());
            myCircle[] MC = new myCircle[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Cirle "+(i+1).ToString());
                MC[i] = NhapThongTinCircle();
            }
            Console.WriteLine("Thông tin vừa mới nhâp");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(MC[i].toString());
            }


            Console.WriteLine("Diện tích hình tròn");
            bool flag = true;
            for (int i = 0; i < n; i++)
            {
                if (MC[i].GetArea() >= 100)
                {
                    flag = false;
                    Console.Write((i + 1) + ". ");
                    Console.WriteLine(MC[i].GetArea());
                }
                else
                {
                    Console.Write((i + 1) + ". ");
                    Console.WriteLine("Không thể in ra thông tin hình tròn vì diện tích nhỏ hơn 100");
                }    
            }
            Console.WriteLine("Chu vi hình tròn");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". ");
                Console.WriteLine(MC[i].Circumference());
            }

            Console.WriteLine("Khoảng cách giữa hai đường tròn");
            for(int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". ");
                Console.WriteLine(MC[i].Distance(mC));
            }    
        }
        
        private static myPoint NhapThongTinPoint()
        {
            Console.Write("Nhập hoành độ: ");
            int x = int.Parse( Console.ReadLine());
            Console.Write("Nhập tung độ: ");
            int y = int.Parse( Console.ReadLine());
            myPoint mP = new myPoint(x,y);
            return mP;
        }
        private static myCircle NhapThongTinCircle()
        {
            Console.Write("Nhập vào radius: ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thông tin Point");
            myPoint center = NhapThongTinPoint();
            myCircle mC = new myCircle(radius,center);
            return mC;
        }
    }
}