Console.WriteLine("Введите пятизначное число");

bool namber5symbols = int.TryParse(Console.ReadLine(), out int n);

if (!namber5symbols)
{
    Console.WriteLine("Ввели не корректно данные");
    return;
}

bool x = DefinitioOfPalindromic(n);

Console.WriteLine(x);

bool DefinitioOfPalindromic(int n)
{
    int digitOne = n / 10000;
    int digitFive = n % 10;
    int digitTwy = (n / 1000) % 10;
    int digitFour = (n % 100) / 10;

    if (digitOne >= 10)//я не нашел способа как не ипользуя строк нормально вывести результат ошибку при 
    // введении не пятизначного числа (можно конечно в самом начале до метода это проверить, но тогда опять 
    //нужно вводить переменную)
    {
        return false;
    }
    if (digitFive == digitOne && digitFour == digitTwy)
    {
        return true;
    }
    else
    {
        return false;
    }

}



