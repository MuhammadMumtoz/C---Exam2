Console.Write("Enter the amount of variables for the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

var min = numbers[0];
int start = 0;
for (int i = 0; i < n; i++)
{
    if (min > numbers[i])
    {
        min = numbers[i]; start = i;
    }
}

var max = numbers[0];
int end = 0;
for (int i = 0; i < n; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i]; end = i;
    }
}

if (start > end)
{
    var reverse = start;
    start = end;
    end = reverse;
}

for (int i = start; i <= end; i++)
{
    Console.Write(numbers[i] + " ");
}