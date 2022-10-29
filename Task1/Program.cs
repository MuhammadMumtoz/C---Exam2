Console.Write("Array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    System.Console.Write($"Enter number {i}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int amount=1;
for (int i = 0; i < n-1; i++)
{
    if (numbers[i] != numbers[i + 1])
    {
        amount++;
    }
}

System.Console.WriteLine("The number of different numbers are: "+amount);