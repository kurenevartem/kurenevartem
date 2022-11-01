﻿void Fibonachi(string[] args)
{
    Console.Write("Enter the Fibonacci number: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 1;
    int sum = 0;
        for (; ; )
        {
            int f = a + b;
            if (f > x)
                break;
            Console.Write($"{f}\t");
            sum += f;
            a = b;
            b = f;
        }
    Console.WriteLine($"\nThe sum of the Fibonacci numbers: {sum}");
}
Fibonachi(args);