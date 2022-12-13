Console.WriteLine("Введите количество чисел которое будем проверять");
int m = int.Parse(Console.ReadLine());

int[] array = CreationArray(m);

// PrintArray(array);

int positive_nam = AmountPositiveNambers(array);
Console.Write($"Количество положительных чисел равно {positive_nam}");

int[] CreationArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int AmountPositiveNambers(int[] array)
{
    int positive_nam = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positive_nam++;
        }
    }
    return positive_nam;
}

// void PrintArray(int[] array);
// {
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }
// Немогу понять почему он не хочет вывести массив, если подскажите будет великолепно.