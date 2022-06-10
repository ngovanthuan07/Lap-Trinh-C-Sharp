using System;
using System.Collections.Generic;

namespace OOP_Bai1
{
    class QLCB
    {
        private List<CanBo> lCanBo_264 = new List<CanBo>();
        public QLCB()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while(true)
            {
                Console.WriteLine("*-CHƯƠNG TRÌNH QUẢN LÝ CÁN BỘ-*");
                Console.WriteLine("*-Chức năng chính chương trình-*");
                Console.WriteLine("  1. Thêm mới cán bộ  ");
                Console.WriteLine("  2. Tìm kiếm theo họ tên  ");
                Console.WriteLine("  3. Hiện thị thông tin về danh sách các cán bộ  ");
                Console.WriteLine("  4. Thoát khỏi chương trình  ");
                Console.WriteLine("  ----------------------  ");
                int num_264;

                Console.WriteLine("  Nhập một số để chọn chức năng  ");
                num_264 = int.Parse(Console.ReadLine());

                switch(num_264)
                {
                    case 1:
                    {
                        Console.WriteLine("  Chọn a: Thêm công nhân  ");
                        Console.WriteLine("  Chọn b: Thêm nhân viên  ");
                        Console.WriteLine("  Chọn c: Thêm kỹ sư  ");
                        string num2_264 = Console.ReadLine();
                        switch (num2_264)
                        {
                            case "a":
                                {
                                    Console.WriteLine("  Nhập họ tên:  ");
                                    string hoTen_264 = Console.ReadLine();
                                    Console.WriteLine("  Nhập tuổi:  ");
                                    int tuoi_264 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("  Nhập giới tính:  ");
                                    string gioiTinh_264 = Console.ReadLine();
                                    Console.WriteLine("  Nhập bậc lương:  ");
                                    int bacLuong = int.Parse(Console.ReadLine());
                                    Console.WriteLine("  Nhập địa chỉ:  ");
                                    string diaChi_264 = Console.ReadLine();

                                    CanBo congNhan_264 = new CongNhan(hoTen_264, tuoi_264, gioiTinh_264, diaChi_264, bacLuong);
                                    lCanBo_264.Add(congNhan_264);
                                    break;
                                }
                            case "b":
                                {
                                    Console.WriteLine("  Nhập họ tên:  ");
                                    string hoTen_264 = Console.ReadLine();
                                    Console.WriteLine("  Nhập tuổi:  ");
                                    int tuoi_264 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("  Nhập giới tính:  ");
                                    string gioiTinh_264 = Console.ReadLine();
                                    Console.WriteLine("  Nhập công việc:  ");
                                    string congViec_264 = Console.ReadLine();
                                    Console.WriteLine("  Nhập địa chỉ:  ");
                                    string diaChi_264 = Console.ReadLine();

                                    CanBo nhanVien_264 = new NhanVien(hoTen_264, tuoi_264, gioiTinh_264, diaChi_264, congViec_264);
                                    lCanBo_264.Add(nhanVien_264);
                                    break;
                                }
                            case "c":
                            {
                                Console.WriteLine("  Nhập họ tên:  ");
                                string hoTen_264 = Console.ReadLine();
                                Console.WriteLine("  Nhập tuổi:  ");
                                int tuoi_264 = int.Parse(Console.ReadLine());
                                Console.WriteLine("  Nhập giới tính:  ");
                                string gioiTinh_264 = Console.ReadLine();
                                Console.WriteLine("  Nhập nhành đào tạo:  ");
                                string nganhDaoTao_264 = Console.ReadLine();
                                Console.WriteLine("  Nhập địa chỉ:  ");
                                string diaChi_264 = Console.ReadLine();

                                CanBo kySu_264 = new KySu(hoTen_264, tuoi_264, gioiTinh_264, diaChi_264, nganhDaoTao_264);
                                lCanBo_264.Add(kySu_264);
                                break;
                            }
                        }
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("  Nhập từ khoá cần tìm:  ");
                        string keyword_264 = Console.ReadLine();
                        List<CanBo> newLCB_264 = lCanBo_264.FindAll(v => v.HoTen_264.Contains(keyword_264));
                        Console.WriteLine("  Kết quả:  ");
                        foreach (CanBo cb_264 in newLCB_264)
                        {
                            Console.WriteLine(cb_264.ToString());
                        }
                        break;
                    }

                    case 3:
                    {
                        foreach(CanBo cb_264 in lCanBo_264)
                        {
                                Console.WriteLine(cb_264.ToString());
                        }
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("---  Chương trình kết thúc  ---");
                        return;
                    }

                }



            }
        }

        static void Main(string[] args)
        {
            new QLCB();
        }
    }
}
