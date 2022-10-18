using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMoneyBill
{
    class KhachHang
    {
        private string hoTen;
        private int soNha;
        private int maSo;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int SoNha { get => soNha; set => soNha = value; }
        public int MaSo { get => maSo; set => maSo = value; }
        public KhachHang()
        {
            hoTen = "";
            soNha = 0;
            maSo = 0;
        }
        public KhachHang(string hoTen, int soNha, int maSo)
        {
            HoTen = hoTen;
            SoNha = soNha;
            MaSo = maSo;
        }
        public string toString()
        {
            string kq = $"Họ và Tên: {HoTen},Số Nhà: {SoNha},Mã Số: {MaSo}";
            return kq;
        }
    }
}
