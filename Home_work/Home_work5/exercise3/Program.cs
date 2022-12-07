int[] array = GenerateArray(0, 100, 30);
PrintArray(array);


int max = FaindMaxNamber(array);
Console.WriteLine($"Максимальное число {max}");


int min = FaindMinNamber(array);
Console.WriteLine($"Минимальное число {min}");

int resalt = max - min;
Console.WriteLine($"Разница между max и min = {resalt}");

int FaindMaxNamber(int[] array)
{
    int max = array[0];
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];

    }
    return max;
}

int FaindMinNamber(int[] array)
{
    int min = array[0];
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];

    }
    return min;
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
