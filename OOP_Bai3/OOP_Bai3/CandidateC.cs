using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai3
{
    class CandidateC : Candidate
    {
        public static  String MON_VAN = "Van";
        public static  String MON_SU = "Su";
        public static  String MON_DIA = "Dia";

        public CandidateC(string id, string name, string address, int priority) : base(id, name, address, priority)
        {
        }

        public override string ToString()
        {
            return "Thí sinh khối C{" +
               "id='" + id + '\'' +
               ", tên='" + name + '\'' +
               ", địa chỉ='" + address + '\'' +
               ", quyên lợi=" + priority + ", môn học: " + MON_VAN + " - " + MON_SU + " - " + MON_DIA +
               '}';
        }
    }
}
