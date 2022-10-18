using System;
namespace relationClass
{
    class Date
    {
        private int _ngay, _thang, _nam;

        public int Ngay { get => _ngay; set => _ngay = value; }
        public int Thang { get => _thang; set => _thang = value; }
        public int Nam { get => _nam; set => _nam = value; }

        public Date()
        {
            _ngay = 1;
            _thang = 1;
            _nam = 1;
        }
        
        public Date(int ngay, int thang, int nam)
        {
            _ngay = ngay;
            _thang = thang;
            _nam = nam;
        }

        ~Date(){

        }

       

        public string toString()
        {
            string kq;
            kq = $"{Ngay}/{Thang}/{Nam}";
            return kq;
        }
    }
}
