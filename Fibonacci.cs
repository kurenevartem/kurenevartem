void Fibonachi(string[] args)
{
    Console.Write("Enter the Fibonacci number: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int[] fib=new int[x];

    int a = 0;
    int b = 1;

    fib[0] = a;
    fib[1] = b;

    for (int n = 1; n < x; n++)
    {
        int f = a + b;
        fib[n] = f;
        a = b;
        b = f;
        Console.Write($"{f}\t");
    }
    int sum = 0;
    foreach (int n in fib)
        sum += n;
    Console.WriteLine($"\nThe sum of the Fibonacci numbers: {sum}");
}
Fibonachi(args);