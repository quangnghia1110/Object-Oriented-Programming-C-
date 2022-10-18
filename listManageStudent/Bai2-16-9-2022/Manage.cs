using System;
using System.Collections.Generic;

namespace BaiTapQLSV
{
    class SinhVien
    {
        private List<SinhVien>
            ListSinhVien = null;

        public SinhVien()
        {
            ListSinhVien = new List<SinhVien>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        
        public string Address { get; set; }


        private int GenerateID()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].ID;
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (max < sv.ID)
                    {
                        max = sv.ID;
                    }
                }
                max++;
            }
            return max;
        }

        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }

        public void NhapSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.ID = GenerateID();
            Console.Write("Nhập tên sinh viên: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhâp giới tính của sinh viên: ");
            sv.Sex = Convert.ToString(Console.ReadLine());

            Console.Write("Nhâp địa chỉ của sinh viên: ");
            sv.Address = Convert.ToString(Console.ReadLine());

            DateTime _NgaySinh = DateTime.Now;
            Console.Write("Nhập ngày sinh của sinh viên: ");
            try
            {
                _NgaySinh = DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Sai định dạng ngày");
                Console.ReadLine();
                Console.Write("Nhập ngày sinh của sinh viên: ");
                _NgaySinh = DateTime.Parse(Console.ReadLine());
            }
            ListSinhVien.Add(sv);
        }

        public SinhVien FindByID(int ID)
        {
            SinhVien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }

        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;

            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListSinhVien.Remove(sv);
            }
            return IsDeleted;
        }

        public void ShowSinhVien(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} ", "ID", "Name", "Sex", "Age", "Address");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} ", sv.ID, sv.Name, sv.Sex, sv.Age, sv.Address);
                }
            }
            Console.WriteLine();
        }

        public List<SinhVien> getListSinhVien()
        {
            return ListSinhVien;
        }
    }
}
















