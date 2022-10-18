using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_HocSinh
{
    class MonHoc
    {
        private string tenMon = "Choi";
        private int soTinChi = 0;
        private double diem = 0;

        public string GetTenMon() { return this.tenMon; }
        public void SetTenMon(string tenMon) { this.tenMon = tenMon; }
        public int GetSoTinChi() { return this.soTinChi; }
        public void SetSoTinChi(int soTinChi) { this.soTinChi = soTinChi; }
        public double GetDiem() { return this.diem; }
        public void SetDiem(double diem) { this.diem = diem; }

        public MonHoc() { }
        public MonHoc(string tenMon, int soTinChi, double diem)
        {
            this.tenMon = tenMon;
            this.soTinChi = soTinChi;
            this.diem = diem;
        }

        
    }
}