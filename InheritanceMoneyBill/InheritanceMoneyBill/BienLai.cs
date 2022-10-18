using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMoneyBill
{
    class BienLai:KhachHang
    {
        private double soMoi;
        private double soCu;
        public double SoMoi { get => soMoi; set => soMoi = value; }
        public double SoCu { get => soCu; set => soCu = value; }
        public BienLai()
        {
            soMoi = 0;
            soCu = 0;
        }
        public BienLai(double soMoi, double soCu)
        {
            SoMoi = soMoi;
            SoCu = soCu;
        }

        public BienLai(double soMoi, double soCu, string hoTen, int soNha, int maSo):base(hoTen,soNha,maSo)
        {
            SoMoi = soMoi;
            SoCu = soCu;
            HoTen = hoTen;
            SoNha = soNha;
            MaSo = maSo;
        }
        public double tinhTien()
        {
            double kq = (SoMoi - SoCu) * 750;
            return kq;
        }
        
        public string toString()
        {
            string kq = base.toString() + $",Số Mới: {SoMoi},Số Cũ: {SoCu}";
            return kq;
        }
    }
}
