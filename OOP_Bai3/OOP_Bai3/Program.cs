using System;

namespace OOP_Bai3
{
    class Program
    {
        public static Candidate createCadidate(String cate)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập ID: ");
            String id = Console.ReadLine();
            Console.Write("Nhập tên: ");
            String name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            String address = Console.ReadLine();
            Console.Write("Nhập quền lợi: ");
            int priority = int.Parse(Console.ReadLine());
            if (cate.Equals("a"))
            {
                return new CandidateA(id, name, address, priority);
            }
            else if (cate.Equals("b"))
            {
                return new CandidateB(id, name, address, priority);
            }
            else
            {
                return new CandidateC(id, name, address, priority);
            }

        }
        static void Main(string[] args)
        {
            ManagerCandidate managerCandidate = new ManagerCandidate();
            while (true)
            {
                Console.WriteLine("Quản lý tuyển sinh");
                Console.WriteLine("Nhập 1: Thêm mới thí sinh");
                Console.WriteLine("Nhập 2: Hiện thị thông tin của thí sinh và khối thi của thí sinh: ");
                Console.WriteLine("Nhập 3: Tìm kiếm theo số báo danh");
                Console.WriteLine("Nhập 4: Thoát khỏi chương trình:");
                String line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        {
                            Console.WriteLine("Nhập a: Thêm thí sinh khối A");
                            Console.WriteLine("Nhập b: Thêm thí sinh khối B");
                            Console.WriteLine("Nhập c: Thêm thí sinh khối C");
                            String type = Console.ReadLine();
                            switch (type)
                            {
                                case "a":
                                    {
                                        managerCandidate.add(createCadidate("a"));
                                        break;

                                    }
                                case "b":
                                    {
                                        managerCandidate.add(createCadidate("b"));
                                        break;
                                    }
                                case "c":
                                    {
                                        managerCandidate.add(createCadidate("c"));
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Thông báo");
                                    break;
                            }
                            break;
                        }
                    case "2":
                        {
                            managerCandidate.showInfor();
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Nhập ID: ");
                            String id = Console.ReadLine();
                            Candidate candidate = managerCandidate.searchById(id);
                            if (candidate == null)
                            {
                                Console.WriteLine("Không tìm thấy");
                            }
                            else
                            {
                                Console.WriteLine(candidate.ToString());
                            }
                            break;
                        }
                    case "4":
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Thông báo");
                        continue;
                }

            }
        }
    }
}
