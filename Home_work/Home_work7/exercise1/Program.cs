Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
Random random = new Random();

int[,] array = RandomArray(m, n);
PrintArr(array);

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