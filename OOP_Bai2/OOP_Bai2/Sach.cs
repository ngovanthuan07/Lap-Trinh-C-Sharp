using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai2
{
    class Sach : TaiLieu
    {
        private string tacGiao_264;
        private int soTrang_264;

        public Sach()
        {
        }

        public Sach(string maTaiLieu_264, string nxb_264, int soBPT_264, string tacGiao_264, int soTrang_264) : base(maTaiLieu_264, nxb_264, soBPT_264)
        {
            this.tacGiao_264 = tacGiao_264;
            this.soTrang_264 = soTrang_264;
        }

        public string TacGiao_264 { get => tacGiao_264; set => tacGiao_264 = value; }
        public int SoTrang_264 { get => soTrang_264; set => soTrang_264 = value; }

        public override string ToString()
        {
            return $"Sách: \n Mã tài liệu: {MaTaiLieu_264}, nxb: {Nxb_264}, số phát hành: {SoBPT_264},tác giả: {TacGiao_264}, số trang: {SoTrang_264} ";
        }
    }
}
