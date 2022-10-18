using System;
namespace test_3_9_9
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }


        ~Time()
        {

        }

        public Time()
        {

        }
        public Time(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }

        private Time tangGiamGiay(int key)
        {

            int soGiay = second + minute * 60 + hour * 3600;
            Console.WriteLine(soGiay);
            soGiay = soGiay + key;
            Console.WriteLine(soGiay);
            hour = soGiay / 3600;
            soGiay = soGiay % 3600;
            minute = soGiay / 60;
            second = soGiay % 60;
            return this;
        }
        public Time nextSecond()
        {
            return tangGiamGiay(1);
        }
        public Time previosSecond()
        {
            return tangGiamGiay(-1);
        }
        public string toPrint()
        {
            return $"{hour:00}:{minute:00}:{second:00}";
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Hour: ");
                Hour= Convert.ToInt16(Console.ReadLine());
            } while (Hour < 0 || Hour > 23);


            do
            {
                Console.Write("Minute: ");
                Minute= Convert.ToInt16(Console.ReadLine());
            } while (Minute < 0 || Minute > 59);

            do
            {
                Console.Write("Second: ");
                Second = Convert.ToInt16(Console.ReadLine());
            } while (Second < 0 || Hour > 59);

          

        }
    }
}