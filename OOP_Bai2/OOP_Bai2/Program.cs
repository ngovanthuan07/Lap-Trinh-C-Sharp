using System;
using System.Collections.Generic;

namespace OOP_Bai2
{
    class QuanLySach
    {
        private List<TaiLieu> lTaiLieu_264 = new List<TaiLieu>();
        public QuanLySach()
        {
            while (true)
            {
                Console.WriteLine("*-CHƯƠNG TRÌNH QUẢN LÝ CÁN BỘ-*");
                Console.WriteLine("*-Chức năng chính chương trình-*");
                Console.WriteLine("  1. Thêm mới tài liêu  ");
                Console.WriteLine("  2. Xoá tài liệu theo mã tài liệu  ");
                Console.WriteLine("  3. Hiện thị thông tin về tài liệu  ");
                Console.WriteLine("  4. Tìm kiếm tài liệu theo loại  ");
                Console.WriteLine("  5. Thoát khỏi chương trình  ");
                Console.WriteLine("  ----------------------  ");
                int num_264;

                Console.WriteLine("  Nhập một số để chọn chức năng  ");
                num_264 = int.Parse(Console.ReadLine());

                switch (num_264)
                {
                    case 1:
                        {
                            Console.WriteLine("  Chọn a: Thêm sách  ");
                            Console.WriteLine("  Chọn b: Thêm tạp chí  ");
                            Console.WriteLine("  Chọn c: Thêm báo  ");
                            string num2_264 = Console.ReadLine();
                            switch (num2_264)
                            {
                                case "a":
                                    {
                                        Console.WriteLine("  Mã tài liệu:  ");
                                        string maTaiLieu_264 = Console.ReadLine();
                                        Console.WriteLine("  Tên nhà xuất bản:  ");
                                        string nxb_264 = Console.ReadLine();
                                        Console.WriteLine("  Số bản phát hành:  ");
                                        int soBPT_264 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("  Tác giả:  ");
                                        string tacGiao_264 = Console.ReadLine();
                                        Console.WriteLine("  Số trang:  ");
                                        int soTrang_264 = int.Parse(Console.ReadLine());

                                        Sach sach_264 = new Sach(maTaiLieu_264, nxb_264, soBPT_264, tacGiao_264, soTrang_264);
                                        lTaiLieu_264.Add(sach_264);
                                        break;
                                    }
                                case "b":
                                    {
                                        Console.WriteLine("  Mã tài liệu:  ");
                                        string maTaiLieu_264 = Console.ReadLine();
                                        Console.WriteLine("  Tên nhà xuất bản:  ");
                                        string nxb_264 = Console.ReadLine();
                                        Console.WriteLine("  Số bản phát hành:  ");
                                        int soBPT_264 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("  Số phát hành:  ");
                                        int soPT_264 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("  Tháng phát hành:  ");
                                        int thangPH_264 = int.Parse(Console.ReadLine());

                                        TapChi tapChi_264 = new TapChi(maTaiLieu_264, nxb_264, soBPT_264, soPT_264, thangPH_264);
                                        lTaiLieu_264.Add(tapChi_264);
                                        break;
                                    }
                                case "c":
                                    {
                                        Console.WriteLine("  Mã tài liệu:  ");
                                        string maTaiLieu_264 = Console.ReadLine();
                                        Console.WriteLine("  Tên nhà xuất bản:  ");
                                        string nxb_264 = Console.ReadLine();
                                        Console.WriteLine("  Số bản phát hành:  ");
                                        int soBPT_264 = int.Parse(Console.ReadLine());
                                 
                                        Console.WriteLine("  Ngày phát hành:  ");
                                        string ngayPhatHanh_264 = Console.ReadLine();

                                        Bao tapChi_264 = new Bao(maTaiLieu_264, nxb_264, soBPT_264, ngayPhatHanh_264);
                                        lTaiLieu_264.Add(tapChi_264);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("  Nhập từ mã cần xoá:  ");
                            string keyword_264 = Console.ReadLine();
                            int index_264 = lTaiLieu_264.FindIndex(v => v.MaTaiLieu_264.Equals(keyword_264));
                            lTaiLieu_264.RemoveAt(index_264);
                            Console.WriteLine("  Kết quả sau khi xoá:  ");
                            foreach (TaiLieu tl_264 in lTaiLieu_264)
                            {
                                Console.WriteLine(tl_264.ToString());
                            }
                            break;
                        }

                    case 3:
                        {
                            foreach (TaiLieu tl_264 in lTaiLieu_264)
                            {
                                Console.WriteLine(tl_264.ToString());
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Phần loại");
                            Console.WriteLine("  ------- Sách ------- ");
                            lTaiLieu_264.FindAll(v => v is Sach).ForEach(s => Console.WriteLine(s.ToString()));
                            Console.WriteLine("  ------- Tạp chí ------- ");
                            lTaiLieu_264.FindAll(v => v is TapChi).ForEach(tc => Console.WriteLine(tc.ToString()));
                            Console.WriteLine("  ------- Báo ------- ");
                            lTaiLieu_264.FindAll(v => v is Bao).ForEach(b => Console.WriteLine(b.ToString()));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("---  Chương trình kết thúc  ---");
                            return;
                        }

                }

            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            new QuanLySach();
        }
    }
}
