using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai2
{
    class Bao : TaiLieu
    {
        private string ngayPhatHanh_264;

        public Bao(string maTaiLieu_264, string nxb_264, int soBPT_264, string ngayPhatHanh_264) : base(maTaiLieu_264, nxb_264, soBPT_264)
        {
            this.NgayPhatHanh_264 = ngayPhatHanh_264;
        }

        public string NgayPhatHanh_264 { get => ngayPhatHanh_264; set => ngayPhatHanh_264 = value; }

        public override string ToString()
        {
            return $"Báo: \n Mã tài liệu: {MaTaiLieu_264}, nxb: {Nxb_264}, số phát hành: {SoBPT_264}, Ngày phát hành: {NgayPhatHanh_264} ";
        }
    }
}
