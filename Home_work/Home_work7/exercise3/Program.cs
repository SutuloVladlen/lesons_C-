Random random = new Random();

int[,] array2 = RandomArray(8, 12);
PrintArr(array2);
double[] array = ArithmeticMeanOfColumnElements(array2);
PrintArray(array);


double[] ArithmeticMeanOfColumnElements(int[,] array)
{
    double[] allArithmeticMean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = array[j, i] + sum;

        }
        double arithmeticMean = sum / array.GetLength(0);
        allArithmeticMean[i] = arithmeticMean;
    }
    return allArithmeticMean;
}

int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(-100, 100);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    // Console.Write("[");
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]},");
        }
        Console.WriteLine();
    }
    // Console.Write("]");
}
void PrintArray(double[] array)
{
    //Console.WriteLine("[{0}]", string.Join(", ", array));
    // Console.Write("[");
    // for (var i = 0; i < array.Length; i++)
    // {

    //     Console.Write($"{array[i]},");

    // }
    // Console.Write("]");
    string message = string.Join(" ,", array);
    Console.WriteLine($"[{string.Join(" ,", array)}]");

    // Console.WriteLine("[{0}]", string.Join(", ", array));
}