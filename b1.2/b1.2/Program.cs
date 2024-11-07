using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a, b;

            Console.WriteLine("Chường trình tính tổng, hiệu, tích, thương 2 số a và b");
            Console.Write("Nhập số thứ nhất a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số thứ nhất b = ");
            b = Convert.ToInt32(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            int thuong = a / b;
            Console.WriteLine($"Tổng của 2 số {a} và {b} là {tong}");
            Console.WriteLine($"Hiệu của 2 số {a} và {b} là {hieu}");
            Console.WriteLine($"Tích của 2 số {a} và {b} là {tich}");
            Console.WriteLine($"Thương của 2 số {a} và {b} là {thuong}");

            Console.ReadLine();
        }
    }
}
