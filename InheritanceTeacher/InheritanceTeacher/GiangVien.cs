using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTeacher
{
    class GiangVien
    {
        private string hoTen;
        private string soDienThoai;
        private string diaChi;
        private int namSinh;
        private double heSoLuong;
        private double luongCanBan;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double LuongCanBan { get => luongCanBan; set => luongCanBan = value; }
        public GiangVien()
        {
            this.hoTen = "";
            this.soDienThoai = "";
            this.diaChi = "";
            this.namSinh = 1;
            this.heSoLuong = 0;
            this.luongCanBan = 0;
        }
        ~GiangVien()
        {

        }
        public GiangVien(string hoTen, string soDienThoai, string diaChi, int namSinh, double heSoLuong, double luongCanBan)
        {
            this.hoTen = hoTen;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
            this.namSinh = namSinh;
            this.heSoLuong = heSoLuong;
            this.luongCanBan = luongCanBan;
        }
        public int tinhTuoiVeHuu()
        {
            return namSinh + 60;
        }
        public double tinhLuong()
        {
            return luongCanBan * heSoLuong;
        }
        public string toString()
        {
            string kq;
            kq = $"{hoTen} - {soDienThoai} - {diaChi} - {namSinh}";
            return kq;
        }

    }
}
