using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi1
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap mang: ");
            string input = Console.ReadLine();

            string[] rawNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int max1 = int.Parse(rawNumbers[0]);
            int? max2 = null;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(rawNumbers[i]);

                if (x > max1)
                {
                    max2 = max1;
                    max1 = x;
                }
                else if (x < max1 && (!max2.HasValue || x > max2.Value))
                {
                    max2 = x;
                }
            }

            if (max2.HasValue)
            {
                Console.WriteLine($"{max1} {max2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
