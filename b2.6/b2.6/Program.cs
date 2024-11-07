using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình in ra dãy Phi Bô Na Xi từ 1 đến n");

            int n, a = 0, b = 1, tg;
            Console.Write("Nhập vào số n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Dãy Fibonaci từ 1 đến {n}: ");


            while (b <= n) 
            {
                Console.Write($"{b} ");
                tg = a + b;
                a = b;
                b = tg;
            }


            Console.ReadLine();
        }
    }
}
