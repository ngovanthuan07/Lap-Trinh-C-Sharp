using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai1
{
    class KySu : CanBo
    {
        private string nganhDaoTao_264;

        public KySu()
        {
        }

        public KySu(string hoTen_264, int tuoi_264, string gioiTinh_264, string diaChi_264, string nganhDaoTao_264) : base(hoTen_264, tuoi_264, gioiTinh_264, diaChi_264)
        {
            this.nganhDaoTao_264 = nganhDaoTao_264;
        }

        public string NganhDaoTao_264 { get => nganhDaoTao_264; set => nganhDaoTao_264 = value; }

        public override string ToString()
        {
            return $"Kỹ sư: \n Họ tên: {HoTen_264}, tuổi: {Tuoi_264}, giới tính: {GioiTinh_264}, ngành đào tạo: {NganhDaoTao_264}, địa chỉ: {DiaChi_264}";

        }
    }
}
