using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_HocSinh
{
    class SinhVien : LopHoc
    {
        private string tenSinhVien = "Nguyen Van A";
        private string maSoSinhvien = "Khong co";
        private List<MonHoc> lstMonHoc = new List<MonHoc>();

        public SinhVien() { }
        public SinhVien(string tenSV, string mSSV, string tenLop, string khoa) : base(tenLop, khoa)
        {
            this.tenSinhVien = tenSV;
            this.maSoSinhvien = mSSV;
        }

        public string GetTenSV() { return tenSinhVien; }
        public void SetTenSV(string tenSV) { this.tenSinhVien = tenSV; }
        public string GetMSSV() { return maSoSinhvien; }
        public void SetMSSV(string MSSV) { this.maSoSinhvien = MSSV; }

        public void ThemMonHoc()
        {
            Console.Write("Nhap ten mon hoc: ");
            string mon = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            int tinChi = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem: ");
            double diem = double.Parse(Console.ReadLine());
            MonHoc temp = new MonHoc(mon, tinChi, diem);
            lstMonHoc.Add(temp);
        }

        public void InPhieuBaoDiem()
        {
            // do rong 78
            // 36 - 42
            int spaceMS = 36 - maSoSinhvien.Length - 18;
            int spaceTen = 42 - tenSinhVien.Length - 15;
            int spaceLop = 36 - base.GetTenLop().Length - 6;
            int spaceKhoa = 42 - base.GetKhoa().Length - 6;
            string sinhVien = "|Ma so sinh vien: " + maSoSinhvien + new string(' ', spaceMS) + "Ten sinh vien: " + tenSinhVien + new string(' ', spaceTen) + "|";
            string lopHoc = "|Lop: " + base.GetTenLop() + new string(' ', spaceLop) + "Khoa: " + base.GetKhoa() + new string(' ', spaceKhoa) + "|";
            Console.WriteLine(" " + new string('_', 77));
            Console.WriteLine("|Phieu Bao Diem" + new string(' ', 78 - 15) + "|");
            Console.WriteLine(sinhVien);
            Console.WriteLine(lopHoc);
            Console.WriteLine("|" + new string('_', 77) + "|");
            Console.WriteLine("|" + new string(' ', 77) + "|");
            Console.WriteLine("|" + new string(' ', 39 - 4) + "BANG DIEM" + new string(' ', 39 - 6) + "|");
            Console.WriteLine("|" + new string('_', 77) + "|");
            int spaceMon = 26;
            Console.WriteLine("|" + new string(' ', spaceMon - 1) + "|" + new string(' ', spaceMon - 1) + "|" + new string(' ', spaceMon - 1) + "|");
            Console.WriteLine("| Ten mon" + new string(' ', spaceMon - 9) + "| So tin chi" + new string(' ', spaceMon - 12) + "| Diem" + new string(' ', spaceMon - 6) + "|");
            Console.WriteLine("|" + new string('_', spaceMon - 1) + "|" + new string('_', spaceMon - 1) + "|" + new string('_', spaceMon - 1) + "|");

            if (lstMonHoc.Count == 0)
            {
                Console.WriteLine("|" + new string(' ', 77) + "|");
                Console.WriteLine("| Chua co mon hoc" + new string(' ', 78 - 17) + "|");
                Console.WriteLine("|" + new string('_', 77) + "|");
            }
            else
            {
                foreach (MonHoc i in lstMonHoc)
                {
                    Console.WriteLine("|" + new string(' ', spaceMon - 1) + "|" + new string(' ', spaceMon - 1) + "|" + new string(' ', spaceMon - 1) + "|");
                    Console.WriteLine(i.toString());
                    Console.WriteLine("|" + new string('_', spaceMon - 1) + "|" + new string('_', spaceMon - 1) + "|" + new string('_', spaceMon - 1) + "|");
                }
            }
        }

        public string toString()
        {
            string kq = $"MSSV: {maSoSinhvien}, Ten: {tenSinhVien}, Lop: {base.GetTenLop()}, Khoa: {base.GetKhoa()}";
            return kq;
        }
    }
}