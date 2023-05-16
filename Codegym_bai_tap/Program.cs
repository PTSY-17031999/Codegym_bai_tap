using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codegym_bai_tap
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Nhap ngay sinh (dd/MM/yyyy):");
           DateTime Ngay_sinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            DateTime Thoi_gian_hien_tai = DateTime.Now;
            //Thoi_gian_hien_tai = String.Format("{DateTime.Now}", dt); 
            //DateTime ngaySinhNhatTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);

            TimeSpan Thoi_gian_toi_ngay_sinh_nhat = Ngay_sinh.Subtract(Thoi_gian_hien_tai);
            if (int.Parse(((Thoi_gian_toi_ngay_sinh_nhat).Days).ToString()) > 0)
            {
                Console.WriteLine("So ngay con lai den sinh nhat 1: " + Thoi_gian_toi_ngay_sinh_nhat.Days);
            }

            if (int.Parse(((Thoi_gian_toi_ngay_sinh_nhat).Days).ToString()) == 0 )
            {
                Console.WriteLine("Chuc ban co mot ngay sinh nhat vui ve !");
            }

            if (int.Parse(((Thoi_gian_toi_ngay_sinh_nhat).Days).ToString()) < 0)
            {
                // Móc thời gian 01/01/1900
                DateTime Thoi_gian_moc_thoi_gian = new DateTime(1900, 01, 01);
                // Ngày sinh nhật tiếp theo 
                DateTime Ngay_sinh_nhat_tiep_theo = new DateTime(Ngay_sinh.Year + 1, Ngay_sinh.Month, Ngay_sinh.Day);
                // Số ngày tới sinh nhật
                TimeSpan Thoi_gian_tu_moc_toi_ngay_sinh_nhat_2 = Thoi_gian_moc_thoi_gian.Subtract(Ngay_sinh_nhat_tiep_theo) ;
                TimeSpan Thoi_gian_tu_moc_toi_hom_nay = Thoi_gian_moc_thoi_gian.Subtract(Thoi_gian_hien_tai);
                Console.WriteLine("So ngay con lai den sinh nhat 2: " + ( Thoi_gian_tu_moc_toi_hom_nay.Days- Thoi_gian_tu_moc_toi_ngay_sinh_nhat_2.Days ));
            }
                //Console.WriteLine(Thoi_gian_hien_tai.Year);



                Console.ReadKey();
        }
    }
}
