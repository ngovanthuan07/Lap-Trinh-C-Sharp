using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai1
{
    class CongNhan : CanBo
    {
        private int bac_264;

        public CongNhan()
        {
        }

        public CongNhan(string hoTen_264, int tuoi_264, string gioiTinh_264, string diaChi_264, int bac_264) : base(hoTen_264, tuoi_264, gioiTinh_264, diaChi_264)
        {
            this.Bac_264 = bac_264;
        }

        public int Bac_264 { get => bac_264; set => bac_264 = value; }

        public override string ToString()
        {
            return $"Công nhân: \n Họ tên: {HoTen_264}, tuổi: {Tuoi_264}, giới tính: {GioiTinh_264}, bậc: {Bac_264}, địa chỉ: {DiaChi_264}";
        }
    }
}
