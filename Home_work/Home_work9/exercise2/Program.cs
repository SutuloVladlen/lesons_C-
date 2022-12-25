Console.WriteLine("Введите два числа");
bool namber1 = int.TryParse(Console.ReadLine(), out int n);
bool namber2 = int.TryParse(Console.ReadLine(), out int m);
if (!namber1 || !namber2)
{
    Console.WriteLine("Введены некорректные данные.");

}
if (n > m)
{
    int x = n;
    n = m;
    m = x;
}

int c = SumNambers(n, m);
Console.WriteLine(c);

int SumNambers(int n, int m, int sum = 0)
{
    if (n < m)
    {
        sum = m + n;
        sum = sum + SumNambers(n + 1, m - 1);

    }
    if (n == m)
    {
        sum = sum + m;
        return sum;
    }
    return sum;

}