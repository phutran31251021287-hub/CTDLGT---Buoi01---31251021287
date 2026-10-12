using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    internal class Bai1
    {
        static void Main1(string[] args)
        {
            Console.Write("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
            double min = (a < b) ? ((a < c) ? a : c) : ((b < c) ? b : c);
            double avg = (a + b + c) / 3;
            Console.Write($"Lon nhat = {max}, nho nhat = {min}, trung binh = {avg:f2}");
        }
    }
}
