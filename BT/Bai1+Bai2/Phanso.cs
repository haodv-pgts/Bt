using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
/*
    Bài tập 2: Xây dựng lớp Phanso gồm:

- Thuộc Tính: tuso, mauso
- Phương thức:
  + Nhập , Xuất
  + Cong(), Tru(), Nhan(), Chia()

Yêu cầu: nhập vào 2 ps1 và ps2 sau đó =>>> Tính Tổng, Hiệu, Tích, Thương của 2 phân số ps1 và ps2 rồi in kết quả ra màn hình*/
    public class Phanso
    {
        private int _tuso { get; set; }
        private int _mauso { get; set; }
        public Phanso() { }
        public Phanso(int tuso, int mauso) {
        
            _tuso = tuso;
            _mauso = mauso;

        }
        public void Nhap()
        {
            Console.WriteLine("Nhap tu so:");
            _tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so:");
            _mauso = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{_tuso}/{_mauso}");
        }

        public Phanso Add(Phanso Orther)
        {
            _tuso = _tuso * Orther._mauso + Orther._tuso * _mauso;
            _mauso = _mauso * Orther._mauso;
            return ToiGian(_tuso, _mauso);
        }

        public Phanso Subtract(Phanso Orther)
        {
            _tuso = _tuso * Orther._mauso - Orther._tuso * _mauso;
            _mauso = _mauso * Orther._mauso;
            return ToiGian(_tuso, _mauso);
        }

        public Phanso Multiply(Phanso Orther)
        {
            _tuso = _tuso * Orther._tuso;
            _mauso = _mauso * Orther._mauso;
            return ToiGian(_tuso, _mauso);
        }
        public Phanso Divide(Phanso Orther)
        {

            _tuso = _tuso * Orther._mauso;
            _mauso = _mauso * Orther._tuso;
            return ToiGian(_tuso,_mauso);
        }

        public Phanso ToiGian(int tuso, int mauso)
        {

            int gcd = GCD(tuso,mauso);
            return new Phanso(tuso / gcd, mauso / gcd);
        }

        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
