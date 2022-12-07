int[] array = GenerateArray(-10, 10, 10);
PrintArray(array);

int sum = SumElementsArrayWethOddIndex(array);
Console.WriteLine(sum);

int SumElementsArrayWethOddIndex(int[] array)
{
    int summ = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            summ = summ + array[i];

    }
    return summ;
}

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    // Console.Write("[");
    // for (var i = 0; i < array.Length; i++)
    // {

    //     Console.Write($"{array[i]},");

    // }
    // Console.Write("]");
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{string.Join(" ,", array)}]");

    //Console.WriteLine("[{0}]", string.Join(", ", array));
}