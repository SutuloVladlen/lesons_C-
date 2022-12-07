int[] array = GenerateArray(100, 999, 20);
PrintArray(array);

int positiv_nambers = QuantityPositivNanbers(array);
Console.WriteLine(positiv_nambers);

int QuantityPositivNanbers(int[] array)
{
    int caunt = 0;
    for (var i = 0; i < array.Length; i++)
    {

        int n = array[i];
        if (n % 2 == 0)
            caunt++;

    }
    return caunt;
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