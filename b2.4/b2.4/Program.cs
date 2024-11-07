using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình tính tổng từ 1 đến n");

            int n, sum = 0;
            Console.Write("Nhập vào số n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++) 
            {
                sum += i;
            }

            Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
            
            Console.ReadLine();
        }
    }
}
