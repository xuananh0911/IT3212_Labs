using System;
using System.Text;

namespace Lab01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Bai1_ThongTinCaNhan();
            // Bai2_TinhHinhTru();
            // Bai3_XepLoaiHocTap();
            // Bai4_MenuSwitchVongLap();
            // Bai5_XuLyNgoaiLeChia();
            // Bai6_GiaiPhuongTrinhBacHai();
            // Bai7_ThongKeDaySo();
            // Bai8_InSoNguyenTo();
            // Bai9_DocSo();
             Bai10_VeHinh();
        }

        //   BÀI 1   
        static void Bai1_ThongTinCaNhan()
        {
            Console.WriteLine(" BÀI 1: NHẬP THÔNG TIN CÁ NHÂN  ");
            Console.Write("Họ và tên: ");
            string hoTen = Console.ReadLine()!;

            Console.Write("Năm sinh: ");
            int namSinh;
            if (!int.TryParse(Console.ReadLine(), out namSinh))
            {
                Console.WriteLine("Năm sinh không hợp lệ.");
                return;
            }

            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine("Xin chào {0}, tuổi gần đúng: {1}", hoTen, tuoi);
        }

        //  BÀI 2 
        static void Bai2_TinhHinhTru()
        {
            Console.WriteLine(" BÀI 2: TÍNH TOÁN HÌNH TRỤ ");
            double r, h;
            Console.Write("Bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0) return;

            Console.Write("Chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0) return;

            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;

            Console.WriteLine("Sxq = {0:N2}; V = {1:N2}", dienTichXQ, theTich);
        }

        //  BÀI 3 
        static void Bai3_XepLoaiHocTap()
        {
            Console.WriteLine(" BÀI 3: XẾP LOẠI HỌC TẬP ");
            double diem;
            Console.Write("Nhập điểm: ");
            if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
            {
                Console.WriteLine("Điểm phải thuộc [0, 10].");
                return;
            }

            if (diem >= 9) Console.WriteLine("Xuất sắc");
            else if (diem >= 8) Console.WriteLine("Giỏi");
            else if (diem >= 6.5) Console.WriteLine("Khá");
            else if (diem >= 5) Console.WriteLine("Trung bình");
            else Console.WriteLine("Yếu");
        }

        //  BÀI 4 
        static void Bai4_MenuSwitchVongLap()
        {
            int chon;
            do
            {
                Console.WriteLine("\n--- MENU BÀI 4 ---");
                Console.WriteLine("1. Tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương 7");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                int.TryParse(Console.ReadLine(), out chon);

                switch (chon)
                {
                    case 1:
                        Console.Write("n = ");
                        int n = int.Parse(Console.ReadLine()!);
                        int tong = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            tong += i;
                        }
                        Console.WriteLine("Tổng = " + tong);
                        break;

                    case 2:
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("7 x {0} = {1}", i, 7 * i);
                        }
                        break;

                    case 0:
                        Console.WriteLine("Thoát bài 4.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }

        //  BÀI 5 
        static void Bai5_XuLyNgoaiLeChia()
        {
            Console.WriteLine(" BÀI 5: XỬ LÝ NGOẠI LỆ ");
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine()!);
                Console.WriteLine("a / b = " + (a / b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu phải là số nguyên.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Không thể chia cho 0.");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép tính.");
            }
        }

        //  BÀI 6 
        static void Bai6_GiaiPhuongTrinhBacHai()
        {
            Console.WriteLine(" BÀI 6: GIẢI PHƯƠNG TRÌNH BẬC HAI ");
            Console.Write("a = "); double a = double.Parse(Console.ReadLine()!);
            Console.Write("b = "); double b = double.Parse(Console.ReadLine()!);
            Console.Write("c = "); double c = double.Parse(Console.ReadLine()!);

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Vô số nghiệm." : "Vô nghiệm.");
                else
                    Console.WriteLine($"Nghệim x = {-c / b:F2}");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("Vô nghiệm.");
                else if (delta == 0) Console.WriteLine($"Nghệim kép x = {-b / (2 * a):F2}");
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
                }
            }
        }

        //  BÀI 7 
        static void Bai7_ThongKeDaySo()
        {
            Console.WriteLine(" BÀI 7: THỐNG KÊ DÃY SỐ ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()!);
            if (n <= 0) return;

            int tong = 0, max = int.MinValue, min = int.MaxValue, demChan = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử [{i + 1}]: ");
                int val = int.Parse(Console.ReadLine()!);
                tong += val;
                if (val > max) max = val;
                if (val < min) min = val;
                if (val % 2 == 0) demChan++;
            }
            Console.WriteLine($"Tổng: {tong} | TB: {(double)tong / n:F2} | Max: {max} | Min: {min} | Số chẵn: {demChan}");
        }

        //  BÀI 8 
        static void Bai8_InSoNguyenTo()
        {
            Console.WriteLine(" BÀI 8: SỐ NGUYÊN TỐ <= N ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write($"Các số nguyên tố <= {n}: ");
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) { isPrime = false; break; }
                }
                if (isPrime) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        //  BÀI 9 
        static void Bai9_DocSo()
        {
            Console.WriteLine("--- BÀI 9: ĐỌC SỐ TỪ 0 ĐẾN 99 ---");
            Console.Write("Nhập số nguyên (0 - 99): ");

            if (!int.TryParse(Console.ReadLine(), out int num) || num < 0 || num > 99)
            {
                Console.WriteLine("Số nhập vào không hợp lệ!");
                return;
            }

            // Trường hợp số có 1 chữ số (0 -> 9)
            if (num < 10)
            {
                switch (num)
                {
                    case 0: Console.WriteLine("Cách đọc: Không"); break;
                    case 1: Console.WriteLine("Cách đọc: Một"); break;
                    case 2: Console.WriteLine("Cách đọc: Hai"); break;
                    case 3: Console.WriteLine("Cách đọc: Ba"); break;
                    case 4: Console.WriteLine("Cách đọc: Bốn"); break;
                    case 5: Console.WriteLine("Cách đọc: Năm"); break;
                    case 6: Console.WriteLine("Cách đọc: Sáu"); break;
                    case 7: Console.WriteLine("Cách đọc: Bảy"); break;
                    case 8: Console.WriteLine("Cách đọc: Tám"); break;
                    case 9: Console.WriteLine("Cách đọc: Chín"); break;
                }
                return;
            }

            // Trường hợp số có 2 chữ số (10 -> 99)
            int chuc = num / 10;
            int donVi = num % 10;

            // Đọc hàng chục bằng switch
            string strChuc = "";
            switch (chuc)
            {
                case 1: strChuc = "Mười"; break;
                case 2: strChuc = "Hai mươi"; break;
                case 3: strChuc = "Ba mươi"; break;
                case 4: strChuc = "Bốn mươi"; break;
                case 5: strChuc = "Năm mươi"; break;
                case 6: strChuc = "Sáu mươi"; break;
                case 7: strChuc = "Bảy mươi"; break;
                case 8: strChuc = "Tám mươi"; break;
                case 9: strChuc = "Chín mươi"; break;
            }

            // Đọc hàng đơn vị bằng switch
            string strDonVi = "";
            switch (donVi)
            {
                case 0: strDonVi = ""; break;
                case 1: strDonVi = (chuc > 1) ? "mốt" : "một"; break;
                case 2: strDonVi = "hai"; break;
                case 3: strDonVi = "ba"; break;
                case 4: strDonVi = "bốn"; break;
                case 5: strDonVi = "lăm"; break;
                case 6: strDonVi = "sáu"; break;
                case 7: strDonVi = "bảy"; break;
                case 8: strDonVi = "tám"; break;
                case 9: strDonVi = "chín"; break;
            }

            if (string.IsNullOrEmpty(strDonVi))
                Console.WriteLine($"Cách đọc: {strChuc}");
            else
                Console.WriteLine($"Cách đọc: {strChuc} {strDonVi}");
        }

        // BÀI 10 
     
        static void Bai10_VeHinh()
        {
            int chon;
            do
            {
                Console.WriteLine("\n--- BÀI 10: VẼ HÌNH BẰNG KÝ TỰ (*) ---");
                Console.WriteLine("1. Tam giác vuông đặc");
                Console.WriteLine("2. Tam giác vuông rỗng");
                Console.WriteLine("3. Hình vuông rỗng");
                Console.WriteLine("0. Quay lại / Thoát Bài 10");
                Console.Write("Chọn loại hình muốn vẽ (0-3): ");

                if (!int.TryParse(Console.ReadLine(), out chon) || chon < 0 || chon > 3)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    continue;
                }

                if (chon == 0) break;

                Console.Write("Nhập kích thước n (n > 0): ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
                {
                    Console.WriteLine("Kích thước không hợp lệ!");
                    continue;
                }

                Console.WriteLine();
                switch (chon)
                {
                    case 1: // 1. Tam giác vuông đặc
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2: // 2. Tam giác vuông rỗng
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (j == 1 || j == i || i == n)
                                    Console.Write("* ");
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3: // 3. Hình vuông rỗng
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= n; j++)
                            {
                                if (i == 1 || i == n || j == 1 || j == n)
                                    Console.Write("* ");
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();
                        }
                        break;
                }

            } while (chon != 0);
        }

    } 
} 