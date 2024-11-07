using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình tính chu vi, diện tích hình tam giác");

            double a, b, c, chuVi, dienTich;

            Console.Write("Nhập và cạnh a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập và cạnh b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập và cạnh c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Đây không phải tam giác");
            }
            else 
            { 
                chuVi = a + b + c;
                Console.WriteLine($"Chu vi hình tam giác là: {chuVi}");

                double nuaChuVi = (a + b + c) / 2;
                dienTich = Math.Sqrt(nuaChuVi * (nuaChuVi - a) * (nuaChuVi -b) * (nuaChuVi - c));
                Console.WriteLine($"Diện tích hình tam giác là: {dienTich:F2}");
            }
            Console.ReadLine();
        }
    }
}
