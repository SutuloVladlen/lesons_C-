using Common;
int a = 3;
int b = 3;
int c = 3;
int[,,] array = GenerateRandomArray(2, 2, 2);
PrintArray(array);
int[,,] GenerateRandomArray(int a, int b, int c)
{
    int z = 0;
    Random random = new Random();
    int[] arr = new int[a * b * c];
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++, z++)
            {
                array[i, j, k] = random.Next(0, 10);
                arr[z] = array[i, j, k];
                for (int o = 0; o < arr.Length; o++)
                {
                    if (arr[z] == arr[o])
                    { array[i, j, k] = random.Next(11, 20); }
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