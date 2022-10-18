using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTeacher
{
    class GVCN:GiangVien
    {
        private string tenLopChuNhiem;
        private double phuCapChuNhiem;
        public string TenLopChuNhiem { get => tenLopChuNhiem; set => tenLopChuNhiem = value; }
        public double PhuCapChuNhiem { get => phuCapChuNhiem; set => phuCapChuNhiem = value; }
        public GVCN()
        {
            this.tenLopChuNhiem = "";
            this.phuCapChuNhiem = 0;
        }
        ~GVCN()
        {

        }
        public GVCN(string hoTen, string soDienThoai, string diaChi, int namSinh, double heSoLuong, double luongCanBan,string tenLopChuNhiem, double phuCapChuNhiem):base(hoTen,soDienThoai,diaChi,namSinh,heSoLuong,luongCanBan)
        {
            this.TenLopChuNhiem = tenLopChuNhiem;
            this.PhuCapChuNhiem = phuCapChuNhiem;
        }
        //kế thừa hoàn toàn mới 
        public new double tinhLuong()
        {
            return LuongCanBan * HeSoLuong + phuCapChuNhiem;
        }
        public new string toString()
        {
           
            string kq=base.toString()+ $" - {tenLopChuNhiem} - {phuCapChuNhiem}";
            return kq;
        }
    }
}
