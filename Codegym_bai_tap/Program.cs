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

            #region Bài tập về mảng


            /***************************/
            //Mảng hai chiều – tạo bản đồ trò chơi MineSweeper
            tao_ban_do_game_MineSweeper();

            /**************************/
            //Mảng hai chiều – tính tổng các số ở đường chéo chính của ma trận vuông
            //tinh_tong_duong_cheo_hinh_vuong_cua_mang_2_chieu();

            /**************************/
            //Tìm phần tử lớn nhất trong mảng hai chiều
            //Tim_gia_tri_nho_va_lon_nhat_trong_mang_2_chieu();

            /*************************/
            // Thêm phần tử vào mảng
            //Them_phan_tu_vao_mang();

            /*************************/
            // Tìm giá trị lớn nhất trong mảng
            //tim_gia_tri_lon_nhat_trong_mang();

            /*************************/
            // Tìm giá trị trong mảng
            // tim_gia_tri_tron_mang();

            /*************************/
            // Tính tổng phần tử trong mảng
            //tinh_tong_cac_so_trong_mang();

            #endregion

            #region Bài tập câu lệnh lập 
            /*************************/
            // Xây dựng ứng dụng menu và hiện thị các loại hình
            //thiet_ke_ung_dung_menu_va_hien_thi_cac_loai_hinh();

            /*************************/
            //Tìm số nguyên tố
            //tim_so_nguyen_to();
            #endregion

            #region Bài tập Câu điều kiện
            /************************/
            // Bài tập ĐỌC SỐ THANH CHỮ
            //Bai_tap_chuyen_so_thanh_chu();


            /************************/
            // Bài tập tính chỉ số căn nặng BMI
            //bai_tap_tinh_chi_so_BMI();


            /************************/
            // Bài tập buổi 3a Giải phương trình bặc 2 Ax^2 + Bx + C = 0 ( năng cao)
            //bai_tap_giai_phuong_trinh_bac_2();
            #endregion

            #region bài tập C# cơ bản
            /************************/
            //Tính số ngày tới sinh nhật
            // bai_tap_buoi_2();

            /*************************/
            //Bài tập xây dựng ứng dụng tiền tệ 
            //ung_dung_chuyen_doi_tien_te();

            /*************************/
            //Hiện thị lời chào
            //Bai_tap_buoi_1c();

            /*************************/
            //Sử dụng toán tử
            //Bai_tap_buoi_1b();

            /************************/
            //Hiện thị thời gian hệ thống
            //Bai_tap_buoi_1a();
            #endregion





            Console.ReadKey();
        }

        #region Các hàm bài tập
/*******************************************************************************************************************************************************/
       static void tao_ban_do_game_MineSweeper(){


        // Kích thước bản đồ
        int Chieu_dai_ban_do = 6, Chieu_rong_ban_do = 6;

        // Mảng bản đồ chưa chuyển đổi
        string[,] ban_do_1 = new string[,]{
        { "*" , ".", "*", ".", "*", "." },
        { "*" , ".", ".", ".", "*", "." },
        { "*" , ".", ".", "*", "*", "." },
        { "*" , ".", ".", ".", "*", "." },
        { "*" , ".", ".", ".", ".", "." },
        { "*" , "*", ".", ".", "*", "." },
                                            };

        //Hiện thị mảng củ
        for (int i = 0; i<Chieu_dai_ban_do; i++)
        {
            for (int j = 0; j<Chieu_rong_ban_do; j++)
            {
                if (ban_do_1[i, j].Equals("*"))
                {
                    Console.Write("*");
                } else Console.Write(".");
            }
Console.WriteLine();
        }
        // Taọ mảng tọa độ mã láng giềng và vị trí đang kiểm tra
       // int x = 0, y = 0; // Tọa độ đang kiểm tra


            //Tái cấu trúc lại mảng
            
            int dem;
string[,] ban_do_2 = new string[Chieu_dai_ban_do, Chieu_rong_ban_do];
for (int x = 0; x < Chieu_dai_ban_do; x++)
{
    for (int y = 0; y < Chieu_rong_ban_do; y++)
    {
        if (ban_do_1[x, y].Equals("*")) { ban_do_2[x, y] = "*"; }
        else
        {
            // Khai báo tọa độ mảng láng giềng
            int[,] Toa_do_cua_cac_lang_gieng =
                   {
                        {x - 1, y - 1 },
                        {x - 1, y     },
                        {x - 1, y + 1 },
                        {x    , y - 1 },
                        {x    , y + 1 },
                        {x + 1, y + 1 },
                        {x + 1, y     },
                        {x + 1, y + 1 }
                    };

            dem = 0;
            for (int i = 0; i < Toa_do_cua_cac_lang_gieng.GetLength(0); i++)
            {
                int X_kiem_tra = Toa_do_cua_cac_lang_gieng[i, 0];
                int Y_kiem_tra = Toa_do_cua_cac_lang_gieng[i, 1];
                if (X_kiem_tra < 0 || X_kiem_tra >= Chieu_dai_ban_do ||
                   Y_kiem_tra < 0 || Y_kiem_tra >= Chieu_rong_ban_do) { continue; }
                if (ban_do_1[X_kiem_tra, Y_kiem_tra].Equals("*"))
                {
                    dem++;
                }
            }
            ban_do_2[x, y] = dem.ToString();
            dem = 0;


        }
    }
}



Console.WriteLine("----------------------------------------------------");
//Hiện thị mảng mới
for (int i = 0; i < Chieu_dai_ban_do; i++)
{
    for (int j = 0; j < Chieu_rong_ban_do; j++)
    {
        Console.Write(ban_do_2[i, j]);
    }
    Console.WriteLine();
}
}


/***********************************************************************************************************************************************************************/
        static void tinh_tong_duong_cheo_hinh_vuong_cua_mang_2_chieu() {

            const int x = 3; //Kích thước bảng
        int so_nho_nhat, so_lon_nhat; //Gía trị lớn nhất và nhỏ nhất của bảng
        int tong_duong_cheo = 0;


        int[,] mang_chu_so = new int[x, x];
            //Nhập giá trị cho mảng
            for (int i = 0; i<x; i++)
            {
                for (int j = 0; j<x; j++)
                {
                    Console.Write(" Nhap gia tri cho vi tri: [" + i + "," + j + "] : ");
                    mang_chu_so[i, j] = int.Parse(Console.ReadLine().ToString());
                }
            }


                //Tính tổng đường chéo {0:0} và {x:x}
               for (int i = 0; i < x; i++)
                {

                 tong_duong_cheo = tong_duong_cheo + mang_chu_so[i, i];

                }
               Console.WriteLine("Tong duong cheo : " + tong_duong_cheo);
          
              }



 /***********************************************************************************************************************************************************************/
        static void Tim_gia_tri_nho_va_lon_nhat_trong_mang_2_chieu()
        {

            const int x = 3, y = 5; //Kích thước bảng
            int so_nho_nhat, so_lon_nhat; //Gía trị lớn nhất và nhỏ nhất của bảng
            int X_max = 0, Y_max = 0, X_min = 0, Y_min = 03;
           
            int[,] mang_chu_so = new int[x, y];
            //Nhập giá trị cho mảng
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" Nhap gia tri cho vi tri: [" + i + "," + j + "] : ");
                    mang_chu_so[i, j] = int.Parse(Console.ReadLine().ToString());
                }
            }


            so_nho_nhat = mang_chu_so[0, 0];
            so_lon_nhat = mang_chu_so[0, 0];


            // Tìm vị trí lớn nhất và nhỏ nhất
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mang_chu_so[i, j] > so_lon_nhat)
                    {
                        so_lon_nhat = mang_chu_so[i, j];
                        X_max = i;
                        Y_max = j;
                    }

                    if (mang_chu_so[i, j] < so_nho_nhat)
                    {
                        so_nho_nhat = mang_chu_so[i, j];
                        X_min = i;
                        Y_min = j;
                    }
                }
            }


            // Hiện thị mảng ra màn hình
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mang_chu_so[i, j] + ", ");
                }
                Console.WriteLine();
            }

            //Hiện thị số lớn nhất
            Console.WriteLine();
            Console.WriteLine(X_min);
            Console.WriteLine("So lon nhat tai vi tri [ " + X_max + ", "+ Y_max + "] la : " + so_lon_nhat);
            Console.WriteLine("So nho nhat tai vi tri [ " + X_min + ", " + Y_min + "] la : " + so_nho_nhat);

        }


 /***********************************************************************************************************************************************************************/
        static void Them_phan_tu_vao_mang()
        {
            int[] mang_cac_so = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Add phần tử vào mảng
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap Phan tu so " + (i + 1) + " : ");
                mang_cac_so[i] = int.Parse(Console.ReadLine().ToString());
            }

            // Hiện thị các phần tử của mảng vừa nhấp
            for (int i = 0; i < mang_cac_so.Length; i++)
            {
                if (i == 0) Console.Write("Mang cu gom cac so: ");
                Console.Write(mang_cac_so[i] + ", ");
                if (i == mang_cac_so.Length - 1) Console.WriteLine();
            }



            // Nhập vị trí muốn chèn
            int Vi_tri_chen;
            do
            {
                Console.Write("Nhap vi muon chen: ");
                Vi_tri_chen = int.Parse(Console.ReadLine().ToString());
            } while (Vi_tri_chen > mang_cac_so.Length - 1);

            // Nhập số muốn chèn
            int So_muon_chen;
            Console.Write("Nhap so muon chen: ");
            So_muon_chen = int.Parse(Console.ReadLine().ToString());


            // Code để chèn thêm phần tử vào mảng
            for (int i = mang_cac_so.Length; i >= Vi_tri_chen - 1; i--)
            {
                if (i == Vi_tri_chen - 1)
                {
                    mang_cac_so[Vi_tri_chen - 1] = So_muon_chen;
                    continue;
                }
                mang_cac_so[i - 1] = mang_cac_so[i - 2];
            }

            // Hiện thị mảng mới
            for (int i = 0; i < mang_cac_so.Length; i++)
            {
                if (i == 0) Console.Write("Mang moi gom cac so: ");
                Console.Write(mang_cac_so[i] + ", ");
                if (i == mang_cac_so.Length - 1) Console.WriteLine();
            }


        }


 /***********************************************************************************************************************************************************************/
        static void tim_gia_tri_lon_nhat_trong_mang()
        {
            int so_phan_tu;
            do
            {
                Console.Write("Nhap so phan tu trong mang: ");
                so_phan_tu = int.Parse(Console.ReadLine().ToString());
            } while (so_phan_tu >= 15);


            int[] mang_cac_so = new int[so_phan_tu];

            for (int i = 0; i < so_phan_tu; i++)
            {
                Console.Write("Nhap Phan tu so " + (i + 1) + " : ");
                mang_cac_so[i] = int.Parse(Console.ReadLine().ToString());
            }
            int So_lon_nhat = mang_cac_so[0];
            for (int i = 0; i < so_phan_tu; i++)
            {
                Console.WriteLine("Gia tri cua phan tu thu " + (i + 1) + " la : " + mang_cac_so[i]);
                if (mang_cac_so[i] > So_lon_nhat) { So_lon_nhat = mang_cac_so[i]; }
            }
            Console.WriteLine("Gia tri lon nhat cua mang là: " + So_lon_nhat);

        }



/***********************************************************************************************************************************************************************/
        static void tim_gia_tri_tron_mang()
        {
            // Nhập giá trị cho mảng
            Console.WriteLine("Nhap so phan tu trong mang: ");
            int so_phan_tu = int.Parse(Console.ReadLine().ToString());

            string[] mang_sinh_vien = new string[so_phan_tu];
            for (int i = 0; i < so_phan_tu; i++)
            {
                Console.WriteLine("Nhap ten sinh vien so " + (i + 1) + " : ");
                mang_sinh_vien[i] = Console.ReadLine();
            }


            Console.WriteLine("Nhap ten sinh vien can tim: ");
            string ten_sinh_vien_can_tim = Console.ReadLine();
            bool Check_sinh_vien = false;

            for (int i = 0; i < so_phan_tu; i++)
            {
                if (mang_sinh_vien[i].Equals(ten_sinh_vien_can_tim))
                {
                    Console.WriteLine(" Co sinh vien nay trong danh sach");
                    Check_sinh_vien = true;
                }

            }
            if (Check_sinh_vien == false) Console.WriteLine(" Sinh vien nay khong co trong danh sach");
        }




/***********************************************************************************************************************************************************************/
        static void tinh_tong_cac_so_trong_mang()
        {
            Console.WriteLine("Nhap so phan tu trong mang: ");
            int so_phan_tu = int.Parse(Console.ReadLine().ToString());
            int tong_mang = 0;

            int[] mang_phan_tu = new int[so_phan_tu];
            for (int i = 0; i < so_phan_tu; i++)
            {
                Console.WriteLine("Nhap du lieu cho mang phan tu thu " + (i + 1) + " : ");
                mang_phan_tu[i] = int.Parse(Console.ReadLine().ToString());
            }
            for (int i = 0; i < so_phan_tu; i++)
            {
                tong_mang = tong_mang + mang_phan_tu[i];
            }
            Console.WriteLine("Tong cac phan tu trong mang là :  " + tong_mang);
        }




 /***********************************************************************************************************************************************************************/
        static void thiet_ke_ung_dung_menu_va_hien_thi_cac_loai_hinh()
        {
            String Input_lua_chon;
            double lua_chon;

            string Input_a;
            string Input_b;
            double a = 0; // cạnh hình vuông, chiều dai hình chữa nhật, đấy hình tam giac
            double b = 0; // Chiều cao chữa nhật và tam giac



            do
            {
                Console.WriteLine("Nhap so 1 neu ban muon ve hinh vuong ");
                Console.WriteLine("Nhap so 2 neu ban muon ve hinh chu nhat");
                Console.WriteLine("Nhap so 3 neu ban muon ve tam giac vuong");
                //Console.WriteLine("Nhap so 4 neu ban muon ve tam giac can");
                Console.WriteLine("Nhap so 4 neu ban muon thoát");
                Input_lua_chon = Console.ReadLine();

                //Input_choose = Console.ReadLine();
            }

            while (!double.TryParse(Input_lua_chon, out lua_chon) || lua_chon > 5 || lua_chon <= 0);

            switch (lua_chon)
            {
                case 1:
                    {
                        do
                        {
                            Console.WriteLine("Nhap kich hinh vuong: ");
                            Input_a = Console.ReadLine();
                        }
                        while (!double.TryParse(Input_a, out a) || a > 20 || a < 1);

                        for (int i = 1; i <= a; i++)
                        {

                            for (int i2 = 1; i2 <= a; i2++)
                            {
                                Console.Write("* ");
                                if (i2 == a)
                                {
                                    Console.WriteLine("");
                                }
                            }

                        }
                        break;
                    }
                case 2:
                    {
                        do
                        {
                            Console.WriteLine("Nhap chieu dai hinh chu nhat: ");
                            Input_a = Console.ReadLine();
                            Console.WriteLine("Nhap chieu rộng hinh chu nhat: ");
                            Input_b = Console.ReadLine();
                        }
                        while (!double.TryParse(Input_a, out a) || !double.TryParse(Input_b, out b) || a > 20 || b > 20 || a < 1 || b < 1);

                        for (int i = 1; i <= b; i++)
                        {

                            for (int i2 = 1; i2 <= a; i2++)
                            {
                                Console.Write("* ");
                                if (i2 == a)
                                {
                                    Console.WriteLine("");
                                }
                            }

                        }
                        break;
                    }
                case 3:
                    {
                        do
                        {
                            Console.WriteLine("Nhap chieu dai day: ");
                            Input_a = Console.ReadLine();
                            Console.WriteLine("Nhap chieu cao lon hon 2: ");
                            Input_b = Console.ReadLine();
                        }
                        while (!double.TryParse(Input_a, out a) || !double.TryParse(Input_b, out b) || a > 20 || b > 20 || a < 2 || b < 2);

                        for (int i = 1; i <= b + 1; i++)
                        {

                            for (int i2 = i; i2 <= a; i2++)
                            {
                                Console.Write("* ");
                                if (i2 == a)
                                {
                                    Console.WriteLine("");
                                }
                            }

                        }
                        break;
                    }
                case 4:
                    {
                        return;

                        do
                        {
                            Console.WriteLine("Nhap chieu dai day phai la so le lon hon 3: ");
                            Input_a = Console.ReadLine();
                            Console.WriteLine("Nhap chieu cao lon hon 2: ");
                            Input_b = Console.ReadLine();
                        }
                        while (!double.TryParse(Input_a, out a) || !double.TryParse(Input_b, out b) || a > 20 || b > 20 || a < 3 || b < 2);

                        for (int i = 0; i <= b; i++)
                        {

                            for (int i2 = i; i2 <= a; i2++)
                            {
                                Console.Write("  ");
                                if (i2 == a / 2 - i || i2 == a / 2 + i)
                                {
                                    Console.Write("*");
                                }
                                if (i2 > a)
                                {
                                    Console.WriteLine("");
                                }
                            }

                        }
                        break;

                    }
                case 5: return;
                default: break;
            }

        }




/***********************************************************************************************************************************************************************/
        static void tim_so_nguyen_to()
        {
            string Input_so;
            int dem_ = 1;
            double so_can_kiem_tra;

            do
            {
                Console.Write("Nhap so ban muon kiem tra: ");
                Input_so = Console.ReadLine();
            }
            while (!double.TryParse(Input_so, out so_can_kiem_tra));

            if (so_can_kiem_tra % 2 == 0 || so_can_kiem_tra <= 2)
            {
                Console.WriteLine(so_can_kiem_tra + " Khong phai la so nguyen to ");
                Console.ReadKey();
                return;
            }

            for (int i = 3; i < so_can_kiem_tra; i++)
            {
                if (so_can_kiem_tra % i == 0)
                {
                    Console.WriteLine(so_can_kiem_tra + " Khong phai la so nguyen to ");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine(so_can_kiem_tra + " La so nguyen to");
        }




/***********************************************************************************************************************************************************************/
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





/***********************************************************************************************************************************************************************/
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




/***********************************************************************************************************************************************************************/
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



/***********************************************************************************************************************************************************************/
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




/***********************************************************************************************************************************************************************/
        static void ung_dung_chuyen_doi_tien_te()
        {
            int ti_gia = 23000;
            string Input_choose;
            string Input_so_tien;
            double Chooise_out;
            double So_tien;


            do
            {
                Console.WriteLine("Nhap so 1 neu ban muon chuyen VND -> USD ");
                Console.WriteLine("Nhap so 2 neu ban muon chuyen USD -> VND ");
                Input_choose = Console.ReadLine();
            }
            while (!double.TryParse(Input_choose, out Chooise_out) || Chooise_out > 2);

            do
            {
                Console.WriteLine("Nhap so tien ban muon chuyen doi");
                Input_so_tien = Console.ReadLine();
            }
            while (!double.TryParse(Input_so_tien, out So_tien));
            if (Chooise_out == 1)
            {
                Console.WriteLine(So_tien + " VND = " + So_tien / ti_gia + " USD");
            }
            else
            {
                Console.WriteLine(So_tien + " USD = " + So_tien * ti_gia + " VND");
            }

        }





/***********************************************************************************************************************************************************************/
        static void Bai_tap_buoi_1c()
        { 
            Console.WriteLine("Nhập tên của bạn: ");
            string ten_1c = Console.ReadLine();
            Console.WriteLine("Chào bạn: " + ten_1c);
        }




/***********************************************************************************************************************************************************************/
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



/***********************************************************************************************************************************************************************/
        static void Bai_tap_buoi_1a()
        {
            DateTime Thoi_gian_hien_tai_1a = DateTime.Now;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Thời gian hiện tại là : " + String.Format("{ HH:mm:ss 0:d/M/yyyy }", Thoi_gian_hien_tai_1a));
        }







        #endregion







    }
}
