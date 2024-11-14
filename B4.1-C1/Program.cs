using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4._1_C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n = 20;
            int[] arr = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-100,101);
            }

            Console.WriteLine("Mảng ngẫu nhiên:");
            Console.WriteLine(string.Join(", ", arr));

            // A, Tìm số lớn nhất, nhỏ nhất trong mảng. Xuất ra vị trí các giá trị.
            int max = arr.Max();
            int min = arr.Min();
            int maxIndex = Array.IndexOf(arr,max);
            int minIndex = Array.IndexOf(arr,min);

            Console.WriteLine($"\nSố lớn nhất là {max} tại vị trí {maxIndex}");
            Console.WriteLine($"Số nhỏ nhất là {min} tại vị trí {minIndex}");

            // B, Đếm trong mảng có bao nhiêu số dương, âm, 0
            int demSoDuong = arr.Count(x => x > 0);
            int demSoAm = arr.Count(x => x < 0);
            int demSo0 = arr.Count(x => x == 0);


            if (demSoDuong == 0 || demSoAm == 0 || demSo0 == 0)
            {
                if (demSoDuong == 0)
                    Console.WriteLine("Trong mảng không có số dương nào");
                if (demSoAm == 0)
                    Console.WriteLine("Trong mảng không có số âm nào");
                if (demSo0 == 0)
                    Console.WriteLine("Trong mảng không có số 0 nào");
            }
            else
            {
                Console.WriteLine($"\nTrong mảng có {demSoDuong} số dương");
                Console.WriteLine($"Trong mảng có {demSoAm} số âm");
                Console.WriteLine($"Trong mảng có {demSo0} số 0");
            }

            // C, Nhập số nguyên x, kiểm tra x có trong mảng không.
            Console.Write("\nNhập số nguyên X để kiểm tra: ");
            int X = int.Parse(Console.ReadLine());

            if (arr.Contains(X))
            {
                Console.WriteLine($"{X} có trong mảng.");
            }
            else
            {
                Console.WriteLine($"{X} không có trong mảng.");
            }

            // D, Tìm số dương nhỏ nhất, âm lớn nhất trong mảng.
            int? minDuong = arr.Where(num => num > 0).Min();
            int? maxAm = arr.Where(num => num < 0).Max();

            Console.WriteLine($"\nSố dương nhỏ nhất trong mảng là: {minDuong}");
            Console.WriteLine($"Số âm lớn nhất trong mảng là: {maxAm}");

            // E, in dãy giảm dần.
            int[] dayGiamDan = arr.OrderByDescending(num => num).ToArray();
            Console.WriteLine("\nMảng sắp xếp giảm dần:");
            Console.WriteLine(string.Join(", ", dayGiamDan));

            Console.ReadLine();
        }
    }
}
// Code By TuanCute and ChatGPT (Tuancute 60%, ChatGPT 40%)