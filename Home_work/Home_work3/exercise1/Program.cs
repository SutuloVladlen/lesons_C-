Console.WriteLine("Введите пятизначное число");

bool namber5symbols = int.TryParse(Console.ReadLine(), out int n);

if (!namber5symbols)
{
    Console.WriteLine("Ввели не корректно данные");
    return;
}

int x = DefinitioOfPalindromic(n);

if (x == 1)
{
    Console.WriteLine("Число является палиндромом");
}
if (x == -1)
{
    Console.WriteLine("Число не является пятизначным");
}
if (x == 0)
{
    Console.WriteLine("Число не является палиндромом");
}

int DefinitioOfPalindromic(int n)
{
    int digitOne = n / 10000;
    int digitFive = n % 10;
    int digitTwy = (n / 1000) % 10;
    int digitFour = (n % 100) / 10;

    if (digitOne >= 10 || n / 10000 == 0)
    {
        return -1;
    }
    if (digitFive == digitOne && digitFour == digitTwy)
    {
        return 1;
    }
    else
    {
        return 0;
    }

}

