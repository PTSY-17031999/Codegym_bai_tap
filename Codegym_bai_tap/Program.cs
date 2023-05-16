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


            /************************/
            //Bài tập buổi 2 Tính số ngày tới sinh nhật
            bai_tap_buoi_2();


            /*************************/
            //Bài tập xây dựng ứng dụng tiền tệ 
           // CHƯA XONG


            /*************************/
            // Bài tập buổi 1c: Hiện thị lời chào
            //Bai_tap_buoi_1c();
            

            /*************************/
            // Bài tập buổi 1b: Sử dụng toán tử
            //Bai_tap_buoi_1b();


            /************************/
            //Bài tập buổi 1a: Hiện thị thời gian hệ thống
            //Bai_tap_buoi_1a();




            Console.ReadKey();
        }
        static void bai_tap_buoi_2()
        {
            Console.Write("Nhap ngay sinh (dd/MM/yyyy):");
            DateTime Ngay_sinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            DateTime Thoi_gian_hien_tai = DateTime.Now;

            TimeSpan Thoi_gian_toi_ngay_sinh_nhat = Ngay_sinh.Subtract(Thoi_gian_hien_tai);
            if (int.Parse(((Thoi_gian_toi_ngay_sinh_nhat).Days).ToString()) > 0)
            {
                Console.WriteLine("So ngay con lai den sinh nhat 1: " + Thoi_gian_toi_ngay_sinh_nhat.Days);
            }

            if (int.Parse(((Thoi_gian_toi_ngay_sinh_nhat).Days).ToString()) == 0)
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
                TimeSpan Thoi_gian_tu_moc_toi_ngay_sinh_nhat_2 = Thoi_gian_moc_thoi_gian.Subtract(Ngay_sinh_nhat_tiep_theo);
                TimeSpan Thoi_gian_tu_moc_toi_hom_nay = Thoi_gian_moc_thoi_gian.Subtract(Thoi_gian_hien_tai);
                Console.WriteLine("So ngay con lai den sinh nhat 2: " + (Thoi_gian_tu_moc_toi_hom_nay.Days - Thoi_gian_tu_moc_toi_ngay_sinh_nhat_2.Days));
            }
        }

    static void Bai_tap_1d()
        {/*
            int ti_gia = 23000;
            Console.WriteLine("Nhập số 1 để chuyển đổi VND sang USD");
            Console.WriteLine("Nhập số 2 để chuyển đổi USD sang VND");
            int.TryParse(Console.ReadLine(),
            // Nếu người dùng nhập chữ
            if (int.TryParse(Console.ReadLine(), ))
                int lua_chon_1d = int.Parse(Console.ReadLine());
            Console.WriteLine(lua_chon_1d);
            if (lua_chon_1d == 1)
            {
                Console.Write("Nhập số tiền VND: ");
            }*/
        }


    static void Bai_tap_buoi_1c()
        { 
            Console.WriteLine("Nhập tên của bạn: ");
            string ten_1c = Console.ReadLine();
            Console.WriteLine("Chào bạn: " + ten_1c);
        }

    static void Bai_tap_buoi_1b()
        {
            float width;
            float height;

            Console.Write("Nhập vào chiều dài: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Nhập vào chiều rộng: ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Diện tích hình chữ nhật là: " + (width * height).ToString());

        }

    static void Bai_tap_buoi_1a()
        {
            DateTime Thoi_gian_hien_tai_1a = DateTime.Now;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Thời gian hiện tại là : " + String.Format("{ HH:mm:ss 0:d/M/yyyy }", Thoi_gian_hien_tai_1a));
        }














            
        }
    }
