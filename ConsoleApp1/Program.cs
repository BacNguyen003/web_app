using System;
using System.Collections.Generic;
using System.Text;
using libtinhtoan;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap gia tri canh : ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double a))
                {
                    double chuvilapphuong = tinhtoan.chuvi(a);
                    double dientichlapphuong = tinhtoan.dientich(a);
                    double thetichlapphuong = tinhtoan.thetich(a);
                    Console.WriteLine("Dien tich hinh lap phuong la: " + chuvilapphuong);
                    Console.WriteLine("Chu vi hinh lap phuong la: " + dientichlapphuong);
                    Console.WriteLine("The tich hinh lap phuong la: " + thetichlapphuong);

                }
                else
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập một số thực.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
