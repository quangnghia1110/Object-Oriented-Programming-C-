using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookAuthors
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.IndexOf('@') == -1)
                    email = null;
                else
                    email = value;
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value != 'm' && value != 'f' && value != 'M' && value != 'F')
                    gender = 'u';
                else
                    gender = value;
            }
        }

        public Author(string name, string email, char gender)
        {
            Name = name;
            Gender = gender;
            if (gender != 'm' && gender != 'f' && gender != 'M' && gender != 'F')
                Gender = 'u';
            if (CheckEmail(email) == false)
            {
                this.email = null;
            }
            else
            {
                this.email = email;
            }
        }

        private bool CheckEmail(string email)
        {
            bool kiemTraKyTu = true;
            if (email[0] == '.' || email[email.Length - 1] == '.')
                kiemTraKyTu = false;
            for (int i = 0; i < email.Length; i++)
            {
                char x = email[i];
                if ((x < '0' || x > '9') && (x < 'A' || x > 'z') && (x != '@') && (x != '.'))
                {
                    kiemTraKyTu = false;
                    break;
                }
            }
            bool ketQua = kiemTraKyTu && email.Contains("@");
            return ketQua;
        }

        static public bool IsValidEmail(string email)
        {
            bool kiemTraKyTu = true;
            if (email[0] == '.' || email[email.Length - 1] == '.')
                kiemTraKyTu = false;
            for (int i = 0; i < email.Length; i++)
            {
                char x = email[i];
                if ((x < '0' || x > '9') && (x < 'A' || x > 'z') && (x != '@') && (x != '.'))
                {
                    kiemTraKyTu = false;
                    break;
                }
            }
            bool ketQua = kiemTraKyTu && email.Contains("@");
            return ketQua;
        }

        static public bool IsValidGender(char gender)
        {
            if (gender == 'm' || gender == 'f' || gender == 'u' || gender == 'M' || gender == 'F' || gender == 'U')
                return true;
            return false;
        }

        

        public string toString()
        {
            string kq = $"{Name} ({Gender}) at {Email}";
            return kq;
        }
    }
}