using System;
using System.Text;
namespace BT3
{
    class Author
    {
        //Fields
        private string name;
        private char gender;
        private DateTime birthday;
        private string email;
        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != 'm' && value != 'f')
                {
                    gender = 'u';
                }
                else
                {
                    gender = value;
                }
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
                if (birthday.Year < 1900 || birthday.Year > 9999)
                {
                    birthday = new DateTime(1900, 1, 1);
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (CheckEmail(value) == false)
                {
                    email = null;
                }
                else
                {
                    email = value;
                }

            }
        }
        //Check email
        private bool CheckEmail(string email)
        {
            bool kiemTraKyTu = true;
            //Không chứa ký tự đặc biệt h @
            for (int i = 0; i < email.Length; i++)
            {
                char x = email[i];
                if ((x < '0' || x > '9') && (x < 'A' || x > 'z') && (x
               != '@'))
                {
                    kiemTraKyTu = false;
                    break;
                }
            }
            bool ketQua = kiemTraKyTu && email.Contains("@"); 
            //Kiem tra xem chuoi co chua @
            return ketQua;
        }
        //Constructor
       
    
        public Author(string name, char gender, DateTime birthday,
       string email)
        {
            this.name = name;
            this.gender = gender;
            if (gender != 'm' && gender != 'f')
            {
                this.gender = 'u';
            }
            this.birthday = birthday;
            //Check email
            if (CheckEmail(email) == false)
            {
                this.email = null;
            }
            else
            {
                this.email = email;
            }
            this.birthday = DateTime.ParseExact("01/01/1900","dd/MM/yyyy", null);
        }
        //Create Email
        public string CreateEmail(string domain)
        {
            string sEmail = "";
            string Tam = name;
            //Chuyển chữ thường
            Tam = Tam.ToLower();
            //Xóa khoảng trắng
            for (int i = 0; i < Tam.Length; i++)
            {
                if (Tam[i] == ' ')
                {
                    Tam = Tam.Replace(" ", "");
                }
            }
            //Them domain
            sEmail = Tam + "@" + domain;
            return sEmail;
        }
        //Get Age
        public int GetAge()
        {
            int Tuoi = DateTime.Now.Year - birthday.Year;
            return Tuoi;
        }
        //Print
        public string Print()
        {
            string sKQ = "";
            sKQ = name + " (" + gender + " - " + GetAge() + ") " +
           email;
            return sKQ;
        }
    }
}