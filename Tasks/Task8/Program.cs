int n = 0;
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

for (n = 0; n <= N; n = n + 2)
{
    if (n % 2 == 0)
    {
        Console.Write(n + " ");        
    }
    else
    {
        n = n + 1;
    }
}
Console.Write("- все четные числа в диапазоне от 0 до " + N);