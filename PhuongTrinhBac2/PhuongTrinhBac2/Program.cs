using System;

namespace PhuongTrinhBac2
{
    class PhuongTrinhBac2
    {
        private double a;
        private double b;
        private double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public PhuongTrinhBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public PhuongTrinhBac2()
        {
        }

        public double delta()
        {
            return b * b - 4 * a * c; 
        }
        
        public void nghiemPhuongTrinh()
        {
            if (delta() > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta())) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta())) / 2 * a));

            }
            else if (delta() == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta() < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap phuong trinh bac 2: ");
            PhuongTrinhBac2 phuongTrinhBac2 = new PhuongTrinhBac2();
            Console.WriteLine("Nhap a: ");
            phuongTrinhBac2.A = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            phuongTrinhBac2.B = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            phuongTrinhBac2.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Ket qua: ");

            phuongTrinhBac2.nghiemPhuongTrinh();

            Console.ReadKey();
        }
    }
}
