using Common;

int[,] array = Helper.GenerateRandomArray(6, 8, 0, 10);
Helper.PrintArray(array);
Console.WriteLine();
int[,] array2 = OrderingArray(array);
Helper.PrintArray(array2);


int[,] OrderingArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = j; x < array.GetLength(1); x++)
            {
                int max = array[i, j];
                if (max < array[i, x])
                {
                    int trunsfer = 0;
                    trunsfer = array[i, j];
                    array[i, j] = array[i, x];
                    array[i, x] = trunsfer;
                }
            }

        }
    return array;
}