using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relationClass
{
    internal class Student
    {
        private int maSo;
        private string hoTen;
        private Date namSinh;

        public int MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public Date NamSinh { get => namSinh; set => namSinh = value; }

        public Student()
        {
            maSo = 0;
            hoTen = "";
            namSinh = new Date(1,1,1900);
        }
        public Student(int maSo, string hoTen, Date namSinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        public string toString()
        {
            string kq;
            kq = $"{MaSo}--{HoTen}--{NamSinh.toString()}";
            return kq;
        }
    }
}
