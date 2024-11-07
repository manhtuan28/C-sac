using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình nhập 2 số nguyên dương và đưa ra ước chung lớn nhất của 2 số");

            int a, b;
            Console.Write("Nhập vào số nguyên dương thứ nhất: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập vào số nguyên dương thứ hai: ");
            b = Convert.ToInt32(Console.ReadLine());

            int ucln = UCLN(a, b);

            Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là: {ucln}");

            Console.ReadLine();

        }

        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int tg = b;
                b = a % b;
                a = tg;
            }
            return a;
        }

    }
}
