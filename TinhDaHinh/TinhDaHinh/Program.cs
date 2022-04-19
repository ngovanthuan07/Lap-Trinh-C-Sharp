using System;

namespace TinhDaHinh
{
    class Program
    {
        public class DaGiac
        {
            private int soCanh;
            private int[] a;

            public DaGiac(int soCanh, int[] a)
            {
                this.soCanh = soCanh;
                this.a = a;
            }

            public int SoCanh { get => soCanh; set => soCanh = value; }
            public int[] A { get => a; set => a = value; }

            public void nhap()
            {
                do
                {
                    Console.WriteLine("Nhập vào số cạnh: ");
                    this.soCanh = int.Parse(Console.ReadLine());

                } while (this.soCanh <= 2);
                for (int i = 0; i < this.soCanh; i++)
                {
                    Console.WriteLine("Nhập cạnh thứ " + (i + 1) + " :");
                    this.a[i] = int.Parse(Console.ReadLine());
                }

            }
            public void xuatDaGiac()
            {
                Console.WriteLine("Độ dài các cạnh lần lượt là: ");
                for (int i = 0; i < this.soCanh; i++)
                {
                    if (i < (this.soCanh - 1))
                    {
                        Console.WriteLine(this.a[i] + "\t  \t");
                    }
                    else
                    {
                        Console.WriteLine(this.a[i]);
                    }
                }
                Console.WriteLine("--------------------End--------------------");
            }
        }

        public class TamGiac : DaGiac
        {
            public TamGiac(int soCanh, int[] a) : base(soCanh, a)
            {
                soCanh = soCanh;
                a = a;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
