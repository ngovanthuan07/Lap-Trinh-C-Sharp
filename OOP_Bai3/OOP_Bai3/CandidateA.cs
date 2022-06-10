using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai3
{
    class CandidateA : Candidate
    {
        public static String MON_TOAN = "Toan";
        public static String MON_LY = "Ly";
        public static String MON_HOA = "Hoa";

        public CandidateA(string id, string name, string address, int priority) : base(id, name, address, priority)
        {
        }

        public override string ToString()
        {
            return "Thí sinh khối A{" +
                            "id='" + id + '\'' +
                            ", tên='" + name + '\'' +
                            ", địa chỉ='" + address + '\'' +
                            ", quyền lợi=" + priority + ", môn học: " + MON_TOAN + " - " + MON_LY + " - " + MON_HOA +
                            '}';
        }
    }
}
