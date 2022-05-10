using System;

namespace BaiDiemDanh_10_05
{
    // msv: 1911505310264
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_264 = new int[10];
            Console.WriteLine("Nhap 10 gia tri nguyen: ");
            for(int i = 0; i < 10; i++)
            {
                arr_264[i] = int.Parse(Console.ReadLine()); 
            }
            
            Console.WriteLine("Gia tri nho nhat: {0}",min(arr_264));
            Console.WriteLine("Gia tri lon nhat: {0}", max(arr_264));


        }
        public static int min(int[] arr_264)
        {
            int min_264 = 0;
            for(int i = 0; i < arr_264.Length; i++)
            {
                if(arr_264[i] <= min_264)
                {
                    min_264 = arr_264[i];
                }
            }
            return min_264;
        }
        public static int max(int[] arr_264)
        {
            int max_264 = 0;
            for (int i = 0; i < arr_264.Length; i++)
            {
                if (arr_264[i] >= max_264)
                {
                    max_264 = arr_264[i];
                }
            }
            return max_264;
        }

    }
}
