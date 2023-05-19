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
            // Bài tập ĐỌC SỐ THANH CHỮ
            Bai_tap_chuyen_so_thanh_chu();


            /************************/
            // Bài tập tính chỉ số căn nặng BMI
            //bai_tap_tinh_chi_so_BMI();


            /************************/
            // Bài tập buổi 3a Giải phương trình bặc 2 Ax^2 + Bx + C = 0 ( năng cao)
            //bai_tap_giai_phuong_trinh_bac_2();


            /************************/
            //Tính số ngày tới sinh nhật
            // bai_tap_buoi_2();


            /*************************/
            //Bài tập xây dựng ứng dụng tiền tệ 
            // CHƯA XONG


            /*************************/
            //Hiện thị lời chào
            //Bai_tap_buoi_1c();


            /*************************/
            //Sử dụng toán tử
            //Bai_tap_buoi_1b();


            /************************/
            //Hiện thị thời gian hệ thống
            //Bai_tap_buoi_1a();




            Console.ReadKey();
        }



        static void Bai_tap_chuyen_so_thanh_chu()
        {

            Console.WriteLine(/************************************/);
            double so_can_chuyen_doi = 0;

            Console.Write("Hay nhap so ban can chuyen doi sang chu: ");
            String Input_so = Console.ReadLine();

            while (!double.TryParse(Input_so, out so_can_chuyen_doi) || Input_so.Length > 9)
            {
                Console.Write("Hay nhap lai con so: ");
                Input_so = Console.ReadLine();
            }

            string Out_chu = "";



            for (int i = 0; i < Input_so.Length; i++)
            {
                switch (int.Parse(Input_so.Substring(i, 1)))
                {
                    case 0:
                        Out_chu = Out_chu + " Khong";
                        break;
                    case 1:
                        //if(i != )
                        Out_chu = Out_chu + " Mot";
                        break;
                    case 2:
                        Out_chu = Out_chu + " Hai";
                        break;
                    case 3:
                        Out_chu = Out_chu + " Ba";
                        break;
                    case 4:
                        Out_chu = Out_chu + " Bon";
                        break;
                    case 5:
                        Out_chu = Out_chu + " Nam";
                        break;
                    case 6:
                        Out_chu = Out_chu + " Sau";
                        break;
                    case 7:
                        Out_chu = Out_chu + " Bay";
                        break;
                    case 8:
                        Out_chu = Out_chu + " Tam";
                        break;
                    case 9:
                        Out_chu = Out_chu + " Chin";
                        break;
                }

                switch (Input_so.Length -i)
                {
                    case 2:
                        Out_chu = Out_chu + " Muoi";
                        break;
                    case 3:
                        Out_chu =  Out_chu + " Tram";
                        break;
                    case 4:
                        Out_chu = Out_chu + " Ngan" ;
                        break;
                    case 5:
                        Out_chu = Out_chu + " Muoi";
                        break;
                    case 6:
                        Out_chu = Out_chu + " Tram";
                        break;
                    case 7:
                        Out_chu =  Out_chu + " Nghin";
                        break;
                    case 8:
                        Out_chu = Out_chu + " Ty";
                        break;
                    case 9:
                        Out_chu = Out_chu + " Chuc";
                        break;
                    default:
                        break;
                }
            


            }

            Console.WriteLine("Thanh chu: " + Out_chu);

        }



        static void bai_tap_tinh_chi_so_BMI()
        {
            double Can_nang = 0, Chieu_cao = 0, bmi = 0;

            Console.Write("Hay nhap can nang cua ban (Kg): ");
            String Input_Can_nang = Console.ReadLine();
            Console.Write("Hay nhap chieu cao cua ban (cm): ");
            String Input_Chieu_cao = Console.ReadLine();

            while (!double.TryParse(Input_Can_nang, out Can_nang))
            {
                Console.Write("Can nang phai la so, hay nhap lai can nang (Kg): ");
                Input_Can_nang = Console.ReadLine();
            }
            while (!double.TryParse(Input_Chieu_cao, out Chieu_cao))
            {
                Console.Write("Chieu cao phai là so, hay nhap lai chieu cao (Cm): ");
                Input_Chieu_cao = Console.ReadLine();
            }

            bmi = Can_nang / ((Chieu_cao * 2) / 100);

            if (bmi < 18.5)
            {
                Console.Write("Ban dang gay, de dat duoc than hinh dep hay tang len: " + ((18.5 * 2 * (Chieu_cao / 100)) - Can_nang) + " kg");
            }
            else if (bmi < 25)
            {
                Console.Write("Than hinh qua ban dang dep! ");
            }
            else if (bmi < 30)
            {
                Console.Write("Ban dang map, de dat duoc than hinh dep hay giam di: " + (Can_nang - (25 * 2 * (Chieu_cao / 100))) + " kg");
            }
            else
            {
                Console.Write("Ban dang qua map, de dat duoc than hinh dep hay giam di: " + (Can_nang - (25 * 2 * (Chieu_cao / 100))) + " kg");
            }
        }


     static void bai_tap_giai_phuong_trinh_bac_2()
        {
            Console.WriteLine("********** Giai phuong trinh bac 2 Ax^2 + Bx + C = 0 **********");
            double a_3a = 0, b_3a = 0, c_3a = 0;
            Console.Write("Hay nhap so A: ");
            String Input_a_3a = Console.ReadLine();
            Console.Write("Hay nhap so B: ");
            String Input_b_3a = Console.ReadLine();
            Console.Write("Hay nhap so C: ");
            String Input_c_3a = Console.ReadLine();

            while (!double.TryParse(Input_a_3a, out a_3a))
            {
                Console.Write("Hay nhap lai so A: ");
                Input_a_3a = Console.ReadLine();
            }
            while (!double.TryParse(Input_b_3a, out b_3a))
            {
                Console.Write("Hay nhap lai so B: ");
                Input_b_3a = Console.ReadLine();
            }
            while (!double.TryParse(Input_c_3a, out c_3a))
            {
                Console.Write("Hay nhap lai so C: ");
                Input_c_3a = Console.ReadLine();
            }

            double dt = b_3a * b_3a - (4 * a_3a * c_3a);

            if (dt == 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem la : " + ((0 - b_3a) / (2 * a_3a)));
            }
            else if (dt > 0)
            {
                var x1 = (-b_3a - Math.Sqrt(b_3a)) / (2 * a_3a);
                var x2 = (-b_3a + Math.Sqrt(b_3a)) / (2 * a_3a);
                Console.WriteLine("Phuong trinh co 2 nghiem la : " + " X1= " + ((-b_3a - Math.Sqrt(b_3a)) / (2 * a_3a)) + ", X2= " + ((-b_3a + Math.Sqrt(b_3a)) / (2 * a_3a)));
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

        }


    static void bai_tap_buoi_2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhap ngay sinh (dd/MM/yyyy):");
            string du_lieu_vao = Console.ReadLine();
            DateTime Ngay_sinh = DateTime.Parse( du_lieu_vao);
            DateTime Thoi_gian_hien_tai = DateTime.Now;
           

           

            DateTime Ngay_sinh_nhat_nam_nay = new DateTime(Thoi_gian_hien_tai.Year, Ngay_sinh.Month, Ngay_sinh.Day);

            if (Thoi_gian_hien_tai < Ngay_sinh_nhat_nam_nay)
            {
                Console.WriteLine("So ngay con lai den sinh nhat 1: " + Math.Round(( Ngay_sinh_nhat_nam_nay - Thoi_gian_hien_tai).TotalDays , 0));
            } else
            {
                Console.WriteLine("So ngay con lai den sinh nhat 2: " + Math.Round((Ngay_sinh_nhat_nam_nay.AddYears(1) - Thoi_gian_hien_tai).TotalDays, 0));
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
