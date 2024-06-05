﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // Khai báo mảng và biến tổng
        int[] numbers = new int[4];
        int sum = 0;

        // Nhập các số nguyên vào mảng
        Console.WriteLine("Nhập 4 số nguyên:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Số thứ {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Tính tổng các số trong mảng
        foreach (int num in numbers)
        {
            sum += num;
        }

        // In kết quả
        Console.WriteLine("Tổng các số trong mảng là: " + sum);
    }
}