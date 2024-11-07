using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình tính chu vi và diện tích hình chữ nhật");

            double chieuDai,chieuRong, chuVi, dienTich;
            Console.Write("Nhập vào chiều dài: ");
            chieuDai = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập vào chiều rộng: ");
            chieuRong= Convert.ToDouble(Console.ReadLine());


            chuVi = (chieuDai + chieuRong) * 2;
            dienTich = chieuDai + chieuRong;

            Console.WriteLine($"Chu vi hình chữ nhật là: {chuVi}");
            Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");

            Console.ReadLine();
        }
    }
}
