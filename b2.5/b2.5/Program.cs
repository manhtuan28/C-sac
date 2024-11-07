using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình tính tổng chẵn từ 1 đến n");

            int n, sum = 0;
            Console.Write("Nhập số n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i += 2) 
            {
                sum += i;
            }

            Console.WriteLine($"Tổng chẵn từ 1 đến {n} là {sum}");

            Console.ReadLine();
        }
    }
}
