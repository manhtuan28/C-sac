using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4._1_C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int N = 20;
            int[] array = new int[N];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-100, 101);
            }

            Console.WriteLine("Mảng ngẫu nhiên:");
            Console.WriteLine(string.Join(", ", array));

            // a. Tìm số lớn nhất, nhỏ nhất và vị trí của chúng
            int max = array[0];
            int min = array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < N; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"\nSố lớn nhất là {max} tại vị trí {maxIndex}");
            Console.WriteLine($"Số nhỏ nhất là {min} tại vị trí {minIndex}");

            // b. Đếm số dương, số âm và số 0
            int countPositive = 0;
            int countNegative = 0;
            int countZero = 0;

            for (int i = 0; i < N; i++)
            {
                if (array[i] > 0)
                    countPositive++;
                else if (array[i] < 0)
                    countNegative++;
                else
                    countZero++;
            }

            Console.WriteLine($"\nSố dương: {countPositive}");
            Console.WriteLine($"Số âm: {countNegative}");
            Console.WriteLine($"Số 0: {countZero}");

            // c. Kiểm tra xem x có trong mảng hay không
            Console.Write("\nNhập số nguyên x để kiểm tra: ");
            int x = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < N; i++)
            {
                if (array[i] == x)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"{x} có trong mảng.");
            }
            else
            {
                Console.WriteLine($"{x} không có trong mảng.");
            }

            // d. Tìm số dương nhỏ nhất và số âm lớn nhất trong mảng
            int? minPositive = null;
            int? maxNegative = null;

            for (int i = 0; i < N; i++)
            {
                if (array[i] > 0)
                {
                    if (minPositive == null || array[i] < minPositive)
                    {
                        minPositive = array[i];
                    }
                }
                if (array[i] < 0)
                {
                    if (maxNegative == null || array[i] > maxNegative)
                    {
                        maxNegative = array[i];
                    }
                }
            }

            Console.WriteLine($"\nSố dương nhỏ nhất trong mảng là: {minPositive}");
            Console.WriteLine($"Số âm lớn nhất trong mảng là: {maxNegative}");

            // e. Sắp xếp mảng theo thứ tự giảm dần (Sử dụng thuật toán sắp xếp nổi bọt - Bubble Sort)
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nMảng sắp xếp giảm dần:");
            Console.WriteLine(string.Join(", ", array));

            Console.ReadLine();
        }
    }
}
// Code by Tuancute and ChatGPT (Tuancute 1% - ChatGPT 99%).