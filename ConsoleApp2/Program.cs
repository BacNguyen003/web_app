using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap chieu dai 1 canh: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double a))
                {
                    if (a <= 0)
                    {
                        Console.WriteLine("chieu dai phai lon hon 0.");
                        return;
                    }

                    double chuvi = a * 12;
                    double dientich = a * a*6;
                    double thetich = a * a*a;
                    Console.WriteLine("dien tich : " + chuvi);
                    Console.WriteLine("chu vi: " + dientich);
                    Console.WriteLine("the tich: " + thetich);
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le !.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
