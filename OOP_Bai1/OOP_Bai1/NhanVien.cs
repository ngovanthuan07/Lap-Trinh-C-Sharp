using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai1
{
    class NhanVien : CanBo
    {
        private string congViec_264;

        public NhanVien()
        {
        }

        public NhanVien(string hoTen_264, int tuoi_264, string gioiTinh_264, string diaChi_264, string congViec_264) : base(hoTen_264, tuoi_264, gioiTinh_264, diaChi_264)
        {
            this.CongViec_264 = congViec_264;
        }

        public string CongViec_264 { get => congViec_264; set => congViec_264 = value; }

        public override string ToString()
        {
            return $"Nhân viên: \n Họ tên: {HoTen_264}, tuổi: {Tuoi_264}, giới tính: {GioiTinh_264}, công việc: {CongViec_264}, địa chỉ: {DiaChi_264}";
        }
    }
}
