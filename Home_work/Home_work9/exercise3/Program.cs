int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int a = Akerman(n, m);
Console.WriteLine(a);

int Akerman(int n, int m)
{
    if (n == 0)
    { return m + 1; }

    if (n != 0 && m == 0)
    { return Akerman(n - 1, 1); }

    if (n > 0 && m > 0)
    { return Akerman(n - 1, Akerman(n, m - 1)); }
    return Akerman(n, m);
}
