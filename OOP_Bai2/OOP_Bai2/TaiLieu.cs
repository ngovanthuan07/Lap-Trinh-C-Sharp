using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai2
{
    class TaiLieu
    {
        private string maTaiLieu_264;
        private string nxb_264;
        private int soBPT_264;

        public string MaTaiLieu_264 { get => maTaiLieu_264; set => maTaiLieu_264 = value; }
        public string Nxb_264 { get => nxb_264; set => nxb_264 = value; }
        public int SoBPT_264 { get => soBPT_264; set => soBPT_264 = value; }

       

        public TaiLieu()
        {
        }

        public TaiLieu(string maTaiLieu_264, string nxb_264, int soBPT_264)
        {
            this.maTaiLieu_264 = maTaiLieu_264;
            this.nxb_264 = nxb_264;
            this.soBPT_264 = soBPT_264;
        }
    }
}
