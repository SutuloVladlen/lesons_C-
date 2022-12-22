using Common;

int[,] array = Helper.GenerateRandomArray(5, 5, 0, 10);
Helper.PrintArray(array);
int line = GenerateRandomArray(array);
Console.WriteLine($"Наименьшая сумма элементов в {line} строке");

int GenerateRandomArray(int[,] array)
{
    int minSum = 0;
    int lineNamber = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum = minSum + array[0, j];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            sum = sum + array[i, j];

        }
        if (minSum > sum)
        {
            minSum = sum;
            lineNamber = i + 1;
        }
    }
    return lineNamber;
}