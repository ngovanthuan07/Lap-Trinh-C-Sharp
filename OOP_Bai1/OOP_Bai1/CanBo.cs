using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai1
{
    class CanBo
    {
        private string hoTen_264;
        private int tuoi_264;
        private string gioiTinh_264;
        private string diaChi_264;

        public string HoTen_264 { get => hoTen_264; set => hoTen_264 = value; }
        public int Tuoi_264 { get => tuoi_264; set => tuoi_264 = value; }
        public string GioiTinh_264 { get => gioiTinh_264; set => gioiTinh_264 = value; }
        public string DiaChi_264 { get => diaChi_264; set => diaChi_264 = value; }

        public CanBo(string hoTen_264, int tuoi_264, string gioiTinh_264, string diaChi_264)
        {
            this.hoTen_264 = hoTen_264;
            this.tuoi_264 = tuoi_264;
            this.gioiTinh_264 = gioiTinh_264;
            this.diaChi_264 = diaChi_264;
        }
        public CanBo()
        {
        }


    }
}
