System.Console.Write("Enter the power of 2: ");
var n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
int pow = 1;
for (int i = 1; i <= n; i++)
{
    pow *= 2;
    sum = sum + pow;
}
System.Console.WriteLine($"The total is {sum}");

