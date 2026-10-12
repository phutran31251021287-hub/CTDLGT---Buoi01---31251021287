using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Buoi1
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap mang: ");
            string input = Console.ReadLine();

            string[] rawNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var stopwatchA = System.Diagnostics.Stopwatch.StartNew();
            var resultA = PhienBanA(rawNumbers, n);
            stopwatchA.Stop();
            Console.WriteLine($"Phien ban A: {resultA}");
            Console.WriteLine($"thoi gian: {stopwatchA.Elapsed.TotalMilliseconds}");
            Console.WriteLine();

            var stopwatchB = System.Diagnostics.Stopwatch.StartNew();
            var resultB = PhienBanB(rawNumbers, n);
            stopwatchB.Stop();
            Console.WriteLine($"Phien ban B: {resultB}");
            Console.WriteLine($"thoi gian: {stopwatchB.Elapsed.TotalMilliseconds}");
        }
        static int PhienBanA(string[] arr, int n)
        {
            if (arr == null || arr.Length == 0) return 0;
            int maxSum = int.Parse(arr[0]);
            for (int i = 0; i < n; i++)
            {
                int currentSum = 0;
                for (int j = i; j < n; j++)
                {
                    currentSum += int.Parse(arr[j]);
                    if (currentSum > maxSum) maxSum = currentSum;
                }
            }
            return maxSum;
        }
        static int PhienBanB(string[] arr, int size)
        {
            int maxEndingHere = int.Parse(arr[0]);
            int maxSoFar = int.Parse(arr[0]);

            for (int i = 1; i < size; i++)
            {
                maxEndingHere = Math.Max(int.Parse(arr[i]), maxEndingHere + int.Parse(arr[i]));
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }

    }
}
