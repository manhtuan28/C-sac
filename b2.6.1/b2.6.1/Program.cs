using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình tìm tất cả ước số của số nguyên n");

            int n;
            Console.Write("Nhập vào số n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Các ước số của {n} là: ");

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                } 
            }

            Console.ReadLine();
        }
    }
}
