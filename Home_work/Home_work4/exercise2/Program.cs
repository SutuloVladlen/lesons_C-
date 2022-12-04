Console.WriteLine("Введите число");

bool namber = int.TryParse(Console.ReadLine(), out int n);

if (!namber)
{
    Console.WriteLine("Ввели не корректно данные");
    return;
}

int summ = SumDigitNamber(n);
Console.WriteLine(summ);
int SumDigitNamber(int n)
{
    if (n < 10 && n > -10)
        return n;
    int sum = 0;
    int x = 0;
    if (n < 0)
    {
        n = n * -1;
        while (n / 10 > 0)
        {
            x = n % 10;
            sum = sum + x;
            n = n / 10;
            if (n <= 10)
            {
                sum = sum - n;
            }
        }

    }

    while (n / 10 > 0)
    {
        x = n % 10;
        sum = sum + x;
        n = n / 10;
        if (n <= 10)
        {
            sum = sum + n;
        }
    }
    return sum;
}