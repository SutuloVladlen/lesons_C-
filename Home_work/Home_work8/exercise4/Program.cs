using Common;
int a = 3;
int b = 3;
int c = 3;
int[,,] array = GenerateRandomArray(2, 2, 2);
PrintArray(array);
int[,,] GenerateRandomArray(int a, int b, int c)
{
    Random random = new Random();
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(0, 10);
                for (int i1 = 0; i1 < array.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < array.GetLength(1); j1++)
                    {
                        for (int k1 = 0; k1 < array.GetLength(2); k1++)
                        {
                            if (array[i, j, k] == array[i1, j1, k1])
                                array[i, j, k] = random.Next(0, 20);
                        }
                    }
                }
            }
        }
    }

    return (array);
}
void PrintArray(int[,,] array)
{
    // Console.Write("[");
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)

        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"({i},{j},{k}){array[i, j, k]},");
            }
        }
        Console.WriteLine();
    }
    // Console.Write("]");
}