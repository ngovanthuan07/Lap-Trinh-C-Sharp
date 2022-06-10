using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bai3
{
    class CandidateB : Candidate
    {
        public static  String MON_TOAN = "Toan";
        public static  String MON_HOA = "Hoa";
        public static  String MON_SINH = "Sinh";

        public CandidateB(string id, string name, string address, int priority) : base(id, name, address, priority)
        {
        }

        public override string ToString()
        {
            return "Thí sinh khối B{" +
               "id='" + id + '\'' +
               ", tên='" + name + '\'' +
               ", địa chỉ='" + address + '\'' +
               ", quyền lợi=" + priority + ", môn học: " + MON_TOAN + " - " + MON_SINH + " - " + MON_HOA +
               '}';
        }
    }
}
