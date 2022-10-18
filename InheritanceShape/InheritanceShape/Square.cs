using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Square:Rectangle
    {
        public Square()
        {

        }
        public Square(double side)
        {
            this.Width = side;
            this.Length = side;
        }
        // không thêm base do không kế thừa không đủ
        public Square(double side,string color,bool filled)
        {
            this.Width = side;
            this.Length=side;
            this.Color = color;
            this.Filled = filled;
        }
        public void setWidth(double side)
        {
            this.Width = side;
        }
        public void setLength(double side)
        {
            this.Length = side;
        }
        public string toString()
        {
            string kq =$"Color={Color},Filled{Filled},Width={Width}";
            return kq;
        }
    }
}
