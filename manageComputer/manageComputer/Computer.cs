using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace manageComputer
{
    internal class Computer
    {
        private string loaiMay;
        private string noiSanXuat;
        private int thoiGianBaoHanh;

        public string LoaiMay { get => loaiMay; set => loaiMay = value; }
        public string NoiSanXuat { get => noiSanXuat; set => noiSanXuat = value; }
        public int ThoiGianBaoHanh { get => thoiGianBaoHanh; set => thoiGianBaoHanh = value; }

        public Computer(string loaiMay, string noiSanXuat, int thoiGianBaoHanh)
        {
            LoaiMay = loaiMay;
            NoiSanXuat = noiSanXuat;
            ThoiGianBaoHanh = thoiGianBaoHanh;
        }

        ~Computer()
        {

        }
        public string toString()
        {
            string ketQua = $"Loại máy: {loaiMay} - Nơi sản xuất: {noiSanXuat} - Thời gian bảo hành: {thoiGianBaoHanh}";
            return ketQua;
        }
        public int KiemTraThoiGianBaoHanh()
        {
            
            if (thoiGianBaoHanh == 1)
            {
                return 1 ;
            }
            return 0;
        }
        public int KiemTraXuatXu()
        {
            int DEM = 0;
            if((noiSanXuat=="My")|| (noiSanXuat == "mY")|| (noiSanXuat == "my")|| (noiSanXuat == "MY"))
            {
                DEM++;
            }
            return DEM;
        }
    }


}
