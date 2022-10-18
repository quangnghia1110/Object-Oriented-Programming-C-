using System;
namespace quanlysinhvien
{
    class Student
    {
        private string hoTen;
        private int tuoiTac;
        private int maSo;
        private string diaChi;
        private double diemToan;
        private double diemVan;
        private double diemAnh;
        private double diemHoa;
        private double diemLy;
        private double diemSinh;
        private double diemTrungBinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int TuoiTac { get => tuoiTac; set => tuoiTac = value; }
        public int MaSo { get => maSo; set => maSo = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public double DiemAnh { get => diemAnh; set => diemAnh = value; }
        public double DiemHoa { get => diemHoa; set => diemHoa = value; }
        public double DiemLy { get => diemLy; set => diemLy = value; }
        public double DiemSinh { get => diemSinh; set => diemSinh = value; }
        public double DiemTrungBinh { get => diemTrungBinh; set => diemTrungBinh = value; }

        public Student()
        {
            hoTen = "";
            tuoiTac = 0;
            maSo = 0;
            diaChi = "";
            diemToan = 0;
            diemVan = 0;
            diemAnh = 0;
            diemHoa = 0;
            diemLy = 0;
            diemSinh = 0;
        }
        ~Student()
        {

        }

        public void Nhap()
        {
            Console.Write("\tNhập họ và tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.Write("\tNhập địa chỉ của sinh viên: ");
            DiaChi = Console.ReadLine();
            Console.Write("\tNhập mã số sinh viên: ");
            MaSo = int.Parse(Console.ReadLine());
            Console.Write("\tNhập tuổi của sinh viên: ");
            TuoiTac = int.Parse(Console.ReadLine());
            Console.Write("\tNhập điểm toán: ");
            DiemToan = double.Parse(Console.ReadLine());
            if (DiemToan > 10 || DiemToan < 0)
            {
                Console.WriteLine("\tĐiểm không nằm trong phạm vi từ 0 đến 10");
                Console.WriteLine("\tNhập lại!");
                DiemToan = double.Parse(Console.ReadLine());
            }
            Console.Write("\tNhập điểm văn: ");
            DiemVan = double.Parse(Console.ReadLine());
            if (DiemVan > 10 || DiemVan < 0)
            {
                Console.WriteLine("\tĐiểm không nằm trong phạm vi từ 0 đến 10");
                Console.WriteLine("\tNhập lại!");
                DiemVan = double.Parse(Console.ReadLine());
            }
            Console.Write("\tNhập điểm anh: ");
            DiemAnh = double.Parse(Console.ReadLine());
            if (DiemAnh > 10 || DiemAnh < 0)
            {
                Console.WriteLine("\tĐiểm không nằm trong phạm vi từ 0 đến 10");
                Console.WriteLine("\tNhập lại!");
                DiemAnh = double.Parse(Console.ReadLine());
            }
            Console.Write("\tNhập điểm lý: ");
            DiemLy = double.Parse(Console.ReadLine());
            if (DiemLy > 10 || DiemLy < 0)
            {
                Console.WriteLine("\tĐiểm không nằm trong phạm vi từ 0 đến 10");
                Console.WriteLine("\tNhập lại!");
                DiemLy = double.Parse(Console.ReadLine());
            }
            Console.Write("\tNhập điểm hóa: ");
            DiemHoa = double.Parse(Console.ReadLine());
            if (DiemHoa > 10 || DiemHoa < 0)
            {
                Console.WriteLine("\tĐiểm không nằm trong phạm vi từ 0 đến 10");
                Console.WriteLine("\tNhập lại!");
                DiemHoa = double.Parse(Console.ReadLine());
            }
            Console.Write("\tNhập điểm sinh: ");
            DiemSinh = double.Parse(Console.ReadLine());
            if (DiemSinh > 10 || DiemSinh < 0)
            {
                Console.WriteLine("\tĐiểm không nằm trong phạm vi từ 0 đến 10");
                Console.WriteLine("\tNhập lại!");
                DiemSinh = double.Parse(Console.ReadLine());
            }
            DiemTrungBinh = (DiemToan + DiemVan + DiemAnh + DiemHoa + DiemLy + DiemSinh) / 6;
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-15},{1,-15},{2,-15},{3,-15},{4,-15},{5,-15},{6,-15},{7,-15},{8,-15},{9,-15}", HoTen, DiaChi, TuoiTac, DiemToan, DiemVan, DiemAnh, DiemHoa, DiemLy, DiemSinh,Diem);
        }
    }
}
