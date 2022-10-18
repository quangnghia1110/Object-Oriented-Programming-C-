using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_HocSinh
{
    class LopHoc
    {
        private string tenLop = "Chua vao";
        private string khoa = "Trai Dat";

        public void SetTenLop(string tenLop) { this.tenLop = tenLop; }
        public string GetTenLop() { return this.tenLop; }
        public void SetKhoa(string khoa) { this.khoa = khoa; }
        public string GetKhoa() { return this.khoa; }

        public LopHoc() { }
        public LopHoc(string tenLop, string khoa)
        {
            this.tenLop = tenLop;
            this.khoa = khoa;
        }

    }
}