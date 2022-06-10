using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai2
{
    class TapChi : TaiLieu
    {
        private int soPT_264;
        private int thangPH_264;

        public int SoPT_264 { get => soPT_264; set => soPT_264 = value; }
        public int ThangPH_264 { get => thangPH_264; set => thangPH_264 = value; }

        public TapChi(string maTaiLieu_264, string nxb_264, int soBPT_264, int soPT_264, int thangPH_264) : base(maTaiLieu_264, nxb_264, soBPT_264)
        {
            this.SoPT_264 = soPT_264;
            this.ThangPH_264 = thangPH_264;
        }

        public TapChi()
        {
        }

        public override string ToString()
        {
            return $"Tạp chí: \n Mã tài liệu: {MaTaiLieu_264}, nxb: {Nxb_264}, số phát hành: {SoBPT_264}, số phát hành: {SoPT_264}, tháng phát hành: {ThangPH_264} ";
        }
    }
}
