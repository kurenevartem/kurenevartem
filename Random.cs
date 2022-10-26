int[,] nums = new int[10, 10];
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        nums[i, j] = random.Next();
        Console.Write($"{nums[i, j]} \t");
    }
    Console.WriteLine();
}