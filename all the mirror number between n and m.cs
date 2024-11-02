using System;

class Program
{
    static void Main()
    {
        // دریافت دو عدد از کاربر
        Console.Write("Please enter the first number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"Mirror numbers between {n} and {m} are:");

        // بررسی هر عدد بین n و m
        for (int i = n; i <= m; i++)
        {
            if (IsMirrorNumber(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    // تابعی برای بررسی آینه‌ای بودن یک عدد
    static bool IsMirrorNumber(int num)
    {
        int original = num;
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        return original == reversed;
    }
}
