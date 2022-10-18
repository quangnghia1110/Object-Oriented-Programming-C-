using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2_9_9
{
    class SinhVien
    {
        private string maSo;
        private string hoTen;
        private int namSinh;              
        //khởi tạo mặc định
        SinhVien()
        {
            this.maSo = "";
            this.hoTen = "";
            this.namSinh = 0;
        }
        //hủy khởi tạo
        ~SinhVien()
        {

        }
        //tạo phương thức
        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        //khởi tạo phương thức
        public SinhVien(string maSo,string hoTen,int namSinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen; 
            this.namSinh = namSinh;
        }
        public int In()
        {
            string kq;
            kq = $"Ma so: {MaSo} - Ho ten: {HoTen} - Nam sinh: {NamSinh}";
            return kq;
        }


        
    }
}
