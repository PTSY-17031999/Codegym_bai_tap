using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classhinh_chu_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao Chieu_dai:");
            double Chieu_dai = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao Chieu_rong:");
            double Chieu_rong = Double.Parse(Console.ReadLine());


            Hinh_chu_nhat _Hinh_chu_nhat = new Hinh_chu_nhat(Chieu_dai, Chieu_rong);


            Console.WriteLine( _Hinh_chu_nhat.Hien_thi());
            Console.WriteLine("Chu vi hinh chu nhat là: " + _Hinh_chu_nhat.Tinh_chu_vi());
            Console.WriteLine("Dien tich hinh chu nhat la: " + _Hinh_chu_nhat.Tinh_dien_tich());

            Console.ReadKey();
        }

    }

    public class Hinh_chu_nhat
    {
        double Chieu_dai, Chieu_rong;

        public Hinh_chu_nhat()
        {
        }

        public Hinh_chu_nhat(double Chieu_dai, double Chieu_rong)
        {
            this.Chieu_dai   = Chieu_dai;
            this.Chieu_rong = Chieu_rong;
        }

        public double Tinh_dien_tich()
        {
            return this.Chieu_dai * this.Chieu_rong;
        }

        public double Tinh_chu_vi()
        {
            return (this.Chieu_dai + this.Chieu_rong) * 2;
        }

        public String Hien_thi()
        {
            return "Hinh_chu_nhat{" + "Chieu_dai=" + Chieu_dai + ", Chieu_rong=" + Chieu_rong + "}";
        }
    }
}