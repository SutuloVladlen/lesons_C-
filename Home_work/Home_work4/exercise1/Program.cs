
Console.WriteLine("Введите число которое возводим в степень");

bool namberA = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите степень в которую возводим");

bool namberB = int.TryParse(Console.ReadLine(), out int b);

if (!namberA && !namberB)
{
    Console.WriteLine("Ввели не корректно данные");
    return;
}


double exponentiation = Exponentiation(a, b);

Console.WriteLine(exponentiation);

double Exponentiation(int a, int b)
{
    double expon = 1;
    for (int i = 1; i <= b; i++)

    {
        expon = expon * a;
    }
    return expon;

}
